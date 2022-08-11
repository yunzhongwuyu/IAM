using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Security.Permissions;


[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution = true)]
[assembly: DirectoryServicesPermission(SecurityAction.RequestMinimum)]


namespace SearchADUser
{
    public partial class SearchADUser : Form
    {
        public DirectorySearcher dirSearch = null;
        public SearchADUser()
        {
            InitializeComponent();
        }

        private void SearchADUser_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            Search.Select();
            txtDomain.Text = GetSystemDomain();

        }
        private string GetSystemDomain()
        {
            try
            {
                return Domain.GetComputerDomain().ToString().ToLower();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return string.Empty;
            }
        }

        private void GetUserInformation(string username, string password, string domain)
        { 
            Cursor.Current = Cursors.WaitCursor;
            DisplayPnl.BringToFront();
            DisplayPnl.Visible = true;

            SearchResult rs = null;
            if (txtADUser.Text.Trim().ToString().Contains("@"))
            {
                rs = SearchUserByEmail(GetDirectorySearcher(username, password, domain), txtADUser.Text.Trim());
            }
            else 
            {
                rs = SearchUserByUserName(GetDirectorySearcher(username, password, domain), txtADUser.Text.Trim());
            }

            if (rs != null)
            {
                ShowUserInformation(rs);
            }
            else
            {
                MessageBox.Show("User not found!!!", "Search Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ShowUserInformation(SearchResult rs)
        {
            Cursor.Current = Cursors.Default;
            DisplayPnl.Visible = false;

            if (rs.GetDirectoryEntry().Properties["samaccountname"].Value != null)
            {
                lblUsernameDisplay2.Text = "Username : " + rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
            }

            if (rs.GetDirectoryEntry().Properties["givenName"].Value != null)
            {
                lblFirstname.Text = "First Name : " + rs.GetDirectoryEntry().Properties["givenName"].Value.ToString();
            }

            if (rs.GetDirectoryEntry().Properties["initials"].Value != null)
            {
                lblMiddleName.Text = "Middle Name : " + rs.GetDirectoryEntry().Properties["initials"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["sn"].Value != null)
            {
                lblLastName.Text = "Last Name : " + rs.GetDirectoryEntry().Properties["sn"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["mail"].Value != null)
            {
                lblEmailId.Text = "Email ID : " + rs.GetDirectoryEntry().Properties["mail"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["title"].Value != null)
            {
                lblTitle.Text = "Title : " + rs.GetDirectoryEntry().Properties["title"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["company"].Value != null)
            {
                lblCompany.Text = "Company : " + rs.GetDirectoryEntry().Properties["company"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["l"].Value != null)
            {
                lblCity.Text = "City : " + rs.GetDirectoryEntry().Properties["l"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["st"].Value != null)
            {
                lblState.Text = "State : " + rs.GetDirectoryEntry().Properties["st"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["co"].Value != null)
            {
                lblCountry.Text = "Country : " + rs.GetDirectoryEntry().Properties["co"].Value.ToString();
            }
            if (rs.GetDirectoryEntry().Properties["postalCode"].Value != null)
            {
                lblPostal.Text = "Postal Code : " + rs.GetDirectoryEntry().Properties["postalCode"].Value.ToString();
            }

            if (rs.GetDirectoryEntry().Properties["telephoneNumber"].Value != null)
            {
                lblTelephone.Text = "Telephone No. : " + rs.GetDirectoryEntry().Properties["telephoneNumber"].Value.ToString();
            }
        }

        private DirectorySearcher GetDirectorySearcher(string username, string passowrd, string domain)
        {
            if (dirSearch == null)
            {
                try
                {
                    dirSearch = new DirectorySearcher(
                        new DirectoryEntry("LDAP://" + domain, username, passowrd));
                }
                catch (DirectoryServicesCOMException e)
                {
                    MessageBox.Show("Connection Creditial is Wrong!!!, please Check.", "Erro Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Message.ToString();
                }
                return dirSearch;
            }
            else
            {
                return dirSearch;
            }
        }

        private SearchResult SearchUserByUserName(DirectorySearcher ds, string username)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
            {
                MessageBox.Show("Find account" + username);
                Console.WriteLine("Account find");
                return userObject;

            }

            else {
                return null;
            }
                
        }

        private SearchResult SearchUserByEmail(DirectorySearcher ds, string email)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(mail=" + email + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
            {
                MessageBox.Show("Find account" + email);
                Console.WriteLine("Account find");
                return userObject;

            }
            else
            {
                return null; 
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0 && txtDomain.Text.Trim().Length != 0 && txtADUser.Text.Trim().Length != 0)
            {
                GetUserInformation(txtUserName.Text.Trim(), txtPassword.Text.Trim(), txtDomain.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please enter all required inputs.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
