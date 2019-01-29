namespace JinTeamForSeller
{
    partial class FrmDetailPro
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
            this.lblImgNo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.proPic = new System.Windows.Forms.PictureBox();
            this.cmbCatID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtSubComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMainComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPro_No = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImgNo
            // 
            this.lblImgNo.AutoSize = true;
            this.lblImgNo.Location = new System.Drawing.Point(970, 218);
            this.lblImgNo.Name = "lblImgNo";
            this.lblImgNo.Size = new System.Drawing.Size(0, 12);
            this.lblImgNo.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(972, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "이미지 등록";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "상품 이미지";
            // 
            // proPic
            // 
            this.proPic.Location = new System.Drawing.Point(586, 13);
            this.proPic.Name = "proPic";
            this.proPic.Size = new System.Drawing.Size(374, 272);
            this.proPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proPic.TabIndex = 35;
            this.proPic.TabStop = false;
            // 
            // cmbCatID
            // 
            this.cmbCatID.FormattingEnabled = true;
            this.cmbCatID.Location = new System.Drawing.Point(372, 13);
            this.cmbCatID.Name = "cmbCatID";
            this.cmbCatID.Size = new System.Drawing.Size(100, 20);
            this.cmbCatID.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "성별";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F",
            "A"});
            this.cmbGender.Location = new System.Drawing.Point(372, 43);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 20);
            this.cmbGender.TabIndex = 32;
            // 
            // txtSubComment
            // 
            this.txtSubComment.Location = new System.Drawing.Point(586, 291);
            this.txtSubComment.Multiline = true;
            this.txtSubComment.Name = "txtSubComment";
            this.txtSubComment.Size = new System.Drawing.Size(374, 250);
            this.txtSubComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "세부정보";
            // 
            // txtMainComment
            // 
            this.txtMainComment.Location = new System.Drawing.Point(85, 291);
            this.txtMainComment.Multiline = true;
            this.txtMainComment.Name = "txtMainComment";
            this.txtMainComment.Size = new System.Drawing.Size(387, 250);
            this.txtMainComment.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "주요정보";
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(85, 42);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(100, 21);
            this.txtProPrice.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "판매가";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(85, 98);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(387, 187);
            this.txtProName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "카테고리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "상품번호";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(983, 518);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "수정";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPro_No
            // 
            this.lblPro_No.AutoSize = true;
            this.lblPro_No.Location = new System.Drawing.Point(83, 15);
            this.lblPro_No.Name = "lblPro_No";
            this.lblPro_No.Size = new System.Drawing.Size(53, 12);
            this.lblPro_No.TabIndex = 39;
            this.lblPro_No.Text = "상품번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "할인율";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(85, 71);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 21);
            this.txtDiscount.TabIndex = 41;
            // 
            // FrmDetailPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPro_No);
            this.Controls.Add(this.lblImgNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proPic);
            this.Controls.Add(this.cmbCatID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSubComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMainComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "FrmDetailPro";
            this.Text = "FrmDetailPro";
            this.Load += new System.EventHandler(this.FrmDetailPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImgNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox proPic;
        private System.Windows.Forms.ComboBox cmbCatID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtSubComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMainComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPro_No;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}