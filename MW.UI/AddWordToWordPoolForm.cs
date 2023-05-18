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
    public partial class AddWordToWordPoolForm : Form
    {
        WordService _wordService;
        RelationWordAndWordPoolService _relationWordAndWordPoolService;
        List<Word> _allWordsList;
        List<Word> _allActiveWordsOfUser;
        WordPool _wordPool;

        public AddWordToWordPoolForm(Guid wordPoolID, List<Guid> allWordPoolsIDOfUser)
        {
            InitializeComponent();

            _wordService = new WordService();
            _relationWordAndWordPoolService = new RelationWordAndWordPoolService();
            _allWordsList = _wordService.ListAll();
            _allActiveWordsOfUser = _wordService.GetAllActiveWordsOfUserByWordPoolsID(allWordPoolsIDOfUser);
            _wordPool = new WordPool() { ID = wordPoolID };

            FillListView(_allWordsList);
        } //OK
        public void FillListView(List<Word> wordList)
        {
            List<Word> tempWordList = new List<Word>();

            foreach (Word item in wordList)
            {
                int flag = 0;

                foreach (Word item2 in _allActiveWordsOfUser)
                {
                    if (item.ID == item2.ID)
                        flag++;
                }
                if (flag == 0)
                    tempWordList.Add(item);

                flag = 0;
            }  

            lv_allWords.Items.Clear();
            ListViewItem lvi;

            foreach (Word item in tempWordList)
            {
                lvi = new ListViewItem(item.EnglishText);
                lvi.SubItems.Add(item.TurkishText);
                lvi.Tag = item;
                lv_allWords.Items.Add(lvi);
            }
        } //OK
        private void Btn_addWord_Click(object sender, EventArgs e)
        {
            if (lv_allWords.SelectedItems.Count == 0)
            {
                MessageBox.Show("Eklenecek kelimeyi seçin.");
                return;
            }

            RelationWordAndWordPool tempRelationWordAndWordPool = new RelationWordAndWordPool();
            tempRelationWordAndWordPool.WordID = ((Word)(lv_allWords.SelectedItems[0].Tag)).ID;
            tempRelationWordAndWordPool.WordPoolID = _wordPool.ID;

            if (_relationWordAndWordPoolService.Add(tempRelationWordAndWordPool) > 0)
                MessageBox.Show("Kelime eklendi.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        } //OK
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } //OK
        private void Txt_searchButton_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_searchButton.Text) || string.IsNullOrWhiteSpace(txt_searchButton.Text))
                FillListView(_allWordsList);
            else
            {
                List<Word> searchList = new List<Word>();

                foreach (Word item in _allWordsList)
                {
                    if (item.EnglishText.Contains(txt_searchButton.Text) || item.TurkishText.Contains(txt_searchButton.Text))
                        searchList.Add(item);
                }

                FillListView(searchList);
            }
        } //OK
    }
}
