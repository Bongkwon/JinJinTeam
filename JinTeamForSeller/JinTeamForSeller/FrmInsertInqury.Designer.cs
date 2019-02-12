namespace JinTeamForSeller
{
    partial class FrmInsertInqury
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInquireType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInquireTitle = new System.Windows.Forms.TextBox();
            this.txtInquireBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInquireDate = new System.Windows.Forms.Label();
            this.lblReBody = new System.Windows.Forms.Label();
            this.lblReDate = new System.Windows.Forms.Label();
            this.picInquire = new System.Windows.Forms.PictureBox();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInsertInquire = new System.Windows.Forms.Button();
            this.txt_Re_Body = new System.Windows.Forms.TextBox();
            this.lblRe_Date = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInquire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "문의 구분";
            // 
            // cmbInquireType
            // 
            this.cmbInquireType.FormattingEnabled = true;
            this.cmbInquireType.Items.AddRange(new object[] {
            "피드백",
            "사용문의",
            "회원문의",
            "기타",
            "시스템",
            "결제문의"});
            this.cmbInquireType.Location = new System.Drawing.Point(76, 10);
            this.cmbInquireType.Name = "cmbInquireType";
            this.cmbInquireType.Size = new System.Drawing.Size(121, 20);
            this.cmbInquireType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "문의 제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "문의 내용";
            // 
            // txtInquireTitle
            // 
            this.txtInquireTitle.Location = new System.Drawing.Point(76, 36);
            this.txtInquireTitle.Name = "txtInquireTitle";
            this.txtInquireTitle.Size = new System.Drawing.Size(296, 21);
            this.txtInquireTitle.TabIndex = 4;
            // 
            // txtInquireBody
            // 
            this.txtInquireBody.Location = new System.Drawing.Point(76, 63);
            this.txtInquireBody.Multiline = true;
            this.txtInquireBody.Name = "txtInquireBody";
            this.txtInquireBody.Size = new System.Drawing.Size(296, 208);
            this.txtInquireBody.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "문의 날짜";
            // 
            // lblInquireDate
            // 
            this.lblInquireDate.AutoSize = true;
            this.lblInquireDate.Location = new System.Drawing.Point(285, 13);
            this.lblInquireDate.Name = "lblInquireDate";
            this.lblInquireDate.Size = new System.Drawing.Size(0, 12);
            this.lblInquireDate.TabIndex = 7;
            // 
            // lblReBody
            // 
            this.lblReBody.AutoSize = true;
            this.lblReBody.Location = new System.Drawing.Point(13, 332);
            this.lblReBody.Name = "lblReBody";
            this.lblReBody.Size = new System.Drawing.Size(57, 12);
            this.lblReBody.TabIndex = 8;
            this.lblReBody.Text = "문의 답글";
            this.lblReBody.Visible = false;
            // 
            // lblReDate
            // 
            this.lblReDate.AutoSize = true;
            this.lblReDate.Location = new System.Drawing.Point(13, 303);
            this.lblReDate.Name = "lblReDate";
            this.lblReDate.Size = new System.Drawing.Size(57, 12);
            this.lblReDate.TabIndex = 9;
            this.lblReDate.Text = "답변 날짜";
            this.lblReDate.Visible = false;
            // 
            // picInquire
            // 
            this.picInquire.Location = new System.Drawing.Point(397, 36);
            this.picInquire.Name = "picInquire";
            this.picInquire.Size = new System.Drawing.Size(271, 235);
            this.picInquire.TabIndex = 10;
            this.picInquire.TabStop = false;
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(570, 10);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(98, 23);
            this.btnInsertImg.TabIndex = 11;
            this.btnInsertImg.Text = "이미지 첨부";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInsertInquire
            // 
            this.btnInsertInquire.Location = new System.Drawing.Point(573, 277);
            this.btnInsertInquire.Name = "btnInsertInquire";
            this.btnInsertInquire.Size = new System.Drawing.Size(95, 23);
            this.btnInsertInquire.TabIndex = 12;
            this.btnInsertInquire.Text = "문의 남기기";
            this.btnInsertInquire.UseVisualStyleBackColor = true;
            // 
            // txt_Re_Body
            // 
            this.txt_Re_Body.Location = new System.Drawing.Point(76, 329);
            this.txt_Re_Body.Multiline = true;
            this.txt_Re_Body.Name = "txt_Re_Body";
            this.txt_Re_Body.ReadOnly = true;
            this.txt_Re_Body.Size = new System.Drawing.Size(295, 206);
            this.txt_Re_Body.TabIndex = 13;
            this.txt_Re_Body.Visible = false;
            // 
            // lblRe_Date
            // 
            this.lblRe_Date.AutoSize = true;
            this.lblRe_Date.Location = new System.Drawing.Point(76, 303);
            this.lblRe_Date.Name = "lblRe_Date";
            this.lblRe_Date.Size = new System.Drawing.Size(57, 12);
            this.lblRe_Date.TabIndex = 14;
            this.lblRe_Date.Text = "답변 날짜";
            this.lblRe_Date.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(573, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            // 
            // FrmInsertInqury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 549);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRe_Date);
            this.Controls.Add(this.txt_Re_Body);
            this.Controls.Add(this.btnInsertInquire);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.picInquire);
            this.Controls.Add(this.lblReDate);
            this.Controls.Add(this.lblReBody);
            this.Controls.Add(this.lblInquireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInquireBody);
            this.Controls.Add(this.txtInquireTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInquireType);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertInqury";
            this.Text = "FrmInsertInqury";
            this.Load += new System.EventHandler(this.FrmInsertInqury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInquire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInquireType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInquireTitle;
        private System.Windows.Forms.TextBox txtInquireBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInquireDate;
        private System.Windows.Forms.Label lblReBody;
        private System.Windows.Forms.Label lblReDate;
        private System.Windows.Forms.PictureBox picInquire;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInsertInquire;
        private System.Windows.Forms.TextBox txt_Re_Body;
        private System.Windows.Forms.Label lblRe_Date;
        private System.Windows.Forms.Button btnClose;
    }
}