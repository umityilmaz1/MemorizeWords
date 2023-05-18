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
    public partial class MixedWordsPractice : Form
    {
        //wordpoolID e göre kelimeleri getiren bir method lazım. Bu form dışardan WordPoolId almalı**

        WordService _wordService;
        List<Word> _wordList;
        public MixedWordsPractice(List<Word> wordList)
        {
            InitializeComponent();
            _wordService = new WordService();
            _wordList = wordList;
        }
        Random rndm = new Random();

        int sayi;
        List<string> words = new List<string>();
        
        private void MixedWordsPractice_Load(object sender, EventArgs e)
        {

         List<Word> wordList = _wordList;

            
            for (int i = 0; i < wordList.Count; i++)
            {           
                words.Add(wordList[i].EnglishText);
                //words.Add(wordList[i].TurkishText);

            }


            Game();

          
        }

        void Game()
        {
            int sıra = rndm.Next(0, words.Count);
            sayi = sıra;
            string kelimes = mixWords(words[sıra]);
            textBox1.Text = kelimes;
        }
      
        string mixWords(string kelime)
        {

            int[] arr = new int[kelime.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            
            int counter = 0;
            string mixed = "";
            while (true)
            {
                Random rnd = new Random();

                int random = rnd.Next(0, arr.Length);

                if (Array.IndexOf(arr, random) == -1)
                {
                    mixed += kelime[random];
                    arr[counter++] = random;

                }

                if (counter == arr.Length) break;
            }

            return mixed;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            string enteredWord = textBox2.Text;
            if (enteredWord == words[sayi])
            {
                label1.Text = "Doğru Cevap!";
                textBox2.Clear();
                Game();
            }
            else
            {
                label1.Text = "Tekrar Dene.";
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            lblAnswer.Text = words[sayi];
        }

        private void MixedWordsPractice_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    this.Owner.Show();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}

            this.Owner.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Game();
            label1.Text = "";
            lblAnswer.Text="";
        }
    }
}
