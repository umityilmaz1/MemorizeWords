using System.Windows.Forms;

namespace MW.UI
{
    partial class AdminMain
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.passwordButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.usersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poolGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.engWord = new System.Windows.Forms.Label();
            this.trWord = new System.Windows.Forms.Label();
            this.txt_TurkishWord = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.txt_EnglishWord = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reportsBox = new System.Windows.Forms.GroupBox();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.tabWord = new System.Windows.Forms.TabPage();
            this.dgvWord = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordAddingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPractice = new System.Windows.Forms.TabPage();
            this.dgvPractice = new System.Windows.Forms.DataGridView();
            this.User2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRestrictedMember = new System.Windows.Forms.TabPage();
            this.dgvRestrictedMember = new System.Windows.Forms.DataGridView();
            this.RestrictedMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCiro = new System.Windows.Forms.TabPage();
            this.dgvGiro = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adminPanel.SuspendLayout();
            this.usersGroupBox.SuspendLayout();
            this.poolGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reportsBox.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tabWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabPractice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractice)).BeginInit();
            this.tabRestrictedMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestrictedMember)).BeginInit();
            this.tabCiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiro)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.adminPanel.Controls.Add(this.passwordButton);
            this.adminPanel.Controls.Add(this.logoutButton);
            this.adminPanel.Location = new System.Drawing.Point(715, 38);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(244, 98);
            this.adminPanel.TabIndex = 0;
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.passwordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordButton.ForeColor = System.Drawing.Color.White;
            this.passwordButton.Location = new System.Drawing.Point(34, 4);
            this.passwordButton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(179, 39);
            this.passwordButton.TabIndex = 4;
            this.passwordButton.Text = "Şifreyi Değiştir";
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(34, 50);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(179, 43);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Çıkış Yap";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.usersList);
            this.usersGroupBox.Location = new System.Drawing.Point(34, 27);
            this.usersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.usersGroupBox.Size = new System.Drawing.Size(632, 298);
            this.usersGroupBox.TabIndex = 1;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Kullanıcılar";
            // 
            // usersList
            // 
            this.usersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usersList.FullRowSelect = true;
            this.usersList.Location = new System.Drawing.Point(16, 23);
            this.usersList.Margin = new System.Windows.Forms.Padding(4);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(598, 253);
            this.usersList.TabIndex = 0;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.Details;
            this.usersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.usersList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // poolGroupBox
            // 
            this.poolGroupBox.Controls.Add(this.label4);
            this.poolGroupBox.Controls.Add(this.textBox1);
            this.poolGroupBox.Controls.Add(this.wordsListBox);
            this.poolGroupBox.Controls.Add(this.groupBox1);
            this.poolGroupBox.Controls.Add(this.deleteButton);
            this.poolGroupBox.Location = new System.Drawing.Point(34, 332);
            this.poolGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.poolGroupBox.Name = "poolGroupBox";
            this.poolGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.poolGroupBox.Size = new System.Drawing.Size(632, 298);
            this.poolGroupBox.TabIndex = 2;
            this.poolGroupBox.TabStop = false;
            this.poolGroupBox.Text = "Kelime Havuzu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kelime Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.ItemHeight = 16;
            this.wordsListBox.Location = new System.Drawing.Point(16, 30);
            this.wordsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(189, 212);
            this.wordsListBox.TabIndex = 4;
            this.wordsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.wordsListBox_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.engWord);
            this.groupBox1.Controls.Add(this.trWord);
            this.groupBox1.Controls.Add(this.txt_TurkishWord);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.txt_EnglishWord);
            this.groupBox1.Location = new System.Drawing.Point(368, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(246, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kelime Ekle";
            // 
            // engWord
            // 
            this.engWord.AutoSize = true;
            this.engWord.Location = new System.Drawing.Point(23, 46);
            this.engWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engWord.Name = "engWord";
            this.engWord.Size = new System.Drawing.Size(59, 16);
            this.engWord.TabIndex = 6;
            this.engWord.Text = "İngilizce:";
            // 
            // trWord
            // 
            this.trWord.AutoSize = true;
            this.trWord.Location = new System.Drawing.Point(29, 84);
            this.trWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trWord.Name = "trWord";
            this.trWord.Size = new System.Drawing.Size(53, 16);
            this.trWord.TabIndex = 5;
            this.trWord.Text = "Türkçe:";
            // 
            // txt_TurkishWord
            // 
            this.txt_TurkishWord.Location = new System.Drawing.Point(90, 84);
            this.txt_TurkishWord.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TurkishWord.Name = "txt_TurkishWord";
            this.txt_TurkishWord.Size = new System.Drawing.Size(132, 22);
            this.txt_TurkishWord.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(26, 136);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 28);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txt_EnglishWord
            // 
            this.txt_EnglishWord.Location = new System.Drawing.Point(90, 42);
            this.txt_EnglishWord.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EnglishWord.Name = "txt_EnglishWord";
            this.txt_EnglishWord.Size = new System.Drawing.Size(132, 22);
            this.txt_EnglishWord.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(223, 243);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Kelime Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reportsBox
            // 
            this.reportsBox.Controls.Add(this.tabReport);
            this.reportsBox.Controls.Add(this.label3);
            this.reportsBox.Controls.Add(this.label2);
            this.reportsBox.Controls.Add(this.label1);
            this.reportsBox.Controls.Add(this.btnGetReport);
            this.reportsBox.Controls.Add(this.dateTimePicker2);
            this.reportsBox.Controls.Add(this.dateTimePicker1);
            this.reportsBox.Location = new System.Drawing.Point(690, 169);
            this.reportsBox.Margin = new System.Windows.Forms.Padding(4);
            this.reportsBox.Name = "reportsBox";
            this.reportsBox.Padding = new System.Windows.Forms.Padding(4);
            this.reportsBox.Size = new System.Drawing.Size(307, 462);
            this.reportsBox.TabIndex = 3;
            this.reportsBox.TabStop = false;
            this.reportsBox.Text = "Raporlar";
            this.reportsBox.Enter += new System.EventHandler(this.reportsBox_Enter);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabWord);
            this.tabReport.Controls.Add(this.tabUser);
            this.tabReport.Controls.Add(this.tabPractice);
            this.tabReport.Controls.Add(this.tabRestrictedMember);
            this.tabReport.Controls.Add(this.tabCiro);
            this.tabReport.Location = new System.Drawing.Point(7, 153);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(284, 302);
            this.tabReport.TabIndex = 8;
            // 
            // tabWord
            // 
            this.tabWord.Controls.Add(this.dgvWord);
            this.tabWord.Location = new System.Drawing.Point(4, 25);
            this.tabWord.Name = "tabWord";
            this.tabWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabWord.Size = new System.Drawing.Size(276, 273);
            this.tabWord.TabIndex = 0;
            this.tabWord.Text = "Kelime";
            this.tabWord.UseVisualStyleBackColor = true;
            // 
            // dgvWord
            // 
            this.dgvWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.UsingCount});
            this.dgvWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWord.Location = new System.Drawing.Point(3, 3);
            this.dgvWord.Name = "dgvWord";
            this.dgvWord.Size = new System.Drawing.Size(270, 267);
            this.dgvWord.TabIndex = 4;
            // 
            // Word
            // 
            this.Word.HeaderText = "Kelime";
            this.Word.Name = "Word";
            // 
            // UsingCount
            // 
            this.UsingCount.HeaderText = "Eklenme Sayısı";
            this.UsingCount.Name = "UsingCount";
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.dgvUser);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(276, 273);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "Kullanıcı";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.WordAddingCount});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(270, 267);
            this.dgvUser.TabIndex = 5;
            // 
            // User
            // 
            this.User.HeaderText = "Kullanıcı";
            this.User.Name = "User";
            this.User.Width = 105;
            // 
            // WordAddingCount
            // 
            this.WordAddingCount.HeaderText = "Kelime Ekleme Sayısı";
            this.WordAddingCount.MinimumWidth = 25;
            this.WordAddingCount.Name = "WordAddingCount";
            this.WordAddingCount.Width = 120;
            // 
            // tabPractice
            // 
            this.tabPractice.Controls.Add(this.dgvPractice);
            this.tabPractice.Location = new System.Drawing.Point(4, 25);
            this.tabPractice.Name = "tabPractice";
            this.tabPractice.Size = new System.Drawing.Size(276, 273);
            this.tabPractice.TabIndex = 2;
            this.tabPractice.Text = "Pratik";
            this.tabPractice.UseVisualStyleBackColor = true;
            // 
            // dgvPractice
            // 
            this.dgvPractice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPractice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User2,
            this.PracticeCount});
            this.dgvPractice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPractice.Location = new System.Drawing.Point(0, 0);
            this.dgvPractice.Name = "dgvPractice";
            this.dgvPractice.Size = new System.Drawing.Size(276, 273);
            this.dgvPractice.TabIndex = 5;
            // 
            // User2
            // 
            this.User2.HeaderText = "Kullanıcı";
            this.User2.Name = "User2";
            this.User2.Width = 120;
            // 
            // PracticeCount
            // 
            this.PracticeCount.HeaderText = "Pratik Sayısı";
            this.PracticeCount.Name = "PracticeCount";
            this.PracticeCount.Width = 105;
            // 
            // tabRestrictedMember
            // 
            this.tabRestrictedMember.Controls.Add(this.dgvRestrictedMember);
            this.tabRestrictedMember.Location = new System.Drawing.Point(4, 25);
            this.tabRestrictedMember.Name = "tabRestrictedMember";
            this.tabRestrictedMember.Size = new System.Drawing.Size(276, 273);
            this.tabRestrictedMember.TabIndex = 3;
            this.tabRestrictedMember.Text = "Kısıtlı Üye";
            this.tabRestrictedMember.UseVisualStyleBackColor = true;
            // 
            // dgvRestrictedMember
            // 
            this.dgvRestrictedMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestrictedMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestrictedMember,
            this.Status});
            this.dgvRestrictedMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRestrictedMember.Location = new System.Drawing.Point(0, 0);
            this.dgvRestrictedMember.Name = "dgvRestrictedMember";
            this.dgvRestrictedMember.Size = new System.Drawing.Size(276, 273);
            this.dgvRestrictedMember.TabIndex = 5;
            // 
            // RestrictedMember
            // 
            this.RestrictedMember.HeaderText = "Kullanıcı";
            this.RestrictedMember.Name = "RestrictedMember";
            this.RestrictedMember.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Durumu";
            this.Status.Name = "Status";
            this.Status.Width = 105;
            // 
            // tabCiro
            // 
            this.tabCiro.Controls.Add(this.dgvGiro);
            this.tabCiro.Location = new System.Drawing.Point(4, 25);
            this.tabCiro.Name = "tabCiro";
            this.tabCiro.Size = new System.Drawing.Size(276, 273);
            this.tabCiro.TabIndex = 4;
            this.tabCiro.Text = "Ciro";
            this.tabCiro.UseVisualStyleBackColor = true;
            // 
            // dgvGiro
            // 
            this.dgvGiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Giro});
            this.dgvGiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiro.Location = new System.Drawing.Point(0, 0);
            this.dgvGiro.Name = "dgvGiro";
            this.dgvGiro.Size = new System.Drawing.Size(276, 273);
            this.dgvGiro.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Aralık";
            this.Date.Name = "Date";
            this.Date.Width = 122;
            // 
            // Giro
            // 
            this.Giro.HeaderText = "Ciro";
            this.Giro.Name = "Giro";
            this.Giro.Width = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Son Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İlk Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rapor almak istediğiniz aralığı seçin.";
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackColor = System.Drawing.Color.Firebrick;
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetReport.ForeColor = System.Drawing.Color.White;
            this.btnGetReport.Location = new System.Drawing.Point(15, 111);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(276, 36);
            this.btnGetReport.TabIndex = 3;
            this.btnGetReport.Text = "Rapor Al";
            this.btnGetReport.UseVisualStyleBackColor = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(87, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 26, 14, 40, 37, 0);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1010, 676);
            this.Controls.Add(this.reportsBox);
            this.Controls.Add(this.poolGroupBox);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.adminPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.adminPanel.ResumeLayout(false);
            this.usersGroupBox.ResumeLayout(false);
            this.poolGroupBox.ResumeLayout(false);
            this.poolGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.reportsBox.ResumeLayout(false);
            this.reportsBox.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabWord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).EndInit();
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabPractice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractice)).EndInit();
            this.tabRestrictedMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestrictedMember)).EndInit();
            this.tabCiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.GroupBox poolGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label engWord;
        private System.Windows.Forms.Label trWord;
        private System.Windows.Forms.TextBox txt_EnglishWord;
        private System.Windows.Forms.TextBox txt_TurkishWord;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox reportsBox;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.TabPage tabWord;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TabPage tabPractice;
        private System.Windows.Forms.DataGridView dgvPractice;
        private System.Windows.Forms.TabPage tabRestrictedMember;
        private System.Windows.Forms.DataGridView dgvRestrictedMember;
        private System.Windows.Forms.TabPage tabCiro;
        private System.Windows.Forms.DataGridView dgvGiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordAddingCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn User2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestrictedMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Giro;
        private TextBox textBox1;
        private Label label4;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn UsingCount;
    }
}