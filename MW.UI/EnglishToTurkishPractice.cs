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
    public partial class EnglishToTurkishPractice : Form
    {
        WordService _wordService;
        List<Word> _wordList;
        int count = 0;
        public EnglishToTurkishPractice(List<Word> wordList)
        {
            InitializeComponent();
            _wordService = new WordService();
            _wordList = wordList;

        }

        List<string[]> words = new List<string[]>();
        string[] dictPack;

        private void EnglishToTurkishPractice_Load(object sender, EventArgs e)
        {
            List<Word> wordList = _wordList;
            for (int i = 0; i < wordList.Count; i++)
            {
                dictPack = new string[2];
                dictPack[0] = wordList[i].EnglishText;
                dictPack[1] = wordList[i].TurkishText;
                words.Add(dictPack);
            }
            lblEnglishWord.Text = words[0].GetValue(0).ToString();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == words[count].GetValue(1).ToString())
            {
                lblResult.Visible = true;
                lblResult.ForeColor = Color.MediumSpringGreen;
                lblResult.Text = "Doğru";
                btnNext.Visible = true;
                btnAnswer.Visible = false;
                btnNext.Focus();
            }
            else
            {
                lblResult.Visible = true;
                lblResult.Text = "Yanlış";
                lblResult.ForeColor = Color.Firebrick;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= words.Count)
            {
                DialogResult result = MessageBox.Show("Havuzunuzdaki kelimeler bitti! \n Tekrar başlamak ister misiniz?", "Oyun Sonu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    count = -1;
                    btnNext_Click(sender, e);
                }
                else
                {
                    this.Owner.Show();
                    this.Close();
                }
            }
            else
            {
                lblResult.Visible = false;
                btnNext.Visible = false;
                btnAnswer.Visible = true;
                txtAnswer.Clear();
                txtAnswer.Focus();
                lblEnglishWord.Text = words[count].GetValue(0).ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void btnShowValue_Click(object sender, EventArgs e)
        {
            lblValue.Text = words[count].GetValue(1).ToString();
        }


    }
}
