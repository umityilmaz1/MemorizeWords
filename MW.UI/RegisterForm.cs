using MW.BLL;
using MW.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW.UI
{
    public partial class RegisterForm : Form
    {
        UserService _userService;
        UserRoleService _userRoleService;
        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _userRoleService = new UserRoleService();
        }

        private void btnSigin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor.","Parola Hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            User newUser = new User();
            newUser.Name = txtName.Text;
            newUser.Surname = txtSurname.Text;
            newUser.EMail = txtMail.Text;
            newUser.BirthDate = dtpBirthDate.Value;

            newUser.Passwords.Add(new Password()
            {
                PasswordText = txtPassword.Text
            });

            bool result = false;
            try
            {
                result = _userService.Add(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
