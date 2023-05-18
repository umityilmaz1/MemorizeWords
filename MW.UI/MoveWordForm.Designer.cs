namespace MW.UI
{
    partial class MoveWordForm
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
            this.cb_wordPoolList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_wordPoolList
            // 
            this.cb_wordPoolList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_wordPoolList.FormattingEnabled = true;
            this.cb_wordPoolList.Location = new System.Drawing.Point(145, 32);
            this.cb_wordPoolList.Name = "cb_wordPoolList";
            this.cb_wordPoolList.Size = new System.Drawing.Size(189, 26);
            this.cb_wordPoolList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Havuz Seçiniz :";
            // 
            // btn_move
            // 
            this.btn_move.BackColor = System.Drawing.Color.Firebrick;
            this.btn_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_move.Location = new System.Drawing.Point(22, 81);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(142, 38);
            this.btn_move.TabIndex = 2;
            this.btn_move.Text = "Taşı";
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cancel.Location = new System.Drawing.Point(192, 81);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(142, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "İptal";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // MoveWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(367, 154);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_wordPoolList);
            this.Name = "MoveWordForm";
            this.Text = "MoveWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_wordPoolList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_cancel;
    }
}