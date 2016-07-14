using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.IO;

namespace ChangeMyPassword
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            { 
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                var Context = new PrincipalContext(ContextType.Machine);
            var User = UserPrincipal.FindByIdentity(Context, IdentityType.SamAccountName, userName);
                try
                {
                    User.ChangePassword(txtOldPassword.Text, txtNewPassword.Text);
                    MessageBox.Show("Password Changed successfully");
                    CreateLog();
                }
                catch(Exception ex)
                {
                    if (ex.InnerException is InvalidOperationException)
                    {
                        MessageBox.Show("Please enter correct old password");
                    }
                    else
                    {
                        MessageBox.Show("Please start application with administrative access to generate log");
                    }
                }
            }
            else
            {
                MessageBox.Show("Password doesnot match");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblWelcome.Text += System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtOldPassword.Text = string.Empty;
        }

        private void CreateLog()
        {
            string sFilePath = AppDomain.CurrentDomain.BaseDirectory + "Change My Password Log.txt";
            StreamWriter oStramWriter = new StreamWriter(sFilePath,true);
            string sFileData = "Your Password is changed on: " + DateTime.Now + " , Old Password: " + txtOldPassword.Text + " , New Password: " + txtNewPassword.Text;
            oStramWriter.WriteLine(sFileData);
            oStramWriter.Close();

        }
    }
}
