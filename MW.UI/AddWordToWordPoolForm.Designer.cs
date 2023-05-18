namespace MW.UI
{
    partial class AddWordToWordPoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_allWords = new System.Windows.Forms.ListView();
            this.EnglishText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurkishText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_searchButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addWord = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_allWords
            // 
            this.lv_allWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnglishText,
            this.TurkishText});
            this.lv_allWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_allWords.FullRowSelect = true;
            this.lv_allWords.GridLines = true;
            this.lv_allWords.HideSelection = false;
            this.lv_allWords.Location = new System.Drawing.Point(12, 36);
            this.lv_allWords.MultiSelect = false;
            this.lv_allWords.Name = "lv_allWords";
            this.lv_allWords.Size = new System.Drawing.Size(345, 401);
            this.lv_allWords.TabIndex = 0;
            this.lv_allWords.UseCompatibleStateImageBehavior = false;
            this.lv_allWords.View = System.Windows.Forms.View.Details;
            // 
            // EnglishText
            // 
            this.EnglishText.Text = "İngilizce";
            this.EnglishText.Width = 170;
            // 
            // TurkishText
            // 
            this.TurkishText.Text = "Türkçe";
            this.TurkishText.Width = 170;
            // 
            // txt_searchButton
            // 
            this.txt_searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_searchButton.Location = new System.Drawing.Point(221, 7);
            this.txt_searchButton.Name = "txt_searchButton";
            this.txt_searchButton.Size = new System.Drawing.Size(136, 22);
            this.txt_searchButton.TabIndex = 1;
            this.txt_searchButton.TextChanged += new System.EventHandler(this.Txt_searchButton_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara:";
            // 
            // btn_addWord
            // 
            this.btn_addWord.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addWord.ForeColor = System.Drawing.Color.White;
            this.btn_addWord.Location = new System.Drawing.Point(12, 7);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(99, 23);
            this.btn_addWord.TabIndex = 3;
            this.btn_addWord.Text = "Kelime Ekle";
            this.btn_addWord.UseVisualStyleBackColor = false;
            this.btn_addWord.Click += new System.EventHandler(this.Btn_addWord_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(117, 7);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(49, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "İptal";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // AddWordToWordPoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchButton);
            this.Controls.Add(this.lv_allWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddWordToWordPoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havuza Kelime Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_allWords;
        private System.Windows.Forms.ColumnHeader EnglishText;
        private System.Windows.Forms.ColumnHeader TurkishText;
        private System.Windows.Forms.TextBox txt_searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button btn_cancel;
    }
}