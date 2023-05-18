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
    public partial class UserMain : Form
    {
        User _user;
        UserService _userService;
        UserRoleService _userRoleService;
        WordPoolService _wordPoolService;
        WordService _wordService;
        RelationWordAndWordPoolService _relationWordAndWordPoolService;
        bool isLinkClicked = false;

        public UserMain(Guid userID)
        {
            InitializeComponent();

            _user = new User() { ID = userID };
            _userService = new UserService();
            _userRoleService = new UserRoleService();
            _wordPoolService = new WordPoolService();
            _relationWordAndWordPoolService = new RelationWordAndWordPoolService();
            _wordService = new WordService();
        } //OK

        private void UserMain_Load(object sender, EventArgs e)
        {
            FillCombobox();

            if (_userRoleService.GetRoleNameByUserID(_user.ID) == "Standard")
                btnPayment.Visible = false;
        } //OK
        private void FillCombobox()
        {
            List<WordPool> _wordPoolList = new List<WordPool>();

            foreach (WordPool item in _wordPoolService.GetListByUserID(_user.ID))
            {
                if (item.IsActive == true)
                {
                    _wordPoolList.Add(item);
                }
            }
            cb_selectPool.DataSource = _wordPoolList;

            if (_wordPoolList.Count == 0)
                cb_selectPool.Text = "";
        } //OK
        private void Cb_selectPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListView();
        }
        private void Btn_addWordPool_Click(object sender, EventArgs e)
        {
            if (_wordPoolService.CanAddMoreWordPool(_user.ID) == false)
            {
                MessageBox.Show("Daha fazla havuz ekleyebilmek için ödeme yapınız.\n\n\t\t\t\tMemorize Words Ekibi");
                return;
            }

            AddWordPoolForm addWordPoolForm = new AddWordPoolForm(_user);
            addWordPoolForm.Owner = this;
            DialogResult result = addWordPoolForm.ShowDialog();

            if (result == DialogResult.OK)
                FillCombobox();
        } //OK
        private void Btn_deleteWordPool_Click(object sender, EventArgs e) //OK
        {
            _wordPoolService.Delete((WordPool)cb_selectPool.SelectedItem);
            FillCombobox();
        }
        private void Btn_addWord_Click(object sender, EventArgs e)
        {
            if (!_wordPoolService.CanAddMoreWordToWordPool(_user.ID, ((WordPool)cb_selectPool.SelectedItem).ID))
            {
                MessageBox.Show("Daha fazla kelime eklemek için ödeme yapmanız gerekmektedir.");
                return;
            }

            List<Guid> allWordPoolsIDOfUser = new List<Guid>();

            foreach (WordPool item in cb_selectPool.Items)
                allWordPoolsIDOfUser.Add(item.ID);

            AddWordToWordPoolForm addWorkToPoolForm = new AddWordToWordPoolForm(((WordPool)cb_selectPool.SelectedItem).ID, allWordPoolsIDOfUser);

            addWorkToPoolForm.Owner = this;
            DialogResult result = addWorkToPoolForm.ShowDialog();

            if (result == DialogResult.OK)
                FillListView();
        } //OK
        private void FillListView() //OK
        {
            lv_wordPoolContent.Items.Clear();
            ListViewItem lvi;
            Word tempWord;

            foreach (RelationWordAndWordPool item in _relationWordAndWordPoolService.GetActiveListByWordPoolID(((WordPool)cb_selectPool.SelectedItem).ID))
            {
                tempWord = _wordService.GetByID(item.WordID);

                lvi = new ListViewItem(tempWord.EnglishText);
                lvi.SubItems.Add(tempWord.TurkishText);
                lvi.Tag = item;
                lv_wordPoolContent.Items.Add(lvi);
            }

        }
        private void btn_doPractice_Click(object sender, EventArgs e)
        {
            if (_userRoleService.GetRoleNameByUserID(_user.ID) == "Restricted")
            {
                MessageBox.Show("Bu alıştırmayı yapabilmeniz için ödeme yapmanız gerekmektedir.\n\n\t\t\t\tMemorize Words Ekibi");
                return;
            }

            List<Word> tempList = new List<Word>();

            foreach (RelationWordAndWordPool item in _relationWordAndWordPoolService.GetActiveListByWordPoolID(((WordPool)cb_selectPool.SelectedItem).ID))
                tempList.Add(_wordService.GetByID(item.WordID));

            User tempUser = _userService.GetByID(_user.ID);
            tempUser.PracticeNumber += 1;
            _userService.Update(tempUser);

            MixedWordsPractice mw = new MixedWordsPractice(tempList);
            mw.Owner = this;
            mw.Show();
            this.Hide();
        }
        private void btnEngToTur_Click(object sender, EventArgs e)
        {
            User tempUser = _userService.GetByID(_user.ID);
            tempUser.PracticeNumber += 1;
            _userService.Update(tempUser);


            List<Word> tempList = new List<Word>();

            foreach (RelationWordAndWordPool item in _relationWordAndWordPoolService.GetActiveListByWordPoolID(((WordPool)cb_selectPool.SelectedItem).ID))
                tempList.Add(_wordService.GetByID(item.WordID));

            EnglishToTurkishPractice e2t = new EnglishToTurkishPractice(tempList);
            e2t.Owner = this;
            e2t.Show();
            this.Hide();
        }
        private void btnTurToEng_Click(object sender, EventArgs e)
        {
            User tempUser = _userService.GetByID(_user.ID);
            tempUser.PracticeNumber += 1;
            _userService.Update(tempUser);

            List<Word> tempList = new List<Word>();

            foreach (RelationWordAndWordPool item in _relationWordAndWordPoolService.GetActiveListByWordPoolID(((WordPool)cb_selectPool.SelectedItem).ID))
                tempList.Add(_wordService.GetByID(item.WordID));

            TurkishToEnglishPractice t2e = new TurkishToEnglishPractice(tempList);
            t2e.Owner = this;
            t2e.Show();
            this.Hide();
        }
        private void UserMain_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnPayment_Click(object sender, EventArgs e)
        {
            isLinkClicked = true;
            PaymentForm frm = new PaymentForm(_userService.GetByID(_user.ID));
            frm.Owner = this;
            frm.Show();
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            isLinkClicked = true;
            ChangePasswordForm change = new ChangePasswordForm(_user);
            change.Owner = this;
            change.Owner.Hide();
            change.Show();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            isLinkClicked = true;
            this.Owner.Show();
            this.Close();
        }
        private void Btn_rename_Click(object sender, EventArgs e)
        {
            AddWordPoolForm addWordPoolForm = new AddWordPoolForm(_user, _wordPoolService.GetByID(((WordPool)cb_selectPool.SelectedItem).ID));
            addWordPoolForm.Owner = this;
            DialogResult result = addWordPoolForm.ShowDialog();

            if (result == DialogResult.OK)
                FillCombobox();
        } //OK
        private void Btn_deleteWord_Click(object sender, EventArgs e)
        {
            if (lv_wordPoolContent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silinecek kelimeyi seçin.");
                return;
            }
            _relationWordAndWordPoolService.Delete((RelationWordAndWordPool)lv_wordPoolContent.SelectedItems[0].Tag);
            FillListView();
        }
        private void Btn_moveWord_Click(object sender, EventArgs e)
        {
            if (_userRoleService.GetRoleNameByUserID(_user.ID) == "Restricted")
            {
                MessageBox.Show("Bu özelliği kullananlmeniz için ödeme yapmanız gerekmektedir.");
                return;
            }
            if (cb_selectPool.Items.Count < 2)
            {
                MessageBox.Show("Kelime taşıyabilecek başka bir havuzunuz yok.");
                return;
            }
            if (lv_wordPoolContent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Taşınacak kelimeyi seçin.");
                return;
            }

            Word moveWordForm = _wordService.GetByID(((RelationWordAndWordPool)lv_wordPoolContent.SelectedItems[0].Tag).WordID);
            List<WordPool> moveList = new List<WordPool>();

            foreach (WordPool item in cb_selectPool.Items)
            {
                if (item.ID != ((WordPool)cb_selectPool.SelectedItem).ID)
                    moveList.Add(item);
            }

            MoveWordForm frm = new MoveWordForm(moveWordForm, moveList, (WordPool)cb_selectPool.SelectedItem);
            frm.Owner = this;
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
                FillListView();
        }
    }
}
