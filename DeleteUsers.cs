using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DBUserManager
{
    public partial class DeleteUsers : MetroForm
    {
        public DeleteUsers()
        {
            InitializeComponent();

        }
        public async Task UpdateLicenses()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.PostAsJsonAsync("/1/team/get_info", new Licenses());
                var content = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    throw new Exception("A 409 error message was returned from Dropbox, this can occur for the following reasons: \n \n 409 No available licenses. \n 409 User is already on the team or has already been invited. \n 409 User is already on another team.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    LicensesObj licenses = new JavaScriptSerializer().Deserialize<LicensesObj>(content);
                    lbllicensesavailablenumber.Text = Convert.ToString(licenses.num_licensed_users);
                    lblprovisionedusersnumber.Text = Convert.ToString(licenses.num_provisioned_users);
                }
                else
                {
                    throw new Exception(content.Replace("{", "").Replace("}", "").Replace("\"", " "));
                }
            }
        }
        public async void btnCheckLicenses_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                SetStatusText("Getting License count");
                ShowLoadingGif(true);
                await UpdateLicenses();
                ShowLoadingGif(false);
                SetStatusText("Completed");
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteUsers_Load(object sender, EventArgs e)
        {

        }
        public class DropboxMemberCallLimit
        {
            public int limit { get; set; }
        }
        public class LicensesObj
        {
            public string name { get; set; }
            public string team_id { get; set; }
            public int num_licensed_users { get; set; }
            public int num_provisioned_users { get; set; }
        }
        public class Licenses
        {

        }
        public class Profile
        {
            public string given_name { get; set; }
            public string surname { get; set; }
            public string status { get; set; }
            public string member_id { get; set; }
            public string email { get; set; }
            public string external_id { get; set; }
            public List<object> groups { get; set; }
        }
        public class Permissions
        {
            public bool is_admin { get; set; }
        }
        public class Member
        {
            public Profile profile { get; set; }
            public Permissions permissions { get; set; }
        }
        public class RootObject
        {
            public List<Member> members { get; set; }
        }
        public DropboxMemberCallLimit GetLimit()
        {
            var limit = new DropboxMemberCallLimit();

            if (txtLimit.Text.Length == 0)
            {
                limit.limit = 1000;
            }
            else
            {
                limit.limit = Convert.ToInt32(txtLimit.Text);
            }

            return limit;
        }
        public void ShowLoadingGif(bool visible)
        {
            if (visible)
            {
                pbLoadingGif.Visible = visible;
            }
            else
            {
                pbLoadingGif.Visible = visible;
            }
        }
        public void SetColumnsDataGridView()
        {
            DVGResults.Columns.Clear();
            DVGResults.Columns.Add("First Name", "First Name");
            DVGResults.Columns.Add("Surname", "Surname");
            DVGResults.Columns.Add("Email Address", "Email Address");
            DVGResults.Columns.Add("Status", "Status");
            DVGResults.Columns.Add("Admin", "Admin");
            DVGResults.Columns.Add("Groups", "Groups");
            DVGResults.Columns.Add("Member ID", "Member ID");
        }
        public void SetStatusText(string text)
        {
            lblStatusText.Text = text;
        }
        public void PopulateDataGridView(dynamic result)
        {
            SetColumnsDataGridView();

            int intRowCount = 0;
            DVGResults.Rows.Clear();

            foreach (var member in result.members)
            {
                Profile DropboxMember = (Profile)member.profile;
                Permissions Permission = (Permissions)member.permissions;
                DVGResults.Rows.Add();
                DVGResults.Rows[intRowCount].Cells[0].Value = DropboxMember.given_name;
                DVGResults.Rows[intRowCount].Cells[1].Value = DropboxMember.surname;
                DVGResults.Rows[intRowCount].Cells[2].Value = DropboxMember.email;
                DVGResults.Rows[intRowCount].Cells[3].Value = DropboxMember.status;
                DVGResults.Rows[intRowCount].Cells[4].Value = Permission.is_admin;

                if (DropboxMember.groups.Count != 0)
                {
                    foreach (object group in DropboxMember.groups)
                    {
                        DVGResults.Rows[intRowCount].Cells[5].Value += " " + (string)group;
                    }
                }
                else
                {
                    DVGResults.Rows[intRowCount].Cells[5].Value = "none";
                }

                DVGResults.Rows[intRowCount].Cells[6].Value = DropboxMember.member_id;

                intRowCount = intRowCount + 1;
            }


        }
        public static void CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                }
            }
            catch
            {
                throw new Exception("The computer you're using has no internet connection.");
            }
        }
        public void CheckAccessToken()
        {
            if (txtAccesstoken.Text.Length == 0)
            {
                throw new Exception("Error: Access token is empty.");
            }
        }
        public async Task GetData()
        {
            string content;
            RootObject result = null;
            Random intRandom = new Random();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var limit = GetLimit();
                var response = await client.PostAsJsonAsync("1/team/members/list", limit);
                content = await response.Content.ReadAsStringAsync();

                result = new JavaScriptSerializer().Deserialize<RootObject>(content);
            }

            if (result.members == null)
            {
                throw new Exception(content.Replace("{", "").Replace("}", "").Replace("\"", " "));
            }

            PopulateDataGridView(result);

        }
        public async void List_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                SetStatusText("Getting members");
                ShowLoadingGif(true);
                await GetData();
                ShowLoadingGif(false);
                SetStatusText("Completed");
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                CheckMemberID();
                SetStatusText("Delete user " + txtMemberID.Text);
                ShowLoadingGif(true);
                await DeleteUser();
                ShowLoadingGif(false);
                SetStatusText("Completed");
                ShowSuccessMessageDelete();
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CheckMemberID()
        {
            if (txtMemberID.Text.Length == 0)
            {
                throw new Exception("Error: Member ID is empty");
            }
        }
        public void ShowSuccessMessageDelete()
        {
            MetroFramework.MetroMessageBox.Show(this, "Member ID specified has been deleted", "Account deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public async Task DeleteUser()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var content = new MemberID();
                content.member_id = txtMemberID.Text;
                content.transfer_dest_member_id = txtTransfertoMem.Text;
                content.transfer_admin_member_id = txtNotifyAdminMemberID.Text;

                var response = await client.PostAsJsonAsync("1/team/members/remove", content);
                var returncontent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(returncontent.Replace("{", "").Replace("}", "").Replace("\"", " "));
                }

            }
        }
        public class MemberID
        {
            public string member_id { get; set; }
            public string transfer_dest_member_id { get; set; }
            public string transfer_admin_member_id { get; set; }
            public bool delete_data { get; set; }
        }
        public void btnBrowse_Click(object sender, EventArgs e)
        {
            OFDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OFDialog.Filter = "CSV files (*.csv)|*.csv";
            OFDialog.ShowDialog();
        }
        public async void txtDeleteUsers_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                CheckCSV();
                SetStatusText("Deleting user accounts");
                ShowLoadingGif(true);
                List<MemberID> DeleteUserslist = ReadCSV();
                await DeleteUsersBulk(DeleteUserslist);
                ShowLoadingGif(false);
                SetStatusText("Completed");
                ShowSuccessMessageDeleteBulk(DeleteUserslist);
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowSuccessMessageDeleteBulk(List<MemberID> deletedusers)
        {
            StringBuilder sb = new StringBuilder();
            int intcount = 0;
            foreach (var user in deletedusers)
            {
                if (intcount < deletedusers.Count -1)
                {
                    sb.Append(user.member_id + ",");
                }
                else
                {
                    sb.Append(user.member_id);
                }

                intcount += 1;
            }

            MetroFramework.MetroMessageBox.Show(this, "Success, the following Dropbox accounts have been deleted " + sb.ToString(), "Accounts deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public async Task DeleteUsersBulk(List<MemberID> deleteusers)
        {
            foreach (var user in deleteusers)
            {
                SetStatusText("Deleting account " + user.member_id);
                try
                {
                    await DeleteUserBulk(user);
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }
        public async Task DeleteUserBulk(MemberID user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var content = new MemberID();
                content.member_id = user.member_id;
                content.transfer_dest_member_id = user.transfer_dest_member_id;
                content.transfer_admin_member_id = user.transfer_admin_member_id;
                content.delete_data = user.delete_data;

                var response = await client.PostAsJsonAsync("1/team/members/remove", content);
                var returncontent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(returncontent.Replace("{", "").Replace("}", "").Replace("\"", " "));
                }

            }
        }
        public void CheckCSV()
        {
            if (txtBulkDeleteCSV.Text.Length == 0)
            {
                throw new Exception("Error: no CSV file specified.");
            }
        }
        public void OFDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtBulkDeleteCSV.Text = OFDialog.FileName;
        }
        public List<MemberID> ReadCSV()
        {
            int intline = 0;
            System.Collections.Generic.List<MemberID> results = new List<MemberID>();
            var reader = new StreamReader(OFDialog.FileName);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (!line.Contains("MemberID"))
                {
                    var values = line.Split(',');

                    if (values[0].Length == 0)
                    {
                            throw new Exception("Line number " + intline + " is incorrect and cannot be used, a member ID has not been specified. The program has stopped and no accounts have been created.");
                    }

                    MemberID mem = new MemberID();
                    mem.member_id = values[0];
                    mem.transfer_dest_member_id = values[1];
                    mem.transfer_admin_member_id = values[2];
                    mem.delete_data = Convert.ToBoolean(values[3]);
                    results.Add(mem);
                }

                intline += 1;

            }


            return results;
        }
        public void ValidateCSVData(dynamic values, int line)
        {
            string strMemberID = Convert.ToString(values[0]);
        }
        public bool CheckIfLicenseExists()
        {
            return registryValueExists("HKCU", @"Software\MbondSoftware\DBUserManager", "e1112147-390d-4702-b17e-ed60a841f00e");
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

    }
}
