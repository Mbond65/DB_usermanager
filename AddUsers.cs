using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Collections.Generic;
using Microsoft.Win32;


namespace DBUserManager
{
    public partial class AddUsers : MetroForm
    {
        public AddUsers()
        {
            InitializeComponent();
        }
        public void AddUsers_Load(object sender, EventArgs e)
        {

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
        public class Licenses
        {

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
        public class LicensesObj
        {
            public string name { get; set; }
            public string team_id { get; set; }
            public int num_licensed_users { get; set; }
            public int num_provisioned_users { get; set; }
        }
        public void CheckAccessToken()
        {
            if (txtAccesstoken.Text.Length == 0)
            {
                throw new Exception("Error: Access token is empty.");
            }
        }
        public async void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                CheckAddUser();
                SetStatusText("Creating account " + txtEmailaddress.Text);
                ShowLoadingGif(true);
                await AddUser();
                ShowLoadingGif(false);
                SetStatusText("Completed");
                ShowSuccessMessage();                
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public void SetStatusText(string text)
        {
            lblStatusText.Text = text;
        }
        public void ShowSuccessMessage()
        {
            if (chkSendWelcomeEmail.Checked)
            { 
                MetroFramework.MetroMessageBox.Show(this, "Success, an account for " + txtFirstname.Text + " " + txtSurname.Text + " has been created and a welcome email has been sent to " + txtEmailaddress.Text, "Account created" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MetroFramework.MetroMessageBox.Show(this, "Success, an account for " + txtFirstname.Text + " " + txtSurname.Text + " has been created", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task AddUser()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var values = new member();
                values.member_email = txtEmailaddress.Text;
                values.member_given_name = txtFirstname.Text;
                values.member_surname = txtSurname.Text;
                values.send_welcome_email = chkSendWelcomeEmail.Checked;

                var response = await client.PostAsJsonAsync("/1/team/members/add", values);
                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(content.ToString().Replace(@"\", "").Replace("{", "").Replace("}", "").Replace("\"", " "));
                }

            }
        }
        public void CheckAddUser()
        {
            StringBuilder strEmptyTextboxes = new StringBuilder();
            Int32 intErrorCount = 0;

            foreach (Control control in gpSingleUserAdd.Controls)
            {
                if (control.GetType() == typeof(MetroTextBox))
                {
                    MetroTextBox textbox = (MetroTextBox)control;
                    if (textbox.Text.Length == 0)
                    {

                        switch (textbox.Name)
                        {
                            case "txtFirstname":
                                if (intErrorCount >= 1)
                                {
                                    strEmptyTextboxes.Append(",First name");
                                }
                                else
                                {
                                    strEmptyTextboxes.Append("First name");
                                }
                                intErrorCount += 1;
                                break;

                            case "txtSurname":
                                if (intErrorCount >= 1)
                                {
                                    strEmptyTextboxes.Append(",Surname");
                                }
                                else
                                {
                                    strEmptyTextboxes.Append("Surname");
                                }
                                intErrorCount += 1;
                                break;

                            case "txtEmailaddress":
                                if (intErrorCount >= 1)
                                {
                                    strEmptyTextboxes.Append(",Email address ");
                                }
                                else
                                {
                                    strEmptyTextboxes.Append("Email address");
                                }

                                intErrorCount += 1;
                                break;
                        }

                    }
                }
            }

            if (intErrorCount == 1)
            {
                throw new Exception("The following textbox is empty, please enter a value into it before continuing: " + strEmptyTextboxes.ToString());
            }
            else if (intErrorCount > 1)
            {
                throw new Exception("The following textboxes are empty, please fill them in before continuing: " + strEmptyTextboxes.ToString());
            }
           
        }
        public class member
        {
            public string member_email { get; set; }
            public string member_given_name { get; set; }
            public string member_surname { get; set; }
            public bool send_welcome_email { get; set; }
        }
        public class AddMember : member
        {

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
        public class DropboxMemberCallLimit
        {
            public int limit { get; set; }
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
        public void CheckCSV()
        {
            if (txtBulkAddCSV.Text.Length == 0)
            {
                throw new Exception("Error: no CSV file specified.");
            }
        }
        public void btnBrowse_Click(object sender, EventArgs e)
        {
            OFDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OFDialog.Filter = "CSV files (*.csv)|*.csv";
            OFDialog.ShowDialog();
        }
        public void OFDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtBulkAddCSV.Text = OFDialog.FileName;
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
        public async Task<LicensesObj> GetLicenses()
        {
            LicensesObj licenses = null;
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
                    licenses = new JavaScriptSerializer().Deserialize<LicensesObj>(content);
                    lbllicensesavailablenumber.Text = Convert.ToString(licenses.num_licensed_users);
                    lblprovisionedusersnumber.Text = Convert.ToString(licenses.num_provisioned_users);
                }
                else
                {
                    throw new Exception(content.Replace("{", "").Replace("}", "").Replace("\"", " "));
                }
            }

            return licenses;
        }
        public async void txtAddUsers_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForInternetConnection();
                CheckAccessToken();
                CheckCSV();
                SetStatusText("Creating user accounts");
                ShowLoadingGif(true);
                int CSVCount = CheckCSVLines();
                await CheckLicensesNotExceed(CSVCount);
                List<member> NewUsers = ReadCSV();
                await CreateUsers(NewUsers);
                ShowLoadingGif(false);
                SetStatusText("Completed");
                ShowSuccessMessageBulk(NewUsers);
            }
            catch (Exception exp)
            {
                ShowLoadingGif(false);
                SetStatusText("Failed");
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task CheckLicensesNotExceed(int CSVCount)
        {
            LicensesObj returnedlicenses = await GetLicenses();

            if (((returnedlicenses.num_licensed_users - returnedlicenses.num_provisioned_users) - CSVCount) < 0)
            {
                throw new Exception("Error: no enough licenses to fulfil request, there's " + CSVCount + " records specified in the CSV file however only " + (returnedlicenses.num_licensed_users - returnedlicenses.num_provisioned_users) + " licenses available on your teams Dropbox account");
            }
        }
        public int CheckCSVLines()
        {
            int intLinecount = 0;
            var reader = new StreamReader(OFDialog.FileName);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (line.Contains("FirstName"))
                {
                }
                else
                {
                    intLinecount += 1;
                }
            }

            return intLinecount;
        }
        public async Task CreateUsers(List<member> members)
        {
            foreach (var member in members)
            {
                SetStatusText("Creating account " + member.member_email);
                try
                {
                    await CreateDBUserBulk(member);
                }
                catch (Exception exp)
                {
                    throw new Exception(exp.Message);
                }
            }
        }
        public List<member> ReadCSV()
        {
            int intline = 0;
            System.Collections.Generic.List<member> results = new List<member>();
            var reader = new StreamReader(OFDialog.FileName);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (!line.Contains("FirstName"))
                {
                    var values = line.Split(',');

                    foreach (var value in values)
                    {
                        if (value.Length == 0)
                        {
                            throw new Exception("Line number " + intline + " is incorrect and cannot be used. The program has stopped and no accounts have been created.");
                        }
                    }


                    ValidateCSVData(values, intline); 
                    AddMember mem = new AddMember();
                    mem.member_given_name = values[0];
                    mem.member_surname = values[1];
                    mem.member_email = values[2];
                    mem.send_welcome_email = Convert.ToBoolean(values[3]);
                    results.Add(mem);
                }

                intline += 1;
               
            }

            return results;
        }
        public async Task CreateDBUserBulk(member newuser)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccesstoken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var attribs = new member();
                attribs.member_email = newuser.member_email;
                attribs.member_given_name = newuser.member_given_name;
                attribs.member_surname = newuser.member_surname;
                attribs.send_welcome_email = newuser.send_welcome_email;

                var response = await client.PostAsJsonAsync("/1/team/members/add", attribs);
                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(content.ToString().Replace(@"\", "").Replace("{", "").Replace("}", "").Replace("\"", " "));
                }

            }
        }
        public void ValidateCSVData(dynamic values, int line)
        {
            string emailaddress = Convert.ToString(values[2]);
            string sendemailconfirmation = Convert.ToString(values[3]);

            try
            {
                MailAddress email = new MailAddress(emailaddress);
            }
            catch (FormatException)
            {
                throw new Exception("Line number " + line + " contain a value which isn't correct and the program has stopped and no accounts have been created. The particular value entered into the Email Address column was " + emailaddress + " which isn't a valid email address.");
            }

            if (sendemailconfirmation.ToLower() != "true" && sendemailconfirmation.ToLower() != "false")
            {
                throw new Exception("Line number " + line + " contains a value which isn't correct and the program has stopped and no accounts have been created. The particular value entered in the SendEmail column was " + sendemailconfirmation + " which should be either true or false.");
            }
        }
        public void ShowSuccessMessageBulk(List<member> NewUsers)
        {
            StringBuilder sb = new StringBuilder();

            int intcount = 0;
            foreach (var member in NewUsers)
            {
                if (intcount != NewUsers.Count -1)
                {
                    sb.Append(member.member_email + ",");
                }
                else
                {
                    sb.Append(member.member_email);
                }
                intcount += 1;
            }

            MetroFramework.MetroMessageBox.Show(this, "Success, the following Dropbox accounts have been created " + sb.ToString(), "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

