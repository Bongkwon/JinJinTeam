﻿namespace JinTeamForSeller
{
    partial class FrmInsertProduct
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMainComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCatID = new System.Windows.Forms.ComboBox();
            this.proPic = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.lblImgNo = new System.Windows.Forms.Label();
            this.openImg = new System.Windows.Forms.OpenFileDialog();
            this.chkSizeS = new System.Windows.Forms.CheckBox();
            this.chkSizeM = new System.Windows.Forms.CheckBox();
            this.chkSizeL = new System.Windows.Forms.CheckBox();
            this.chkSizeXL = new System.Windows.Forms.CheckBox();
            this.chkSizeXXL = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numStockCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품번호";
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(85, 12);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(100, 21);
            this.txtProID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "카테고리";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(85, 98);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(387, 187);
            this.txtProName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "상품명";
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(85, 42);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(100, 21);
            this.txtProPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "판매가";
            // 
            // txtMainComment
            // 
            this.txtMainComment.Location = new System.Drawing.Point(85, 291);
            this.txtMainComment.Multiline = true;
            this.txtMainComment.Name = "txtMainComment";
            this.txtMainComment.Size = new System.Drawing.Size(387, 250);
            this.txtMainComment.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "주요정보";
            // 
            // txtSubComment
            // 
            this.txtSubComment.Location = new System.Drawing.Point(582, 291);
            this.txtSubComment.Multiline = true;
            this.txtSubComment.Name = "txtSubComment";
            this.txtSubComment.Size = new System.Drawing.Size(374, 250);
            this.txtSubComment.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "세부정보";
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
            this.cmbGender.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "성별";
            // 
            // cmbCatID
            // 
            this.cmbCatID.FormattingEnabled = true;
            this.cmbCatID.Location = new System.Drawing.Point(372, 13);
            this.cmbCatID.Name = "cmbCatID";
            this.cmbCatID.Size = new System.Drawing.Size(100, 20);
            this.cmbCatID.TabIndex = 15;
            // 
            // proPic
            // 
            this.proPic.Location = new System.Drawing.Point(582, 42);
            this.proPic.Name = "proPic";
            this.proPic.Size = new System.Drawing.Size(374, 244);
            this.proPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proPic.TabIndex = 16;
            this.proPic.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "상품 이미지";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(968, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "이미지 등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgLst
            // 
            this.imgLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblImgNo
            // 
            this.lblImgNo.AutoSize = true;
            this.lblImgNo.Location = new System.Drawing.Point(966, 247);
            this.lblImgNo.Name = "lblImgNo";
            this.lblImgNo.Size = new System.Drawing.Size(0, 12);
            this.lblImgNo.TabIndex = 19;
            // 
            // openImg
            // 
            this.openImg.FileName = "openFileDialog1";
            this.openImg.Filter = "이미지파일 | *.jpg |gif파일 |*.gif | png파일 | *.png |모든 파일 |*.*";
            // 
            // chkSizeS
            // 
            this.chkSizeS.AutoSize = true;
            this.chkSizeS.Location = new System.Drawing.Point(85, 69);
            this.chkSizeS.Name = "chkSizeS";
            this.chkSizeS.Size = new System.Drawing.Size(32, 16);
            this.chkSizeS.TabIndex = 20;
            this.chkSizeS.Text = "S";
            this.chkSizeS.UseVisualStyleBackColor = true;
            // 
            // chkSizeM
            // 
            this.chkSizeM.AutoSize = true;
            this.chkSizeM.Location = new System.Drawing.Point(123, 69);
            this.chkSizeM.Name = "chkSizeM";
            this.chkSizeM.Size = new System.Drawing.Size(35, 16);
            this.chkSizeM.TabIndex = 21;
            this.chkSizeM.Text = "M";
            this.chkSizeM.UseVisualStyleBackColor = true;
            // 
            // chkSizeL
            // 
            this.chkSizeL.AutoSize = true;
            this.chkSizeL.Location = new System.Drawing.Point(164, 69);
            this.chkSizeL.Name = "chkSizeL";
            this.chkSizeL.Size = new System.Drawing.Size(31, 16);
            this.chkSizeL.TabIndex = 22;
            this.chkSizeL.Text = "L";
            this.chkSizeL.UseVisualStyleBackColor = true;
            // 
            // chkSizeXL
            // 
            this.chkSizeXL.AutoSize = true;
            this.chkSizeXL.Location = new System.Drawing.Point(205, 69);
            this.chkSizeXL.Name = "chkSizeXL";
            this.chkSizeXL.Size = new System.Drawing.Size(39, 16);
            this.chkSizeXL.TabIndex = 23;
            this.chkSizeXL.Text = "XL";
            this.chkSizeXL.UseVisualStyleBackColor = true;
            // 
            // chkSizeXXL
            // 
            this.chkSizeXXL.AutoSize = true;
            this.chkSizeXXL.Location = new System.Drawing.Point(246, 69);
            this.chkSizeXXL.Name = "chkSizeXXL";
            this.chkSizeXXL.Size = new System.Drawing.Size(47, 16);
            this.chkSizeXXL.TabIndex = 24;
            this.chkSizeXXL.Text = "XXL";
            this.chkSizeXXL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "사이즈 선택";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "수량";
            // 
            // numStockCount
            // 
            this.numStockCount.Location = new System.Drawing.Point(372, 70);
            this.numStockCount.Name = "numStockCount";
            this.numStockCount.Size = new System.Drawing.Size(100, 21);
            this.numStockCount.TabIndex = 27;
            // 
            // FrmInsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.numStockCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkSizeXXL);
            this.Controls.Add(this.chkSizeXL);
            this.Controls.Add(this.chkSizeL);
            this.Controls.Add(this.chkSizeM);
            this.Controls.Add(this.chkSizeS);
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
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmInsertProduct";
            this.Text = "FrmInsertProduct";
            this.Load += new System.EventHandler(this.FrmInsertProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMainComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCatID;
        private System.Windows.Forms.PictureBox proPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.Label lblImgNo;
        private System.Windows.Forms.OpenFileDialog openImg;
        private System.Windows.Forms.CheckBox chkSizeS;
        private System.Windows.Forms.CheckBox chkSizeM;
        private System.Windows.Forms.CheckBox chkSizeL;
        private System.Windows.Forms.CheckBox chkSizeXL;
        private System.Windows.Forms.CheckBox chkSizeXXL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numStockCount;
    }
}