using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUserManager
{
    public partial class DBUserManager : MetroForm
    {
        public DBUserManager()
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            InitializeComponent();

        }
        public static bool registryValueExists(string hive_HKLM_or_HKCU, string registryRoot, string valueName)
        {
            RegistryKey root;
            switch (hive_HKLM_or_HKCU.ToUpper())
            {
                case "HKLM":
                    root = Registry.LocalMachine.OpenSubKey(registryRoot, false);
                    break;
                case "HKCU":
                    root = Registry.CurrentUser.OpenSubKey(registryRoot, false);
                    break;
                default:
                    throw new System.InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\"");
            }

            if (root.GetValue(valueName) == null)
                return false;
            else
                return true;
        }
        private void OnClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DBUserManager_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            MetroForm AddUsersForm = new AddUsers();
            AddUsersForm.Show();
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            MetroForm DeleteUsersForm = new DeleteUsers();
            DeleteUsersForm.Show();
        }

    }
}
