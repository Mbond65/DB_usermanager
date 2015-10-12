namespace DBUserManager
{
    partial class DeleteUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUsers));
            this.gpSingleUserAdd = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new MetroFramework.Controls.MetroButton();
            this.chkDeleteDevices = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNotifyAdminMemberID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTransfertoMem = new MetroFramework.Controls.MetroTextBox();
            this.lblTransferData = new MetroFramework.Controls.MetroLabel();
            this.txtMemberID = new MetroFramework.Controls.MetroTextBox();
            this.lblMemberID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbExcel = new System.Windows.Forms.GroupBox();
            this.lblLicensenotification = new MetroFramework.Controls.MetroLabel();
            this.txtAddUsers = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCSVinstructions = new MetroFramework.Controls.MetroLink();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCSV = new MetroFramework.Controls.MetroLabel();
            this.txtBulkDeleteCSV = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.gbLicences = new System.Windows.Forms.GroupBox();
            this.btnCheckLicenses = new MetroFramework.Controls.MetroButton();
            this.lblprovisionedusersnumber = new MetroFramework.Controls.MetroLabel();
            this.lbllicensesavailablenumber = new MetroFramework.Controls.MetroLabel();
            this.lblprovisionedusers = new MetroFramework.Controls.MetroLabel();
            this.lbllicensedusers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gpAuthenticate = new System.Windows.Forms.GroupBox();
            this.txtAccesstoken = new MetroFramework.Controls.MetroTextBox();
            this.lblAccesstoken = new MetroFramework.Controls.MetroLabel();
            this.gpListUsers = new System.Windows.Forms.GroupBox();
            this.List = new MetroFramework.Controls.MetroButton();
            this.txtLimit = new MetroFramework.Controls.MetroTextBox();
            this.lblLimit = new MetroFramework.Controls.MetroLabel();
            this.DVGResults = new MetroFramework.Controls.MetroGrid();
            this.pbLoadingGif = new System.Windows.Forms.PictureBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblStatusText = new MetroFramework.Controls.MetroLabel();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.gpSingleUserAdd.SuspendLayout();
            this.gbExcel.SuspendLayout();
            this.gbLicences.SuspendLayout();
            this.gpAuthenticate.SuspendLayout();
            this.gpListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSingleUserAdd
            // 
            this.gpSingleUserAdd.Controls.Add(this.btnDeleteUser);
            this.gpSingleUserAdd.Controls.Add(this.chkDeleteDevices);
            this.gpSingleUserAdd.Controls.Add(this.metroLabel5);
            this.gpSingleUserAdd.Controls.Add(this.txtNotifyAdminMemberID);
            this.gpSingleUserAdd.Controls.Add(this.metroLabel4);
            this.gpSingleUserAdd.Controls.Add(this.txtTransfertoMem);
            this.gpSingleUserAdd.Controls.Add(this.lblTransferData);
            this.gpSingleUserAdd.Controls.Add(this.txtMemberID);
            this.gpSingleUserAdd.Controls.Add(this.lblMemberID);
            this.gpSingleUserAdd.Controls.Add(this.metroLabel1);
            this.gpSingleUserAdd.Controls.Add(this.groupBox4);
            this.gpSingleUserAdd.Location = new System.Drawing.Point(21, 197);
            this.gpSingleUserAdd.Name = "gpSingleUserAdd";
            this.gpSingleUserAdd.Size = new System.Drawing.Size(295, 310);
            this.gpSingleUserAdd.TabIndex = 2;
            this.gpSingleUserAdd.TabStop = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(62, 270);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(167, 23);
            this.btnDeleteUser.TabIndex = 5;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseSelectable = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // chkDeleteDevices
            // 
            this.chkDeleteDevices.AutoSize = true;
            this.chkDeleteDevices.Checked = true;
            this.chkDeleteDevices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleteDevices.Location = new System.Drawing.Point(136, 249);
            this.chkDeleteDevices.Name = "chkDeleteDevices";
            this.chkDeleteDevices.Size = new System.Drawing.Size(26, 15);
            this.chkDeleteDevices.TabIndex = 4;
            this.chkDeleteDevices.Text = " ";
            this.chkDeleteDevices.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(197, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = " Delete data from linked devices";
            // 
            // txtNotifyAdminMemberID
            // 
            this.txtNotifyAdminMemberID.BackColor = System.Drawing.Color.White;
            this.txtNotifyAdminMemberID.Lines = new string[0];
            this.txtNotifyAdminMemberID.Location = new System.Drawing.Point(62, 191);
            this.txtNotifyAdminMemberID.MaxLength = 32767;
            this.txtNotifyAdminMemberID.Name = "txtNotifyAdminMemberID";
            this.txtNotifyAdminMemberID.PasswordChar = '\0';
            this.txtNotifyAdminMemberID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotifyAdminMemberID.SelectedText = "";
            this.txtNotifyAdminMemberID.Size = new System.Drawing.Size(167, 23);
            this.txtNotifyAdminMemberID.TabIndex = 3;
            this.txtNotifyAdminMemberID.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(276, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Notify Admin member ID of errors (Optional)";
            // 
            // txtTransfertoMem
            // 
            this.txtTransfertoMem.BackColor = System.Drawing.Color.White;
            this.txtTransfertoMem.Lines = new string[0];
            this.txtTransfertoMem.Location = new System.Drawing.Point(62, 143);
            this.txtTransfertoMem.MaxLength = 32767;
            this.txtTransfertoMem.Name = "txtTransfertoMem";
            this.txtTransfertoMem.PasswordChar = '\0';
            this.txtTransfertoMem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTransfertoMem.SelectedText = "";
            this.txtTransfertoMem.Size = new System.Drawing.Size(167, 23);
            this.txtTransfertoMem.TabIndex = 2;
            this.txtTransfertoMem.UseSelectable = true;
            // 
            // lblTransferData
            // 
            this.lblTransferData.AutoSize = true;
            this.lblTransferData.Location = new System.Drawing.Point(24, 121);
            this.lblTransferData.Name = "lblTransferData";
            this.lblTransferData.Size = new System.Drawing.Size(234, 19);
            this.lblTransferData.TabIndex = 8;
            this.lblTransferData.Text = "Transfer data to member ID (Optional)";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.Color.White;
            this.txtMemberID.Lines = new string[0];
            this.txtMemberID.Location = new System.Drawing.Point(62, 86);
            this.txtMemberID.MaxLength = 32767;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PasswordChar = '\0';
            this.txtMemberID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberID.SelectedText = "";
            this.txtMemberID.Size = new System.Drawing.Size(167, 23);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.UseSelectable = true;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(98, 63);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(76, 19);
            this.lblMemberID.TabIndex = 6;
            this.lblMemberID.Text = "Member ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Single User Delete";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(24, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 5);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // gbExcel
            // 
            this.gbExcel.Controls.Add(this.lblLicensenotification);
            this.gbExcel.Controls.Add(this.txtAddUsers);
            this.gbExcel.Controls.Add(this.metroLabel2);
            this.gbExcel.Controls.Add(this.lblCSVinstructions);
            this.gbExcel.Controls.Add(this.groupBox3);
            this.gbExcel.Controls.Add(this.metroLabel6);
            this.gbExcel.Controls.Add(this.lblCSV);
            this.gbExcel.Controls.Add(this.txtBulkDeleteCSV);
            this.gbExcel.Controls.Add(this.btnBrowse);
            this.gbExcel.Location = new System.Drawing.Point(321, 197);
            this.gbExcel.Name = "gbExcel";
            this.gbExcel.Size = new System.Drawing.Size(295, 310);
            this.gbExcel.TabIndex = 3;
            this.gbExcel.TabStop = false;
            // 
            // lblLicensenotification
            // 
            this.lblLicensenotification.AutoSize = true;
            this.lblLicensenotification.Location = new System.Drawing.Point(10, 217);
            this.lblLicensenotification.Name = "lblLicensenotification";
            this.lblLicensenotification.Size = new System.Drawing.Size(263, 19);
            this.lblLicensenotification.TabIndex = 26;
            this.lblLicensenotification.Text = "To use this feature please purchase a license";
            this.lblLicensenotification.Visible = false;
            // 
            // txtAddUsers
            // 
            this.txtAddUsers.Location = new System.Drawing.Point(10, 270);
            this.txtAddUsers.Name = "txtAddUsers";
            this.txtAddUsers.Size = new System.Drawing.Size(149, 23);
            this.txtAddUsers.TabIndex = 3;
            this.txtAddUsers.Text = "Delete Users";
            this.txtAddUsers.UseSelectable = true;
            this.txtAddUsers.Click += new System.EventHandler(this.txtDeleteUsers_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Bulk User Delete";
            //  
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(23, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 5);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 63);
            this.metroLabel6.MaximumSize = new System.Drawing.Size(300, 59);
            this.metroLabel6.MinimumSize = new System.Drawing.Size(0, 50);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(255, 57);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "For instructions and to download the CSV \r\ntemplate for bulk deleting user please" +
    "\r\nclick on the following link";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(6, 151);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(57, 19);
            this.lblCSV.TabIndex = 23;
            this.lblCSV.Text = "CSV File";
            // 
            // txtBulkDeleteCSV
            // 
            this.txtBulkDeleteCSV.Lines = new string[0];
            this.txtBulkDeleteCSV.Location = new System.Drawing.Point(6, 173);
            this.txtBulkDeleteCSV.MaxLength = 32767;
            this.txtBulkDeleteCSV.Name = "txtBulkDeleteCSV";
            this.txtBulkDeleteCSV.PasswordChar = '\0';
            this.txtBulkDeleteCSV.ReadOnly = true;
            this.txtBulkDeleteCSV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBulkDeleteCSV.SelectedText = "";
            this.txtBulkDeleteCSV.Size = new System.Drawing.Size(149, 23);
            this.txtBulkDeleteCSV.TabIndex = 1;
            this.txtBulkDeleteCSV.UseSelectable = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(179, 173);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gbLine
            // 
            this.gbLine.Location = new System.Drawing.Point(21, 67);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(595, 5);
            this.gbLine.TabIndex = 12;
            this.gbLine.TabStop = false;
            // 
            // gbLicences
            // 
            this.gbLicences.Controls.Add(this.btnCheckLicenses);
            this.gbLicences.Controls.Add(this.lblprovisionedusersnumber);
            this.gbLicences.Controls.Add(this.lbllicensesavailablenumber);
            this.gbLicences.Controls.Add(this.lblprovisionedusers);
            this.gbLicences.Controls.Add(this.lbllicensedusers);
            this.gbLicences.Controls.Add(this.metroLabel3);
            this.gbLicences.Location = new System.Drawing.Point(321, 78);
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(99, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Licensed Users";
            // 
            // gpAuthenticate
            // 
            this.gpAuthenticate.Controls.Add(this.txtAccesstoken);
            this.gpAuthenticate.Controls.Add(this.lblAccesstoken);
            this.gpAuthenticate.Location = new System.Drawing.Point(21, 78);
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
            // gpListUsers
            // 
            this.gpListUsers.Controls.Add(this.List);
            this.gpListUsers.Controls.Add(this.txtLimit);
            this.gpListUsers.Controls.Add(this.lblLimit);
            this.gpListUsers.Controls.Add(this.DVGResults);
            this.gpListUsers.Location = new System.Drawing.Point(21, 513);
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
            // pbLoadingGif
            // 
            this.pbLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGif.Image")));
            this.pbLoadingGif.Location = new System.Drawing.Point(567, 753);
            this.pbLoadingGif.Name = "pbLoadingGif";
            this.pbLoadingGif.Size = new System.Drawing.Size(35, 33);
            this.pbLoadingGif.TabIndex = 17;
            this.pbLoadingGif.TabStop = false;
            this.pbLoadingGif.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 753);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(18, 787);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(78, 13);
            this.lblCopyright.TabIndex = 18;
            this.lblCopyright.Text = "Copyright 2015";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(83, 753);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 0);
            this.lblStatusText.TabIndex = 19;
            // 
            // OFDialog
            // 
            this.OFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDialog_FileOk);
            // 
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 800);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pbLoadingGif);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpListUsers);
            this.Controls.Add(this.gpAuthenticate);
            this.Controls.Add(this.gbLicences);
            this.Controls.Add(this.gbLine);
            this.Controls.Add(this.gbExcel);
            this.Controls.Add(this.gpSingleUserAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteUsers";
            this.Text = "DeleteUsers";
            this.Load += new System.EventHandler(this.DeleteUsers_Load);
            this.gpSingleUserAdd.ResumeLayout(false);
            this.gpSingleUserAdd.PerformLayout();
            this.gbExcel.ResumeLayout(false);
            this.gbExcel.PerformLayout();
            this.gbLicences.ResumeLayout(false);
            this.gbLicences.PerformLayout();
            this.gpAuthenticate.ResumeLayout(false);
            this.gpAuthenticate.PerformLayout();
            this.gpListUsers.ResumeLayout(false);
            this.gpListUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSingleUserAdd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbLine;
        private System.Windows.Forms.GroupBox gbLicences;
        private MetroFramework.Controls.MetroButton btnCheckLicenses;
        private MetroFramework.Controls.MetroLabel lblprovisionedusersnumber;
        private MetroFramework.Controls.MetroLabel lbllicensesavailablenumber;
        private MetroFramework.Controls.MetroLabel lblprovisionedusers;
        private MetroFramework.Controls.MetroLabel lbllicensedusers;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox gpAuthenticate;
        private MetroFramework.Controls.MetroTextBox txtAccesstoken;
        private MetroFramework.Controls.MetroLabel lblAccesstoken;
        private System.Windows.Forms.GroupBox gpListUsers;
        private MetroFramework.Controls.MetroButton List;
        private MetroFramework.Controls.MetroTextBox txtLimit;
        private MetroFramework.Controls.MetroLabel lblLimit;
        private MetroFramework.Controls.MetroGrid DVGResults;
        private System.Windows.Forms.PictureBox pbLoadingGif;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.Label lblCopyright;
        private MetroFramework.Controls.MetroLabel lblStatusText;
        private MetroFramework.Controls.MetroLabel lblMemberID;
        private MetroFramework.Controls.MetroTextBox txtMemberID;
        private MetroFramework.Controls.MetroTextBox txtNotifyAdminMemberID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTransfertoMem;
        private MetroFramework.Controls.MetroLabel lblTransferData;
        private MetroFramework.Controls.MetroCheckBox chkDeleteDevices;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnDeleteUser;
        private MetroFramework.Controls.MetroButton txtAddUsers;
        private MetroFramework.Controls.MetroLink lblCSVinstructions;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblCSV;
        private MetroFramework.Controls.MetroTextBox txtBulkDeleteCSV;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog OFDialog;
        private System.Windows.Forms.GroupBox gbExcel;
        private MetroFramework.Controls.MetroLabel lblLicensenotification;
    }
}