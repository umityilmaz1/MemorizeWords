using MW.BLL;
using MW.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW.UI
{
    public partial class LoginForm : Form
    {
        UserService _userService;
        UserRoleService _roleService;
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _roleService = new UserRoleService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User loginUser = _userService.GetUserByLogin(txtUserName.Text, txtPassword.Text);
                if (cbHatirla.Checked)
                {
                    CbHatirla_CheckedChanged(sender, e);
                }
                string roleName = _roleService.GetRoleByMail(txtUserName.Text).RoleName;

                if (roleName == "Admin")
                {
                    AdminMain frmAdmin = new AdminMain(_userService.GetUserByLogin(txtUserName.Text, txtPassword.Text));
                    frmAdmin.Owner = this;
                    frmAdmin.Show();
                    this.Hide();
                }
                else if (roleName == "Restricted" && loginUser.IsActive == false)
                {
                    MessageBox.Show("Üyeliğiniz henüz onaylanmamıştır. Lütfen daha sonra tekrar deneyin.");
                }
                else if (roleName == "Standard" || (roleName == "Restricted" && loginUser.IsActive == true))
                {
                    UserMain frmUser = new UserMain(_userService.GetUserByLogin(txtUserName.Text, txtPassword.Text).ID);
                    frmUser.Owner = this;
                    frmUser.Show();
                    this.Hide();
                }
                   // this.Hide();
                if (!cbHatirla.Checked)
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CbHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHatirla.Checked)
            {
                if (File.Exists("user.txt"))
                {
                    StreamReader reader = new StreamReader("user.txt");
                    string text = reader.ReadLine();
                    if (text == null || text[0] == '|' || text.Last() == '|')
                    {
                        reader.Close();
                        RegisterWrite();
                        return;
                    }
                    string[] loginText = text.Split('|');
                    txtUserName.Text = loginText[0];
                    txtPassword.Text = loginText[1];
                    reader.Close();
                }
                else
                {
                    RegisterWrite();
                }
            }
            else
            {
                File.Delete("user.txt");
            }
        }
        private void RegisterWrite()
        {
            StreamWriter writer = new StreamWriter("user.txt");
            writer.Write(txtUserName.Text + "|" + txtPassword.Text);
            writer.Flush();
            writer.Close();
        }
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Owner = this;
            register.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
