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
    public partial class UpdateWordForm : Form
    {
        Word word;
        WordService wordService;

        public UpdateWordForm(Guid wordID)
        {
            InitializeComponent();
            wordService = new WordService();
            word = wordService.GetByID(wordID);
        }

        private void UpdateWordForm_Load(object sender, EventArgs e)
        {
            txt_tr.Text = word.TurkishText;
            txt_eng.Text = word.EnglishText;

            this.Text = "Güncelle" ;
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            word.TurkishText = txt_tr.Text;
            word.EnglishText = txt_eng.Text;

            bool result = wordService.Update(word);
            if (result)
            {
                MessageBox.Show("Güncelleme işlemi tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız oldu.");
            }
        }

       
    }
}
