using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO;
using FuzzyString;
using MySqlX.XDevAPI.Common;


namespace trichdanhay
{
    public partial class Form1 : Form
    {
        public static class PasswordHasher
        {
            public static string HashPassword(string password)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // Chuyển đổi mật khẩu thành mảng byte và tính toán hash
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                    // Chuyển đổi mảng byte thành chuỗi hex
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }

        private bool IsAdmin = false; // Biến lưu quyền Admin
        public Form1()
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            LoadQuotes();
            LoadAuthors();
            LoadSubjects();
        }

        //Hiển thị Form đăng nhập khi load ứng dụng


        private void LoadQuotes(string orderBy = "Subject")
        {
            string query = $"SELECT Subject, QuoteText, Author, Source  FROM Quotes ORDER BY {orderBy}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    richTextBox_hienthitrichdan.Clear();

                    Color[] alternatingColors = { Color.White, Color.LightGray };
                    int colorIndex = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string formattedQuote = $"• {row["Subject"]} | {row["QuoteText"]} | {row["Author"]} | {row["Source"]}\n";
                        richTextBox_hienthitrichdan.SelectionBackColor = alternatingColors[colorIndex % 2];
                        richTextBox_hienthitrichdan.AppendText(formattedQuote);
                        richTextBox_hienthitrichdan.SelectionBackColor = richTextBox_hienthitrichdan.BackColor;
                        richTextBox_hienthitrichdan.AppendText(new string('-', 100) + "\n\n");
                        colorIndex++;
                    }

                }
            }
            try
            {
                // Code kết nối và truy vấn cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        // Tìm trích dẫn
        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox_timtrichdan.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadQuotes(); // Nếu TextBox trống, hiển thị lại tất cả trích dẫn
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT QuoteText, Author, Subject, Source FROM Quotes WHERE QuoteText LIKE @searchText OR Author LIKE @searchText OR Subject LIKE @searchText";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    richTextBox_hienthitrichdan.Clear();

                    Color[] alternatingColors = { Color.White, Color.LightGray };
                    int colorIndex = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string formattedQuote = $"• {row["Subject"]} | {row["QuoteText"]} | {row["Author"]} | {row["Source"]}\n";
                        richTextBox_hienthitrichdan.SelectionBackColor = alternatingColors[colorIndex % 2];
                        richTextBox_hienthitrichdan.AppendText(formattedQuote);
                        richTextBox_hienthitrichdan.SelectionBackColor = richTextBox_hienthitrichdan.BackColor;
                        richTextBox_hienthitrichdan.AppendText(new string('-', 100) + "\n\n");
                        colorIndex++;
                    }
                }
            }
        }
        private string connectionString = "Server=localhost;Database=QuoteDB;User Id=root;Password=78998784567865;";

        // Tính năng lưu trích dẫn
        private void buttonLuutrichdan_Click(object sender, EventArgs e)
        {
            string cauTrichdan = textBoxCautrichdan.Text;
            string tacgia = textBoxTacgia.Text;
            string chude = textBoxChude.Text;
            string nguon = textBoxNguon.Text;

            if (string.IsNullOrEmpty(cauTrichdan))
            {
                MessageBox.Show("Vui lòng nhập câu trích dẫn");
                return;
            }

            // Lấy danh sách tác giả từ DB để so khớp
            List<string> existingAuthors = GetAllAuthorsFromDB();

            // Kiểm tra tên tác giả nhập vào có tương đồng với tên đã có trong DB
            string similarAuthor = CheckDuplicateAuthor(tacgia, existingAuthors);

            if (similarAuthor != null)
            {
                // Hỏi người dùng có muốn dùng tên tác giả đã tồn tại không
                DialogResult result = MessageBox.Show(
                    $"Tên tác giả '{tacgia}' có thể là '{similarAuthor}'. Bạn có muốn sử dụng tên này không?",
                    "Phát hiện trùng lặp tác giả",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    tacgia = similarAuthor; // Sử dụng tên tác giả đã tồn tại
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Quotes (QuoteText, Author, Subject, Source) VALUES (@cautrichdan, @tacgia, @chude, @nguon)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cautrichdan", cauTrichdan);
                    cmd.Parameters.AddWithValue("@tacgia", tacgia);
                    cmd.Parameters.AddWithValue("@chude", chude);
                    cmd.Parameters.AddWithValue("@nguon", nguon);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Lưu trích dẫn thành công");
                        textBoxCautrichdan.Clear();
                        textBoxTacgia.Clear();
                        textBoxChude.Clear();
                        textBoxNguon.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lưu trích dẫn thất bại");
                    }
                }
            }
        }
        //Copy câu trích dẫn
        private void richTextBox_hienthitrichdan_MouseClick(object sender, MouseEventArgs e)
        {
            // lấy vị trí ký tự tại nơi click chuột
            int charIndex = richTextBox_hienthitrichdan.GetCharIndexFromPosition(e.Location);

            //Xác định dòng chứa ký tự tại vị trí đó
            int lineIndex = richTextBox_hienthitrichdan.GetLineFromCharIndex(charIndex);

            //Lấy nội dung của dòng đó
            if (lineIndex >= 0 && lineIndex < richTextBox_hienthitrichdan.Lines.Length)
            {
                string selectedQuote = richTextBox_hienthitrichdan.Lines[lineIndex];
                if (!string.IsNullOrEmpty(selectedQuote))

                {
                    //sao chép trích dẫn vào clipboard
                    Clipboard.SetText(selectedQuote);
                    MessageBox.Show("Đã sao chép trích dẫn");
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string hashPassword = PasswordHasher.HashPassword(password);
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT IsAdmin FROM User WHERE Username = @username AND Password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        IsAdmin = Convert.ToBoolean(result);  //Lấy quyền Admin từ kết quả truy vấn
                        MessageBox.Show("Đăng nhập thành công");
                        labelTrangthai.Text = $"Bạn đang đăng nhập với tên: {username}";
                        labelTrangthai.Visible = true;
                        btnLogout.Visible = true;
                        //Ẩn đăng nhập
                        lb_username.Visible = false;
                        lb_password.Visible = false;
                        textBoxUsername.Visible = false;
                        textBoxPassword.Visible = false;
                        btnLogin.Visible = false;
                        // Xử lý đăng xuất
                        btnLogout.Click += (s, args) => {

                            //Ẩn đăng nhập
                            labelTrangthai.Visible = false;
                            textBoxUsername.Visible = true;
                            textBoxPassword.Visible = true;
                            btnLogin.Visible = true;
                            lb_username.Visible = true;
                            lb_password.Visible = true;


                            //Xoá thông tin đăng nhập
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();

                            //Ẩn nút đăng xuất
                            btnLogout.Visible = false;
                        };
                        this.Controls.Add(btnLogout);

                        //Nếu là Admin;
                        if (IsAdmin)
                        {
                            tableLayoutPanelThemtrichdan.Visible = true;
                        }
                        else
                        {
                            //Ẩn tính năng lưu
                            tableLayoutPanelThemtrichdan.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập chưa chính xác");
                    }
                    //Xoá thông tin đăng nhập
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();

                }


            }

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lb_timtrichdan_Click(object sender, EventArgs e)
        {

        }

        //Import trích dẫn
        private DataTable ImportFromExcel(string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            DataTable dt = new DataTable();
            List<string> existingAuthors = GetAllAuthorsFromDB(); // Lấy danh sách các tác giả đã có từ DB

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // chọn sheet đầu tiên

                // Lấy số lượng hàng và cột trong sheet
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Tạo cột trong DataTable từ file Excel
                for (int col = 1; col <= colCount; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Value?.ToString() ?? $"Column{col}");
                }

                // Đọc dữ liệu từ hàng thứ 2, bỏ tiêu đề
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dataRow = dt.NewRow();
                    string authorName = worksheet.Cells[row, 1].Value?.ToString(); // Giả sử cột đầu tiên là tên tác giả

                    // Kiểm tra trùng lặp tên tác giả bằng thuật toán so khớp tương đồng
                    string similarAuthor = CheckDuplicateAuthor(authorName, existingAuthors);

                    if (similarAuthor != null)
                    {
                        // Hỏi người dùng có muốn dùng tên tác giả đã tồn tại không
                        DialogResult result = MessageBox.Show(
                            $"Tên tác giả '{authorName}' có thể là '{similarAuthor}'. Bạn có muốn sử dụng tên này không?",
                            "Phát hiện trùng lặp tác giả",
                            MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            authorName = similarAuthor; // Sử dụng tên tác giả đã tồn tại
                        }
                    }

                    dataRow[0] = authorName; // Ghi tên tác giả vào dòng hiện tại

                    // Đọc các cột còn lại
                    for (int col = 2; col <= colCount; col++)
                    {
                        dataRow[col - 1] = worksheet.Cells[row, col].Value?.ToString();
                    }

                    dt.Rows.Add(dataRow); // Thêm dòng vào DataTable
                }
            }

            return dt;
        }

        private void buttonImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = ImportFromExcel(openFileDialog.FileName);


                //hoặc lưu dữ liệu vào DB
                SaveDataToDatabase(dt);
                MessageBox.Show("Dữ liệu đã được thêm thành công!");


            }
        }

        private void SaveDataToDatabase(DataTable dt)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataRow row in dt.Rows)
                {
                    string query = "INSERT INTO Quotes (Subject,QuoteText,Author,Source) VALUES (@subject, @quoteText, @author, @source)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subject", row["Subject"]);
                        cmd.Parameters.AddWithValue("@quoteText", row["QuoteText"]);
                        cmd.Parameters.AddWithValue("@author", row["Author"]);
                        cmd.Parameters.AddWithValue("@source", row["Source"]);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }

        // Chọn theo tác giả

        private void LoadAuthors()
        {
            string query = "SELECT DISTINCT Author FROM Quotes";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBoxAuthors.Items.Clear(); // Xóa tất cả các mục hiện có
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBoxAuthors.Items.Add(row["Author"].ToString());
                    }
                }
            }
        }

        private void LoadQuotesByAuthor(string author)
        {
            string query = "SELECT QuoteText, Author, Subject, Source FROM Quotes WHERE Author = @Author";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Author", author);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    richTextBox_hienthitrichdan.Clear(); // Xóa nội dung cũ

                    Color[] alternatingColors = { Color.White, Color.LightGray };
                    int colorIndex = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string formattedQuote = $"• {row["Subject"]} | {row["QuoteText"]} | {row["Author"]} | {row["Source"]}\n";
                        richTextBox_hienthitrichdan.SelectionBackColor = alternatingColors[colorIndex % 2];
                        richTextBox_hienthitrichdan.AppendText(formattedQuote);
                        richTextBox_hienthitrichdan.SelectionBackColor = richTextBox_hienthitrichdan.BackColor;
                        richTextBox_hienthitrichdan.AppendText(new string('-', 100) + "\n\n");
                        colorIndex++;
                    }
                }
            }
        }



        // Chọn theo chủ đề
        private void LoadSubjects()
        {
            string query = "SELECT DISTINCT Subject FROM Quotes";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBoxSubjects.Items.Clear(); // Xóa tất cả các mục hiện có
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBoxSubjects.Items.Add(row["Subject"].ToString());
                    }
                }
            }
        }
        private void LoadQuotesBySubject(string subject)
        {
            string query = "SELECT QuoteText, Author, Subject, Source FROM Quotes WHERE Subject = @Subject";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Subject", subject);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    richTextBox_hienthitrichdan.Clear(); // Xóa nội dung cũ

                    Color[] alternatingColors = { Color.White, Color.LightGray };
                    int colorIndex = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string formattedQuote = $"• {row["Subject"]} | {row["QuoteText"]} | {row["Author"]} | {row["Source"]}\n";
                        richTextBox_hienthitrichdan.SelectionBackColor = alternatingColors[colorIndex % 2];
                        richTextBox_hienthitrichdan.AppendText(formattedQuote);
                        richTextBox_hienthitrichdan.SelectionBackColor = richTextBox_hienthitrichdan.BackColor;
                        richTextBox_hienthitrichdan.AppendText(new string('-', 100) + "\n\n");
                        colorIndex++;
                    }
                }
            }
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = comboBoxSubjects.SelectedItem.ToString();
            LoadQuotesBySubject(selectedSubject);
        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string slectedAuthor = comboBoxAuthors.SelectedItem.ToString();
            LoadQuotesByAuthor(slectedAuthor);
        }

        // Hàm kiểm tra tác giả trùng lặp sử dụng FuzzyString


        private string CheckDuplicateAuthor(string newAuthor, List<string> existingAuthors)
        {
            foreach (string author in existingAuthors)
            {
                bool comparisonResults = newAuthor.ApproximatelyEquals(author, FuzzyStringComparisonTolerance.Normal);
                if (comparisonResults) // Nếu phát hiện tên tương tự
                {
                    return author; // Trả về tên tác giả đã có trong DB
                }
            }
            return null; // Không có tác giả tương tự
        }

        // Hàm lấy danh sách tất cả tác giả từ DB
        private List<string> GetAllAuthorsFromDB()
        {
            List<string> authors = new List<string>();
            string query = "SELECT DISTINCT Author FROM Quotes";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(reader.GetString("Author"));
                        }
                    }
                }
            }
            return authors;
        }

    }
}