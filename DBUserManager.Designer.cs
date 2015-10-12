using System.Windows.Forms;
namespace DBUserManager
{
    partial class DBUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBUserManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maintooltip = new MetroFramework.Components.MetroToolTip();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 5);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Maintooltip
            // 
            this.Maintooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Maintooltip.StyleManager = null;
            this.Maintooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUsers.BackgroundImage")));
            this.btnAddUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUsers.FlatAppearance.BorderSize = 0;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Location = new System.Drawing.Point(23, 82);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(159, 144);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.TabStop = false;
            this.Maintooltip.SetToolTip(this.btnAddUsers, "Add users");
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUsers.BackgroundImage")));
            this.btnDeleteUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteUsers.FlatAppearance.BorderSize = 0;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Location = new System.Drawing.Point(219, 82);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(154, 144);
            this.btnDeleteUsers.TabIndex = 2;
            this.btnDeleteUsers.TabStop = false;
            this.Maintooltip.SetToolTip(this.btnDeleteUsers, "Delete users");
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(26, 239);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(78, 13);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright 2015";
            // 
            // DBUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 260);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DBUserManager";
            this.Resizable = false;
            this.Text = "DB User Manager";
            this.Load += new System.EventHandler(this.DBUserManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroToolTip Maintooltip;
        private Button btnAddUsers;
        private Button btnDeleteUsers;
        private Label lblCopyright;
    }
}

