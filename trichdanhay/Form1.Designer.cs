namespace trichdanhay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCautrichdan = new System.Windows.Forms.Label();
            this.textBoxCautrichdan = new System.Windows.Forms.TextBox();
            this.labelTacgia = new System.Windows.Forms.Label();
            this.labelChude = new System.Windows.Forms.Label();
            this.textBoxTacgia = new System.Windows.Forms.TextBox();
            this.textBoxChude = new System.Windows.Forms.TextBox();
            this.buttonLuutrichdan = new System.Windows.Forms.Button();
            this.labelTrangthai = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBoxNguon = new System.Windows.Forms.TextBox();
            this.labelNguon = new System.Windows.Forms.Label();
            this.richTextBox_hienthitrichdan = new System.Windows.Forms.RichTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.tabTimtrichdan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelChontheotacgia = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.labelChontheochude = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_timtrichdan = new System.Windows.Forms.Label();
            this.textBox_timtrichdan = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelThemtrichdan = new System.Windows.Forms.TableLayoutPanel();
            this.buttonImportExcel = new System.Windows.Forms.Button();
            this.tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tabTimtrichdan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelThemtrichdan.SuspendLayout();
            this.tableLayoutPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCautrichdan
            // 
            this.labelCautrichdan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCautrichdan.AutoSize = true;
            this.labelCautrichdan.Location = new System.Drawing.Point(10, 14);
            this.labelCautrichdan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCautrichdan.Name = "labelCautrichdan";
            this.labelCautrichdan.Size = new System.Drawing.Size(92, 20);
            this.labelCautrichdan.TabIndex = 4;
            this.labelCautrichdan.Text = "Câu trích dẫn";
            // 
            // textBoxCautrichdan
            // 
            this.textBoxCautrichdan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCautrichdan.Location = new System.Drawing.Point(110, 10);
            this.textBoxCautrichdan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCautrichdan.Name = "textBoxCautrichdan";
            this.textBoxCautrichdan.Size = new System.Drawing.Size(644, 28);
            this.textBoxCautrichdan.TabIndex = 5;
            // 
            // labelTacgia
            // 
            this.labelTacgia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTacgia.AutoSize = true;
            this.labelTacgia.Location = new System.Drawing.Point(50, 62);
            this.labelTacgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTacgia.Name = "labelTacgia";
            this.labelTacgia.Size = new System.Drawing.Size(52, 20);
            this.labelTacgia.TabIndex = 6;
            this.labelTacgia.Text = "Tác giả";
            // 
            // labelChude
            // 
            this.labelChude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChude.AutoSize = true;
            this.labelChude.Location = new System.Drawing.Point(50, 110);
            this.labelChude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChude.Name = "labelChude";
            this.labelChude.Size = new System.Drawing.Size(52, 20);
            this.labelChude.TabIndex = 7;
            this.labelChude.Text = "Chủ đề";
            // 
            // textBoxTacgia
            // 
            this.textBoxTacgia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTacgia.Location = new System.Drawing.Point(110, 58);
            this.textBoxTacgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTacgia.Name = "textBoxTacgia";
            this.textBoxTacgia.Size = new System.Drawing.Size(389, 28);
            this.textBoxTacgia.TabIndex = 8;
            // 
            // textBoxChude
            // 
            this.textBoxChude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxChude.Location = new System.Drawing.Point(110, 106);
            this.textBoxChude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxChude.Name = "textBoxChude";
            this.textBoxChude.Size = new System.Drawing.Size(389, 28);
            this.textBoxChude.TabIndex = 9;
            // 
            // buttonLuutrichdan
            // 
            this.buttonLuutrichdan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLuutrichdan.Location = new System.Drawing.Point(499, 202);
            this.buttonLuutrichdan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLuutrichdan.Name = "buttonLuutrichdan";
            this.buttonLuutrichdan.Size = new System.Drawing.Size(256, 48);
            this.buttonLuutrichdan.TabIndex = 10;
            this.buttonLuutrichdan.Text = "Lưu trích dẫn";
            this.buttonLuutrichdan.UseVisualStyleBackColor = true;

            // 
            // labelTrangthai
            // 
            this.labelTrangthai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTrangthai.AutoSize = true;
            this.labelTrangthai.Location = new System.Drawing.Point(307, 12);
            this.labelTrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrangthai.Name = "labelTrangthai";
            this.labelTrangthai.Size = new System.Drawing.Size(0, 20);
            this.labelTrangthai.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.Location = new System.Drawing.Point(315, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 30);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            // 
            // textBoxNguon
            // 
            this.textBoxNguon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNguon.Location = new System.Drawing.Point(110, 156);
            this.textBoxNguon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNguon.Name = "textBoxNguon";
            this.textBoxNguon.Size = new System.Drawing.Size(389, 28);
            this.textBoxNguon.TabIndex = 20;
            // 
            // labelNguon
            // 
            this.labelNguon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNguon.AutoSize = true;
            this.labelNguon.Location = new System.Drawing.Point(53, 160);
            this.labelNguon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNguon.Name = "labelNguon";
            this.labelNguon.Size = new System.Drawing.Size(49, 20);
            this.labelNguon.TabIndex = 21;
            this.labelNguon.Text = "Nguồn";
            // 
            // richTextBox_hienthitrichdan
            // 
            this.richTextBox_hienthitrichdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_hienthitrichdan.Font = new System.Drawing.Font("UTM Khuccamta", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_hienthitrichdan.Location = new System.Drawing.Point(4, 5);
            this.richTextBox_hienthitrichdan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_hienthitrichdan.Name = "richTextBox_hienthitrichdan";
            this.richTextBox_hienthitrichdan.Size = new System.Drawing.Size(1188, 442);
            this.richTextBox_hienthitrichdan.TabIndex = 3;
            this.richTextBox_hienthitrichdan.Text = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.Location = new System.Drawing.Point(312, 5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 37);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.Location = new System.Drawing.Point(158, 57);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(129, 28);
            this.textBoxPassword.TabIndex = 14;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUsername.Location = new System.Drawing.Point(158, 9);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(129, 28);
            this.textBoxUsername.TabIndex = 12;
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(84, 61);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(66, 20);
            this.lb_password.TabIndex = 13;
            this.lb_password.Text = "Mật khẩu";
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(50, 13);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(100, 20);
            this.lb_username.TabIndex = 11;
            this.lb_username.Text = "Tên đăng nhập";
            // 
            // tabTimtrichdan
            // 
            this.tabTimtrichdan.Controls.Add(this.tabPage1);
            this.tabTimtrichdan.Controls.Add(this.tabPage2);
            this.tabTimtrichdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTimtrichdan.Location = new System.Drawing.Point(0, 0);
            this.tabTimtrichdan.Name = "tabTimtrichdan";
            this.tabTimtrichdan.SelectedIndex = 0;
            this.tabTimtrichdan.Size = new System.Drawing.Size(1261, 890);
            this.tabTimtrichdan.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm trích dẫn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelChontheotacgia);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxAuthors);
            this.flowLayoutPanel1.Controls.Add(this.labelChontheochude);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSubjects);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(306, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 35);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // labelChontheotacgia
            // 
            this.labelChontheotacgia.AutoSize = true;
            this.labelChontheotacgia.Location = new System.Drawing.Point(3, 0);
            this.labelChontheotacgia.Name = "labelChontheotacgia";
            this.labelChontheotacgia.Size = new System.Drawing.Size(52, 20);
            this.labelChontheotacgia.TabIndex = 24;
            this.labelChontheotacgia.Text = "Tác giả";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(61, 3);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(240, 28);
            this.comboBoxAuthors.TabIndex = 22;
            // 
            // labelChontheochude
            // 
            this.labelChontheochude.AutoSize = true;
            this.labelChontheochude.Location = new System.Drawing.Point(307, 0);
            this.labelChontheochude.Name = "labelChontheochude";
            this.labelChontheochude.Size = new System.Drawing.Size(52, 20);
            this.labelChontheochude.TabIndex = 25;
            this.labelChontheochude.Text = "Chủ đề";
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(365, 3);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(240, 28);
            this.comboBoxSubjects.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_hienthitrichdan, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 210);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1196, 452);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.87245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.12755F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.lb_timtrichdan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_timtrichdan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_timkiem, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(221, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 87);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lb_timtrichdan
            // 
            this.lb_timtrichdan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_timtrichdan.AutoSize = true;
            this.lb_timtrichdan.Location = new System.Drawing.Point(61, 11);
            this.lb_timtrichdan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_timtrichdan.Name = "lb_timtrichdan";
            this.lb_timtrichdan.Size = new System.Drawing.Size(94, 20);
            this.lb_timtrichdan.TabIndex = 0;
            this.lb_timtrichdan.Text = "Tìm trích dẫn";
            // 
            // textBox_timtrichdan
            // 
            this.textBox_timtrichdan.Location = new System.Drawing.Point(163, 5);
            this.textBox_timtrichdan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_timtrichdan.Name = "textBox_timtrichdan";
            this.textBox_timtrichdan.Size = new System.Drawing.Size(405, 28);
            this.textBox_timtrichdan.TabIndex = 1;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Location = new System.Drawing.Point(643, 5);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(146, 33);
            this.bt_timkiem.TabIndex = 2;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.tableLayoutPanelThemtrichdan);
            this.tabPage2.Controls.Add(this.tableLayoutPanelLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1253, 857);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.22176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.77824F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTrangthai, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(380, 266);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 44);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // tableLayoutPanelThemtrichdan
            // 
            this.tableLayoutPanelThemtrichdan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelThemtrichdan.ColumnCount = 2;
            this.tableLayoutPanelThemtrichdan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.02509F));
            this.tableLayoutPanelThemtrichdan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.97491F));
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.labelCautrichdan, 0, 0);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.labelTacgia, 0, 1);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.buttonLuutrichdan, 1, 4);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.labelChude, 0, 2);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.labelNguon, 0, 3);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.textBoxChude, 1, 2);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.textBoxCautrichdan, 1, 0);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.textBoxTacgia, 1, 1);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.textBoxNguon, 1, 3);
            this.tableLayoutPanelThemtrichdan.Controls.Add(this.buttonImportExcel, 1, 5);
            this.tableLayoutPanelThemtrichdan.Location = new System.Drawing.Point(211, 315);
            this.tableLayoutPanelThemtrichdan.Name = "tableLayoutPanelThemtrichdan";
            this.tableLayoutPanelThemtrichdan.RowCount = 6;
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanelThemtrichdan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelThemtrichdan.Size = new System.Drawing.Size(759, 294);
            this.tableLayoutPanelThemtrichdan.TabIndex = 23;
            this.tableLayoutPanelThemtrichdan.Visible = false;
            // 
            // buttonImportExcel
            // 
            this.buttonImportExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonImportExcel.Location = new System.Drawing.Point(367, 260);
            this.buttonImportExcel.Name = "buttonImportExcel";
            this.buttonImportExcel.Size = new System.Drawing.Size(389, 31);
            this.buttonImportExcel.TabIndex = 25;
            this.buttonImportExcel.Text = "Nhập dữ liệu từ file Excel";
            this.buttonImportExcel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLogin
            // 
            this.tableLayoutPanelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelLogin.ColumnCount = 3;
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanelLogin.Controls.Add(this.lb_username, 0, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.lb_password, 0, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.textBoxUsername, 1, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.textBoxPassword, 1, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.btnLogin, 2, 0);
            this.tableLayoutPanelLogin.Location = new System.Drawing.Point(380, 73);
            this.tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
            this.tableLayoutPanelLogin.RowCount = 2;
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.Size = new System.Drawing.Size(425, 95);
            this.tableLayoutPanelLogin.TabIndex = 22;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 890);
            this.Controls.Add(this.tabTimtrichdan);
            this.Font = new System.Drawing.Font("UTM Nyala", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Trích dẫn hay";
            this.tabTimtrichdan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelThemtrichdan.ResumeLayout(false);
            this.tableLayoutPanelThemtrichdan.PerformLayout();
            this.tableLayoutPanelLogin.ResumeLayout(false);
            this.tableLayoutPanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        private void RichTextBox_hienthitrichdan_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label labelCautrichdan;
        private System.Windows.Forms.TextBox textBoxCautrichdan;
        private System.Windows.Forms.Label labelTacgia;
        private System.Windows.Forms.Label labelChude;
        private System.Windows.Forms.TextBox textBoxTacgia;
        private System.Windows.Forms.TextBox textBoxChude;
        private System.Windows.Forms.Button buttonLuutrichdan;
        private System.Windows.Forms.Label labelTrangthai;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBoxNguon;
        private System.Windows.Forms.Label labelNguon;
        private System.Windows.Forms.RichTextBox richTextBox_hienthitrichdan;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TabControl tabTimtrichdan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_timtrichdan;
        private System.Windows.Forms.TextBox textBox_timtrichdan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelThemtrichdan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonImportExcel;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label labelChontheochude;
        private System.Windows.Forms.Label labelChontheotacgia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

