namespace DBUserManager
{
    partial class AddUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.gpSingleUserAdd = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new MetroFramework.Controls.MetroButton();
            this.chkSendWelcomeEmail = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSurname = new MetroFramework.Controls.MetroLabel();
            this.lblFirstname = new MetroFramework.Controls.MetroLabel();
            this.txtEmailaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.gpListUsers = new System.Windows.Forms.GroupBox();
            this.List = new MetroFramework.Controls.MetroButton();
            this.txtLimit = new MetroFramework.Controls.MetroTextBox();
            this.lblLimit = new MetroFramework.Controls.MetroLabel();
            this.DVGResults = new MetroFramework.Controls.MetroGrid();
            this.gpAuthenticate = new System.Windows.Forms.GroupBox();
            this.txtAccesstoken = new MetroFramework.Controls.MetroTextBox();
            this.lblAccesstoken = new MetroFramework.Controls.MetroLabel();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.gbLicences = new System.Windows.Forms.GroupBox();
            this.btnCheckLicenses = new MetroFramework.Controls.MetroButton();
            this.lblprovisionedusersnumber = new MetroFramework.Controls.MetroLabel();
            this.lbllicensesavailablenumber = new MetroFramework.Controls.MetroLabel();
            this.lblprovisionedusers = new MetroFramework.Controls.MetroLabel();
            this.lbllicensedusers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gbExcel = new System.Windows.Forms.GroupBox();
            this.lblLicensenotification = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddUsers = new MetroFramework.Controls.MetroButton();
            this.lblCSVinstructions = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblCSV = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtBulkAddCSV = new MetroFramework.Controls.MetroTextBox();
            this.AdduserTooltip = new MetroFramework.Components.MetroToolTip();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblStatusText = new MetroFramework.Controls.MetroLabel();
            this.pbLoadingGif = new System.Windows.Forms.PictureBox();
            this.gpSingleUserAdd.SuspendLayout();
            this.gpListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).BeginInit();
            this.gpAuthenticate.SuspendLayout();
            this.gbLicences.SuspendLayout();
            this.gbExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSingleUserAdd
            // 
            this.gpSingleUserAdd.Controls.Add(this.metroLabel4);
            this.gpSingleUserAdd.Controls.Add(this.groupBox1);
            this.gpSingleUserAdd.Controls.Add(this.btnAddUser);
            this.gpSingleUserAdd.Controls.Add(this.chkSendWelcomeEmail);
            this.gpSingleUserAdd.Controls.Add(this.metroLabel1);
            this.gpSingleUserAdd.Controls.Add(this.lblSurname);
            this.gpSingleUserAdd.Controls.Add(this.lblFirstname);
            this.gpSingleUserAdd.Controls.Add(this.txtEmailaddress);
            this.gpSingleUserAdd.Controls.Add(this.txtSurname);
            this.gpSingleUserAdd.Controls.Add(this.txtFirstname);
            this.gpSingleUserAdd.Location = new System.Drawing.Point(23, 189);
            this.gpSingleUserAdd.Name = "gpSingleUserAdd";
            this.gpSingleUserAdd.Size = new System.Drawing.Size(295, 294);
            this.gpSingleUserAdd.TabIndex = 2;
            this.gpSingleUserAdd.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(19, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(133, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Single User Add";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 5);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(62, 245);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(167, 23);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // chkSendWelcomeEmail
            // 
            this.chkSendWelcomeEmail.AutoSize = true;
            this.chkSendWelcomeEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSendWelcomeEmail.Location = new System.Drawing.Point(78, 224);
            this.chkSendWelcomeEmail.Name = "chkSendWelcomeEmail";
            this.chkSendWelcomeEmail.Size = new System.Drawing.Size(132, 15);
            this.chkSendWelcomeEmail.TabIndex = 4;
            this.chkSendWelcomeEmail.Text = "Send welcome email";
            this.chkSendWelcomeEmail.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Email address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(113, 112);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 19);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(105, 64);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(70, 19);
            this.lblFirstname.TabIndex = 7;
            this.lblFirstname.Text = "First name";
            // 
            // txtEmailaddress
            // 
            this.txtEmailaddress.Lines = new string[0];
            this.txtEmailaddress.Location = new System.Drawing.Point(62, 184);
            this.txtEmailaddress.MaxLength = 32767;
            this.txtEmailaddress.Name = "txtEmailaddress";
            this.txtEmailaddress.PasswordChar = '\0';
            this.txtEmailaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailaddress.SelectedText = "";
            this.txtEmailaddress.Size = new System.Drawing.Size(167, 23);
            this.txtEmailaddress.TabIndex = 3;
            this.txtEmailaddress.UseSelectable = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(62, 136);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.Size = new System.Drawing.Size(167, 23);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.UseSelectable = true;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.White;
            this.txtFirstname.Lines = new string[0];
            this.txtFirstname.Location = new System.Drawing.Point(62, 86);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.Size = new System.Drawing.Size(167, 23);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.UseSelectable = true;
            // 
            // gpListUsers
            // 
            this.gpListUsers.Controls.Add(this.List);
            this.gpListUsers.Controls.Add(this.txtLimit);
            this.gpListUsers.Controls.Add(this.lblLimit);
            this.gpListUsers.Controls.Add(this.DVGResults);
            this.gpListUsers.Location = new System.Drawing.Point(23, 489);
            this.gpListUsers.Name = "gpListUsers";
            this.gpListUsers.Size = new System.Drawing.Size(595, 237);
            this.gpListUsers.TabIndex = 4;
            this.gpListUsers.TabStop = false;
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(301, 16);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(155, 23);
            this.List.TabIndex = 2;
            this.List.Text = "List users";
            this.List.UseSelectable = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // txtLimit
            // 
            this.txtLimit.Lines = new string[0];
            this.txtLimit.Location = new System.Drawing.Point(62, 20);
            this.txtLimit.MaxLength = 32767;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.PasswordChar = '\0';
            this.txtLimit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLimit.SelectedText = "";
            this.txtLimit.Size = new System.Drawing.Size(167, 23);
            this.txtLimit.TabIndex = 1;
            this.txtLimit.UseSelectable = true;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(19, 20);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(37, 19);
            this.lblLimit.TabIndex = 1;
            this.lblLimit.Text = "Limit";
            // 
            // DVGResults
            // 
            this.DVGResults.AllowUserToResizeRows = false;
            this.DVGResults.BackgroundColor = System.Drawing.Color.Silver;
            this.DVGResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVGResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DVGResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DVGResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVGResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVGResults.EnableHeadersVisualStyles = false;
            this.DVGResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DVGResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DVGResults.Location = new System.Drawing.Point(62, 57);
            this.DVGResults.Name = "DVGResults";
            this.DVGResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DVGResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DVGResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGResults.Size = new System.Drawing.Size(514, 150);
            this.DVGResults.TabIndex = 0;
            this.DVGResults.TabStop = false;
            // 
            // gpAuthenticate
            // 
            this.gpAuthenticate.Controls.Add(this.txtAccesstoken);
            this.gpAuthenticate.Controls.Add(this.lblAccesstoken);
            this.gpAuthenticate.Location = new System.Drawing.Point(23, 70);
            this.gpAuthenticate.Name = "gpAuthenticate";
            this.gpAuthenticate.Size = new System.Drawing.Size(295, 113);
            this.gpAuthenticate.TabIndex = 0;
            this.gpAuthenticate.TabStop = false;
            // 
            // txtAccesstoken
            // 
            this.txtAccesstoken.Lines = new string[0];
            this.txtAccesstoken.Location = new System.Drawing.Point(62, 39);
            this.txtAccesstoken.MaxLength = 32767;
            this.txtAccesstoken.Name = "txtAccesstoken";
            this.txtAccesstoken.PasswordChar = '\0';
            this.txtAccesstoken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccesstoken.SelectedText = "";
            this.txtAccesstoken.Size = new System.Drawing.Size(167, 23);
            this.txtAccesstoken.TabIndex = 1;
            this.txtAccesstoken.UseSelectable = true;
            // 
            // lblAccesstoken
            // 
            this.lblAccesstoken.AutoSize = true;
            this.lblAccesstoken.Location = new System.Drawing.Point(91, 9);
            this.lblAccesstoken.Name = "lblAccesstoken";
            this.lblAccesstoken.Size = new System.Drawing.Size(83, 19);
            this.lblAccesstoken.TabIndex = 0;
            this.lblAccesstoken.Text = "Access token";
            // 
            // gbLine
            // 
            this.gbLine.Location = new System.Drawing.Point(23, 63);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(595, 5);
            this.gbLine.TabIndex = 3;
            this.gbLine.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(23, 786);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(78, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright 2015";
            // 
            // gbLicences
            // 
            this.gbLicences.Controls.Add(this.btnCheckLicenses);
            this.gbLicences.Controls.Add(this.lblprovisionedusersnumber);
            this.gbLicences.Controls.Add(this.lbllicensesavailablenumber);
            this.gbLicences.Controls.Add(this.lblprovisionedusers);
            this.gbLicences.Controls.Add(this.lbllicensedusers);
            this.gbLicences.Controls.Add(this.metroLabel2);
            this.gbLicences.Location = new System.Drawing.Point(324, 70);
            this.gbLicences.Name = "gbLicences";
            this.gbLicences.Size = new System.Drawing.Size(295, 113);
            this.gbLicences.TabIndex = 1;
            this.gbLicences.TabStop = false;
            // 
            // btnCheckLicenses
            // 
            this.btnCheckLicenses.Location = new System.Drawing.Point(179, 55);
            this.btnCheckLicenses.Name = "btnCheckLicenses";
            this.btnCheckLicenses.Size = new System.Drawing.Size(96, 23);
            this.btnCheckLicenses.TabIndex = 1;
            this.btnCheckLicenses.Text = "Update";
            this.btnCheckLicenses.UseSelectable = true;
            this.btnCheckLicenses.Click += new System.EventHandler(this.btnCheckLicenses_Click);
            // 
            // lblprovisionedusersnumber
            // 
            this.lblprovisionedusersnumber.AutoSize = true;
            this.lblprovisionedusersnumber.Location = new System.Drawing.Point(126, 59);
            this.lblprovisionedusersnumber.Name = "lblprovisionedusersnumber";
            this.lblprovisionedusersnumber.Size = new System.Drawing.Size(16, 19);
            this.lblprovisionedusersnumber.TabIndex = 4;
            this.lblprovisionedusersnumber.Text = "0";
            // 
            // lbllicensesavailablenumber
            // 
            this.lbllicensesavailablenumber.AutoSize = true;
            this.lbllicensesavailablenumber.Location = new System.Drawing.Point(126, 39);
            this.lbllicensesavailablenumber.Name = "lbllicensesavailablenumber";
            this.lbllicensesavailablenumber.Size = new System.Drawing.Size(16, 19);
            this.lbllicensesavailablenumber.TabIndex = 3;
            this.lbllicensesavailablenumber.Text = "0";
            // 
            // lblprovisionedusers
            // 
            this.lblprovisionedusers.AutoSize = true;
            this.lblprovisionedusers.Location = new System.Drawing.Point(6, 59);
            this.lblprovisionedusers.Name = "lblprovisionedusers";
            this.lblprovisionedusers.Size = new System.Drawing.Size(113, 19);
            this.lblprovisionedusers.TabIndex = 2;
            this.lblprovisionedusers.Text = "Provisioned users:";
            // 
            // lbllicensedusers
            // 
            this.lbllicensedusers.AutoSize = true;
            this.lbllicensedusers.Location = new System.Drawing.Point(6, 40);
            this.lbllicensedusers.Name = "lbllicensedusers";
            this.lbllicensedusers.Size = new System.Drawing.Size(113, 19);
            this.lbllicensedusers.TabIndex = 1;
            this.lbllicensedusers.Text = "Licenses available:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(99, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Licensed Users";
            // 
            // gbExcel
            // 
            this.gbExcel.Controls.Add(this.lblLicensenotification);
            this.gbExcel.Controls.Add(this.metroLabel5);
            this.gbExcel.Controls.Add(this.groupBox2);
            this.gbExcel.Controls.Add(this.txtAddUsers);
            this.gbExcel.Controls.Add(this.lblCSVinstructions);
            this.gbExcel.Controls.Add(this.metroLabel3);
            this.gbExcel.Controls.Add(this.lblCSV);
            this.gbExcel.Controls.Add(this.btnBrowse);
            this.gbExcel.Controls.Add(this.txtBulkAddCSV);
            this.gbExcel.Location = new System.Drawing.Point(324, 189);
            this.gbExcel.Name = "gbExcel";
            this.gbExcel.Size = new System.Drawing.Size(295, 294);
            this.gbExcel.TabIndex = 3;
            this.gbExcel.TabStop = false;
            // 
            // lblLicensenotification
            // 
            this.lblLicensenotification.AutoSize = true;
            this.lblLicensenotification.Location = new System.Drawing.Point(6, 220);
            this.lblLicensenotification.Name = "lblLicensenotification";
            this.lblLicensenotification.Size = new System.Drawing.Size(263, 19);
            this.lblLicensenotification.TabIndex = 27;
            this.lblLicensenotification.Text = "To use this feature please purchase a license";
            this.lblLicensenotification.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(11, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(119, 25);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Bulk User Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(11, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 5);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtAddUsers
            // 
            this.txtAddUsers.Location = new System.Drawing.Point(6, 245);
            this.txtAddUsers.Name = "txtAddUsers";
            this.txtAddUsers.Size = new System.Drawing.Size(149, 23);
            this.txtAddUsers.TabIndex = 3;
            this.txtAddUsers.Text = "Add Users";
            this.txtAddUsers.UseSelectable = true;
            this.txtAddUsers.Click += new System.EventHandler(this.txtAddUsers_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 74);
            this.metroLabel3.MaximumSize = new System.Drawing.Size(300, 59);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(0, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(255, 57);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "For instructions and to download the CSV \r\ntemplate for bulk creating users pleas" +
    "e\r\nclick on the following link";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(6, 162);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(57, 19);
            this.lblCSV.TabIndex = 11;
            this.lblCSV.Text = "CSV File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(179, 184);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBulkAddCSV
            // 
            this.txtBulkAddCSV.Lines = new string[0];
            this.txtBulkAddCSV.Location = new System.Drawing.Point(6, 184);
            this.txtBulkAddCSV.MaxLength = 32767;
            this.txtBulkAddCSV.Name = "txtBulkAddCSV";
            this.txtBulkAddCSV.PasswordChar = '\0';
            this.txtBulkAddCSV.ReadOnly = true;
            this.txtBulkAddCSV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBulkAddCSV.SelectedText = "";
            this.txtBulkAddCSV.Size = new System.Drawing.Size(149, 23);
            this.txtBulkAddCSV.TabIndex = 1;
            this.txtBulkAddCSV.UseSelectable = true;
            // 
            // AdduserTooltip
            // 
            this.AdduserTooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdduserTooltip.StyleManager = null;
            this.AdduserTooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // OFDialog
            // 
            this.OFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDialog_FileOk);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 744);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(101, 744);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 0);
            this.lblStatusText.TabIndex = 11;
            // 
            // pbLoadingGif
            // 
            this.pbLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGif.Image")));
            this.pbLoadingGif.Location = new System.Drawing.Point(578, 744);
            this.pbLoadingGif.Name = "pbLoadingGif";
            this.pbLoadingGif.Size = new System.Drawing.Size(35, 33);
            this.pbLoadingGif.TabIndex = 12;
            this.pbLoadingGif.TabStop = false;
            this.pbLoadingGif.Visible = false;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 800);
            this.Controls.Add(this.pbLoadingGif);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbExcel);
            this.Controls.Add(this.gbLicences);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.gbLine);
            this.Controls.Add(this.gpAuthenticate);
            this.Controls.Add(this.gpListUsers);
            this.Controls.Add(this.gpSingleUserAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUsers";
            this.Resizable = false;
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.gpSingleUserAdd.ResumeLayout(false);
            this.gpSingleUserAdd.PerformLayout();
            this.gpListUsers.ResumeLayout(false);
            this.gpListUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).EndInit();
            this.gpAuthenticate.ResumeLayout(false);
            this.gpAuthenticate.PerformLayout();
            this.gbLicences.ResumeLayout(false);
            this.gbLicences.PerformLayout();
            this.gbExcel.ResumeLayout(false);
            this.gbExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSingleUserAdd;
        private System.Windows.Forms.GroupBox gpListUsers;
        private System.Windows.Forms.GroupBox gpAuthenticate;
        private System.Windows.Forms.GroupBox gbLine;
        private MetroFramework.Controls.MetroTextBox txtFirstname;
        private MetroFramework.Controls.MetroCheckBox chkSendWelcomeEmail;
        private MetroFramework.Controls.MetroLabel lblSurname;
        private MetroFramework.Controls.MetroLabel lblFirstname;
        private MetroFramework.Controls.MetroTextBox txtEmailaddress;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox gbLicences;
        private MetroFramework.Controls.MetroLabel lblprovisionedusers;
        private MetroFramework.Controls.MetroLabel lbllicensedusers;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCheckLicenses;
        private MetroFramework.Controls.MetroLabel lblprovisionedusersnumber;
        private MetroFramework.Controls.MetroLabel lbllicensesavailablenumber;
        private MetroFramework.Controls.MetroTextBox txtAccesstoken;
        private MetroFramework.Controls.MetroLabel lblAccesstoken;
        private System.Windows.Forms.GroupBox gbExcel;
        private MetroFramework.Controls.MetroButton btnAddUser;
        private MetroFramework.Controls.MetroLink lblCSVinstructions;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblCSV;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtBulkAddCSV;
        private MetroFramework.Controls.MetroGrid DVGResults;
        private MetroFramework.Components.MetroToolTip AdduserTooltip;
        private MetroFramework.Controls.MetroButton List;
        private MetroFramework.Controls.MetroTextBox txtLimit;
        private MetroFramework.Controls.MetroLabel lblLimit;
        private System.Windows.Forms.OpenFileDialog OFDialog;
        private MetroFramework.Controls.MetroButton txtAddUsers;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblStatusText;
        private System.Windows.Forms.PictureBox pbLoadingGif;
        private MetroFramework.Controls.MetroLabel lblLicensenotification;
    }
}