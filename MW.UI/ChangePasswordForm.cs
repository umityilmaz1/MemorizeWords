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
    public partial class ChangePasswordForm : Form
    {
        User _user;
        PasswordService _passwordService;
        
         
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
            _passwordService = new PasswordService();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Password validPassword = _passwordService.IsPasswordTrue(txtPassword.Text);
            if (validPassword == null)
            {
                MessageBox.Show("Şifrenizi yanlış girdiniz.");
                return;
            }

            if (txtNewPassword.Text != txtNewRePassword.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor");
                return;
            }

            Password newPass = new Password();
            newPass.PasswordText = txtNewPassword.Text;
            newPass.UserID = _user.ID;

            try
            {
                _passwordService.Add(newPass);
                this.Owner.Owner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            
            this.Text = "Şifre Değiştir";
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
