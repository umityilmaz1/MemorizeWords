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
    public partial class AdminMain : Form
    {
        User _user;
        UserService UserService;
        WordService WordService;
        PaymentService PaymentService;
        RelationWordAndWordPoolService relation;
        bool isLinkClicked = false;

        public AdminMain(User user)
        {
            InitializeComponent();

            UserService = new UserService();
            WordService = new WordService();
            PaymentService = new PaymentService();
            relation = new RelationWordAndWordPoolService();
            _user = user;
        }
        List<Word> words;
        private void FillWordsList()
        {
            wordsListBox.DisplayMember = "EnglishText";
            wordsListBox.ValueMember = "ID";
            words = WordService.ListAll();
            wordsListBox.DataSource = words;
            
           
        }

        private void FillUsersList()
        {
            List<User> users = UserService.ListAll();
            ListViewItem lvi;
            usersList.Clear();
            usersList.Columns.Add("Ad",150);
            usersList.Columns.Add("Soyad",150);
            usersList.Columns.Add("E-Mail",225);
            usersList.Columns.Add("Statü",50);
            foreach (User item in users)
            {
                lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Surname);
                lvi.SubItems.Add(item.EMail);
                lvi.SubItems.Add(item.IsActive ? "Aktif" : "Pasif");

                lvi.Tag = item;
                usersList.Items.Add(lvi);
            }

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            
            this.Text = "Admin";
            FillUsersList();
            FillWordsList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            word.TurkishText = txt_TurkishWord.Text;
            word.EnglishText = txt_EnglishWord.Text;

            bool result = false;
            try
            {
                result = WordService.Add(word);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (result)
            {
                FillWordsList();
                txt_EnglishWord.Clear();
                txt_TurkishWord.Clear();
            }
            else
            {
                MessageBox.Show("Kelime eklenemedi.");
            }

            FillWordsList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (wordsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir kelime seçip tekrar deneyiniz.");
                return;
            }

            Guid wordID = (Guid)wordsListBox.SelectedValue;
            Word word = WordService.GetByID(wordID);
            WordService.Delete(word);
            FillWordsList();


        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            isLinkClicked = true;
            ChangePasswordForm change = new ChangePasswordForm(_user);
            change.Owner = this;
            change.Owner.Hide();
            change.Show();

        }

        private void usersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            ListViewItem selected = usersList.SelectedItems[0];
            User currentUser = selected.Tag as User;

            DialogResult result = MessageBox.Show("Bu kullanıcıyı onaylamak istediğinizden emin misiniz?", "Kullanıcı Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserService.ActivateUser(currentUser);
                //usersList.Clear(); userlist tekrar tekrar ekleniyor.***
                FillUsersList();
            }
        }

        private void wordsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Guid wordID = (Guid)wordsListBox.SelectedValue;
            UpdateWordForm updateWordForm = new UpdateWordForm(wordID);
            updateWordForm.ShowDialog();
            FillWordsList();

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            dgvPractice.Rows.Clear();
            dgvPractice.Refresh();

            dgvRestrictedMember.Rows.Clear();
            dgvRestrictedMember.Refresh();

            dgvWord.Rows.Clear();
            dgvWord.Refresh();

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            
            decimal giro = PaymentService.GetFund(date1, date2);

            List<User> restrictedUserList = UserService.ListRestrictedUsers();
            foreach (var item in restrictedUserList)
            {
                dgvRestrictedMember.Rows.Add(item.Name+" "+item.Surname, "Restricted");
            }
            
            dgvGiro.Rows.Add((date2-date1).Days +" günlük", giro);

            List<string[]> wordsCountList = relation.ListWordsCount();
            dgvWord.Rows.Clear();
            foreach (var item in wordsCountList)
            {
                dgvWord.Rows.Add(item[0],item[1]);
            }


            List<string[]> wordsUserCountList = relation.ListUserWordsCount(date1,date2);
            dgvUser.Rows.Clear();
            foreach (var item in wordsUserCountList)
            {
                dgvUser.Rows.Add(item[0], item[1]);
            }

            List<User> users = UserService.ListAll();
            foreach (var item in users)
            {
                dgvPractice.Rows.Add(item.Name + " " + item.Surname, item.PracticeNumber);
            }
            


        }

        private void reportsBox_Enter(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            isLinkClicked = true;
            this.Owner.Show();
            this.Close();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLinkClicked)
            {
                DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Owner.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if(txt.Length==0)
            {
                FillWordsList();
                return;
            }

            wordsListBox.DataSource = null;

            wordsListBox.DisplayMember = "EnglishText";
            wordsListBox.ValueMember = "ID";
            words = WordService.GetContains(txt);

            wordsListBox.DataSource = words;

        }


    }
}
