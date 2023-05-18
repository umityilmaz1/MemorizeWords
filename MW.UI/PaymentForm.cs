using MW.Model;
using MW.BLL;
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
    public partial class PaymentForm : Form
    {
        User _user;
        PaymentService paymentService;
        UserService UserService;
        UserRoleService UserRoleService;

        public PaymentForm(User user)
        {
            InitializeComponent();
            _user = user;
            paymentService = new PaymentService();
            UserService = new UserService();
            UserRoleService = new UserRoleService();

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            this.Text = "Ödeme";

            pnl_card.Enabled = false;

            lbl_name.Text = _user.Name;
            lbl_surname.Text = _user.Surname;
            lbl_mail.Text = _user.EMail;

            btn_Pay.Enabled = false;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            string paymentType = "";

            if (radiobtn_card.Checked)
            {
                if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.");
                }
                else
                {
                    paymentType = "Kredi Kartı";
                    Pay(paymentType);

                    this.Owner.Owner.Show();
                    this.Owner.Close();
                    this.Close();
                }
            } 
            else if (radiobtn_cash.Checked)
            {
                paymentType = "Nakit";
                Pay(paymentType);

                this.Owner.Owner.Show();
                this.Owner.Close();
                this.Close();
            }          

        }

        public void Pay(string typeofpayment)
        {
            Payment payment = new Payment()
            {
                ID = _user.ID,
                IsPaymentDone = true,
                PaymentType = typeofpayment,
            };


            if (paymentService.Add(payment))
            {

                UserRole userRole = UserRoleService.GetRoleByMail(_user.EMail);

                _user.RoleID = UserRoleService.GetRoleByName("Standard").ID;

                UserService.Update(_user);

                MessageBox.Show("Ödemeniz Onaylanmıştır.");

            }
            else

                MessageBox.Show("Ödeme başarısız.");
        }


        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void radiobtn_cash_CheckedChanged(object sender, EventArgs e)
        {
             btn_Pay.Enabled = true;
            pnl_card.Enabled = false;
        }

        private void radiobtn_card_CheckedChanged(object sender, EventArgs e)
        {
            pnl_card.Enabled = true;

            btn_Pay.Enabled = true;

           

        }
    }
}
