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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInquire)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "문의 구분";
            // 
            // cmbInquireType
            // 
            this.cmbInquireType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.cmbInquireType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInquireType.FormattingEnabled = true;
            this.cmbInquireType.Items.AddRange(new object[] {
            "피드백",
            "사용문의",
            "회원문의",
            "기타",
            "시스템",
            "결제문의"});
            this.cmbInquireType.Location = new System.Drawing.Point(73, 89);
            this.cmbInquireType.Name = "cmbInquireType";
            this.cmbInquireType.Size = new System.Drawing.Size(121, 20);
            this.cmbInquireType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "문의 제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "문의 내용";
            // 
            // txtInquireTitle
            // 
            this.txtInquireTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtInquireTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInquireTitle.Location = new System.Drawing.Point(73, 115);
            this.txtInquireTitle.Name = "txtInquireTitle";
            this.txtInquireTitle.Size = new System.Drawing.Size(296, 14);
            this.txtInquireTitle.TabIndex = 4;
            // 
            // txtInquireBody
            // 
            this.txtInquireBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtInquireBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInquireBody.Location = new System.Drawing.Point(73, 142);
            this.txtInquireBody.Multiline = true;
            this.txtInquireBody.Name = "txtInquireBody";
            this.txtInquireBody.Size = new System.Drawing.Size(296, 208);
            this.txtInquireBody.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "문의 날짜";
            // 
            // lblInquireDate
            // 
            this.lblInquireDate.AutoSize = true;
            this.lblInquireDate.Location = new System.Drawing.Point(282, 92);
            this.lblInquireDate.Name = "lblInquireDate";
            this.lblInquireDate.Size = new System.Drawing.Size(0, 12);
            this.lblInquireDate.TabIndex = 7;
            // 
            // lblReBody
            // 
            this.lblReBody.AutoSize = true;
            this.lblReBody.Location = new System.Drawing.Point(10, 411);
            this.lblReBody.Name = "lblReBody";
            this.lblReBody.Size = new System.Drawing.Size(57, 12);
            this.lblReBody.TabIndex = 8;
            this.lblReBody.Text = "문의 답글";
            this.lblReBody.Visible = false;
            // 
            // lblReDate
            // 
            this.lblReDate.AutoSize = true;
            this.lblReDate.Location = new System.Drawing.Point(10, 382);
            this.lblReDate.Name = "lblReDate";
            this.lblReDate.Size = new System.Drawing.Size(57, 12);
            this.lblReDate.TabIndex = 9;
            this.lblReDate.Text = "답변 날짜";
            this.lblReDate.Visible = false;
            // 
            // picInquire
            // 
            this.picInquire.Location = new System.Drawing.Point(394, 115);
            this.picInquire.Name = "picInquire";
            this.picInquire.Size = new System.Drawing.Size(271, 235);
            this.picInquire.TabIndex = 10;
            this.picInquire.TabStop = false;
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnInsertImg.FlatAppearance.BorderSize = 0;
            this.btnInsertImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnInsertImg.Location = new System.Drawing.Point(567, 89);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(98, 23);
            this.btnInsertImg.TabIndex = 11;
            this.btnInsertImg.Text = "이미지 첨부";
            this.btnInsertImg.UseVisualStyleBackColor = false;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInsertInquire
            // 
            this.btnInsertInquire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnInsertInquire.FlatAppearance.BorderSize = 0;
            this.btnInsertInquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInquire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnInsertInquire.Location = new System.Drawing.Point(570, 356);
            this.btnInsertInquire.Name = "btnInsertInquire";
            this.btnInsertInquire.Size = new System.Drawing.Size(95, 23);
            this.btnInsertInquire.TabIndex = 12;
            this.btnInsertInquire.Text = "문의 남기기";
            this.btnInsertInquire.UseVisualStyleBackColor = false;
            this.btnInsertInquire.Click += new System.EventHandler(this.btnInsertInquire_Click);
            // 
            // txt_Re_Body
            // 
            this.txt_Re_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txt_Re_Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Re_Body.Enabled = false;
            this.txt_Re_Body.Location = new System.Drawing.Point(73, 408);
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
            this.lblRe_Date.Location = new System.Drawing.Point(73, 382);
            this.lblRe_Date.Name = "lblRe_Date";
            this.lblRe_Date.Size = new System.Drawing.Size(57, 12);
            this.lblRe_Date.TabIndex = 14;
            this.lblRe_Date.Text = "답변 날짜";
            this.lblRe_Date.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnClose.Location = new System.Drawing.Point(570, 593);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 72);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 54);
            this.label6.TabIndex = 22;
            this.label6.Text = "문의 남기기";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button1.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(619, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInsertInqury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(683, 626);
            this.Controls.Add(this.panel1);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertInqury";
            this.Text = "FrmInsertInqury";
            this.Load += new System.EventHandler(this.FrmInsertInqury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInquire)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}