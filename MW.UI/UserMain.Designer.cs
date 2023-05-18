namespace MW.UI
{
    partial class UserMain
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
            this.lv_wordPoolContent = new System.Windows.Forms.ListView();
            this.englishText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turkishText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addWord = new System.Windows.Forms.Button();
            this.cb_selectPool = new System.Windows.Forms.ComboBox();
            this.btn_deleteWord = new System.Windows.Forms.Button();
            this.btnMixWords = new System.Windows.Forms.Button();
            this.btn_addWordPool = new System.Windows.Forms.Button();
            this.btn_deleteWordPool = new System.Windows.Forms.Button();
            this.btn_moveWord = new System.Windows.Forms.Button();
            this.btnEngToTur = new System.Windows.Forms.Button();
            this.btnTurToEng = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_rename = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_wordPoolContent
            // 
            this.lv_wordPoolContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.englishText,
            this.turkishText});
            this.lv_wordPoolContent.FullRowSelect = true;
            this.lv_wordPoolContent.GridLines = true;
            this.lv_wordPoolContent.HideSelection = false;
            this.lv_wordPoolContent.Location = new System.Drawing.Point(20, 58);
            this.lv_wordPoolContent.Margin = new System.Windows.Forms.Padding(4);
            this.lv_wordPoolContent.Name = "lv_wordPoolContent";
            this.lv_wordPoolContent.Size = new System.Drawing.Size(428, 488);
            this.lv_wordPoolContent.TabIndex = 3;
            this.lv_wordPoolContent.UseCompatibleStateImageBehavior = false;
            this.lv_wordPoolContent.View = System.Windows.Forms.View.Details;
            // 
            // englishText
            // 
            this.englishText.Text = "İngilizce";
            this.englishText.Width = 212;
            // 
            // turkishText
            // 
            this.turkishText.Text = "Türkçe";
            this.turkishText.Width = 212;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Havuz Seçiniz :";
            // 
            // btn_addWord
            // 
            this.btn_addWord.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addWord.ForeColor = System.Drawing.Color.White;
            this.btn_addWord.Location = new System.Drawing.Point(7, 22);
            this.btn_addWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(142, 28);
            this.btn_addWord.TabIndex = 4;
            this.btn_addWord.Text = "Kelime Ekle";
            this.btn_addWord.UseVisualStyleBackColor = false;
            this.btn_addWord.Click += new System.EventHandler(this.Btn_addWord_Click);
            // 
            // cb_selectPool
            // 
            this.cb_selectPool.FormattingEnabled = true;
            this.cb_selectPool.Location = new System.Drawing.Point(126, 15);
            this.cb_selectPool.Margin = new System.Windows.Forms.Padding(4);
            this.cb_selectPool.Name = "cb_selectPool";
            this.cb_selectPool.Size = new System.Drawing.Size(322, 24);
            this.cb_selectPool.TabIndex = 1;
            this.cb_selectPool.SelectedIndexChanged += new System.EventHandler(this.Cb_selectPool_SelectedIndexChanged);
            // 
            // btn_deleteWord
            // 
            this.btn_deleteWord.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_deleteWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_deleteWord.ForeColor = System.Drawing.Color.White;
            this.btn_deleteWord.Location = new System.Drawing.Point(7, 58);
            this.btn_deleteWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteWord.Name = "btn_deleteWord";
            this.btn_deleteWord.Size = new System.Drawing.Size(142, 28);
            this.btn_deleteWord.TabIndex = 5;
            this.btn_deleteWord.Text = "Kelime Sil";
            this.btn_deleteWord.UseVisualStyleBackColor = false;
            this.btn_deleteWord.Click += new System.EventHandler(this.Btn_deleteWord_Click);
            // 
            // btnMixWords
            // 
            this.btnMixWords.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMixWords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMixWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMixWords.ForeColor = System.Drawing.Color.White;
            this.btnMixWords.Location = new System.Drawing.Point(4, 4);
            this.btnMixWords.Margin = new System.Windows.Forms.Padding(4);
            this.btnMixWords.Name = "btnMixWords";
            this.btnMixWords.Size = new System.Drawing.Size(142, 28);
            this.btnMixWords.TabIndex = 6;
            this.btnMixWords.Text = "Kelime Karıştır";
            this.btnMixWords.UseVisualStyleBackColor = false;
            this.btnMixWords.Click += new System.EventHandler(this.btn_doPractice_Click);
            // 
            // btn_addWordPool
            // 
            this.btn_addWordPool.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addWordPool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addWordPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addWordPool.ForeColor = System.Drawing.Color.White;
            this.btn_addWordPool.Location = new System.Drawing.Point(7, 22);
            this.btn_addWordPool.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addWordPool.Name = "btn_addWordPool";
            this.btn_addWordPool.Size = new System.Drawing.Size(142, 28);
            this.btn_addWordPool.TabIndex = 7;
            this.btn_addWordPool.Text = "Havuz Ekle";
            this.btn_addWordPool.UseVisualStyleBackColor = false;
            this.btn_addWordPool.Click += new System.EventHandler(this.Btn_addWordPool_Click);
            // 
            // btn_deleteWordPool
            // 
            this.btn_deleteWordPool.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_deleteWordPool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteWordPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_deleteWordPool.ForeColor = System.Drawing.Color.White;
            this.btn_deleteWordPool.Location = new System.Drawing.Point(7, 58);
            this.btn_deleteWordPool.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteWordPool.Name = "btn_deleteWordPool";
            this.btn_deleteWordPool.Size = new System.Drawing.Size(142, 28);
            this.btn_deleteWordPool.TabIndex = 8;
            this.btn_deleteWordPool.Text = "Havuz Sil";
            this.btn_deleteWordPool.UseVisualStyleBackColor = false;
            this.btn_deleteWordPool.Click += new System.EventHandler(this.Btn_deleteWordPool_Click);
            // 
            // btn_moveWord
            // 
            this.btn_moveWord.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_moveWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_moveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_moveWord.ForeColor = System.Drawing.Color.White;
            this.btn_moveWord.Location = new System.Drawing.Point(7, 94);
            this.btn_moveWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_moveWord.Name = "btn_moveWord";
            this.btn_moveWord.Size = new System.Drawing.Size(142, 28);
            this.btn_moveWord.TabIndex = 9;
            this.btn_moveWord.Text = "Kelime Taşı";
            this.btn_moveWord.UseVisualStyleBackColor = false;
            this.btn_moveWord.Click += new System.EventHandler(this.Btn_moveWord_Click);
            // 
            // btnEngToTur
            // 
            this.btnEngToTur.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEngToTur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEngToTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEngToTur.ForeColor = System.Drawing.Color.White;
            this.btnEngToTur.Location = new System.Drawing.Point(4, 40);
            this.btnEngToTur.Margin = new System.Windows.Forms.Padding(4);
            this.btnEngToTur.Name = "btnEngToTur";
            this.btnEngToTur.Size = new System.Drawing.Size(142, 28);
            this.btnEngToTur.TabIndex = 6;
            this.btnEngToTur.Text = "Eng -> Tur";
            this.btnEngToTur.UseVisualStyleBackColor = false;
            this.btnEngToTur.Click += new System.EventHandler(this.btnEngToTur_Click);
            // 
            // btnTurToEng
            // 
            this.btnTurToEng.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTurToEng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurToEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurToEng.ForeColor = System.Drawing.Color.White;
            this.btnTurToEng.Location = new System.Drawing.Point(4, 76);
            this.btnTurToEng.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurToEng.Name = "btnTurToEng";
            this.btnTurToEng.Size = new System.Drawing.Size(142, 28);
            this.btnTurToEng.TabIndex = 6;
            this.btnTurToEng.Text = "Tur -> Eng";
            this.btnTurToEng.UseVisualStyleBackColor = false;
            this.btnTurToEng.Click += new System.EventHandler(this.btnTurToEng_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePassword.Location = new System.Drawing.Point(7, 22);
            this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(142, 28);
            this.btn_ChangePassword.TabIndex = 12;
            this.btn_ChangePassword.Text = "Şifre Değiştir";
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Firebrick;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(7, 58);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(142, 28);
            this.btnPayment.TabIndex = 10;
            this.btnPayment.Text = "Ödeme Yap";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.Location = new System.Drawing.Point(7, 94);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(142, 28);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Çıkış Yap";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rename);
            this.groupBox1.Controls.Add(this.btn_addWordPool);
            this.groupBox1.Controls.Add(this.btn_deleteWordPool);
            this.groupBox1.Location = new System.Drawing.Point(460, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 126);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havuz İşlemleri";
            // 
            // btn_rename
            // 
            this.btn_rename.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_rename.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rename.ForeColor = System.Drawing.Color.White;
            this.btn_rename.Location = new System.Drawing.Point(7, 94);
            this.btn_rename.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(142, 28);
            this.btn_rename.TabIndex = 9;
            this.btn_rename.Text = "Yeniden Adlandır";
            this.btn_rename.UseVisualStyleBackColor = false;
            this.btn_rename.Click += new System.EventHandler(this.Btn_rename_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addWord);
            this.groupBox2.Controls.Add(this.btn_deleteWord);
            this.groupBox2.Controls.Add(this.btn_moveWord);
            this.groupBox2.Location = new System.Drawing.Point(460, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 129);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime İşlemleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(460, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 129);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pratik Yap";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ChangePassword);
            this.groupBox4.Controls.Add(this.btnPayment);
            this.groupBox4.Controls.Add(this.btn_LogOut);
            this.groupBox4.Location = new System.Drawing.Point(460, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 129);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ayarlar";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMixWords);
            this.flowLayoutPanel1.Controls.Add(this.btnEngToTur);
            this.flowLayoutPanel1.Controls.Add(this.btnTurToEng);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(151, 108);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(638, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_wordPoolContent);
            this.Controls.Add(this.cb_selectPool);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMain_FormClosing);
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_wordPoolContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.ComboBox cb_selectPool;
        private System.Windows.Forms.Button btn_deleteWord;
        private System.Windows.Forms.Button btnMixWords;
        private System.Windows.Forms.Button btn_addWordPool;
        private System.Windows.Forms.Button btn_deleteWordPool;
        private System.Windows.Forms.Button btn_moveWord;
        private System.Windows.Forms.ColumnHeader englishText;
        private System.Windows.Forms.ColumnHeader turkishText;
        private System.Windows.Forms.Button btnEngToTur;
        private System.Windows.Forms.Button btnTurToEng;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}