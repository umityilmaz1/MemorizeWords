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
    public partial class MoveWordForm : Form
    {
        Word _word;
        List<WordPool> _wordPoolList;
        WordPool _wordpool;
        RelationWordAndWordPoolService _relationWordAndWordPoolService;

        public MoveWordForm(Word moveWord, List<WordPool> wordPoolList, WordPool wordPool)
        {
            InitializeComponent();
            _word = moveWord;
            _wordPoolList = wordPoolList;
            _wordpool = wordPool;
            _relationWordAndWordPoolService = new RelationWordAndWordPoolService();


            FillCombobox();
        }

        private void FillCombobox()
        {
            cb_wordPoolList.DataSource = _wordPoolList;
        } //OK
        private void Btn_move_Click(object sender, EventArgs e)
        {
            RelationWordAndWordPool tempRelation = _relationWordAndWordPoolService.GetActiveRelationByWordIDAndWordPoolID(_word.ID, _wordpool.ID);
            tempRelation.WordPoolID = ((WordPool)cb_wordPoolList.SelectedItem).ID;
            _relationWordAndWordPoolService.Update(tempRelation);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } //OK
    }
}
