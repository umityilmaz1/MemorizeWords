using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW.Model;
using MW.BLL;

namespace MW.UI
{
    public partial class AddWordPoolForm : Form
    {
        User user;
        WordPool _wordPool;
        WordPoolService _wordPoolService;

        public AddWordPoolForm(User user)
        {
            InitializeComponent();
            _wordPoolService = new WordPoolService();
            this.user = user;
            btn_rename.Hide();
        } //OK
        public AddWordPoolForm(User user, WordPool wordPool)
        {
            InitializeComponent();

            _wordPoolService = new WordPoolService();
            this.user = user;
            this._wordPool = wordPool;
            btn_add.Hide();
            txt_name.Text = wordPool.Name;

        } //OK

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Havuz adı giriniz.");
            }
            else
            {
                if (_wordPoolService.IsWordPoolExist(user.ID, txt_name.Text) == true)
                {
                    MessageBox.Show("Bu isme sahip havuzunuz zaten var.");
                }
                else
                {
                    _wordPoolService.Add(new WordPool() { Name = txt_name.Text, UserID = user.ID });
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Havuz Eklendi.");
                    this.Owner.Show();
                    this.Close();
                }
            }
        } //OK
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        } //OK
        private void Btn_rename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Havuz adı giriniz.");
            }
            else
            {
                if (_wordPoolService.IsWordPoolExist(user.ID, txt_name.Text) == true)
                {
                    MessageBox.Show("Bu isme sahip havuzunuz zaten var.");
                }
                else
                {
                    _wordPool.Name = txt_name.Text;
                    _wordPoolService.Update(_wordPool);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Havuz adı değiştirildi.");
                    this.Owner.Show();
                    this.Close();
                }
            }
        } //OK
    }
}
