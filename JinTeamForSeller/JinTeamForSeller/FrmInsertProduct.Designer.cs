namespace JinTeamForSeller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.button1.Location = new System.Drawing.Point(983, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품번호";
            // 
            // txtProID
            // 
            this.txtProID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtProID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProID.Location = new System.Drawing.Point(85, 77);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(100, 14);
            this.txtProID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "카테고리";
            // 
            // txtProName
            // 
            this.txtProName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtProName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProName.Location = new System.Drawing.Point(85, 163);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(387, 187);
            this.txtProName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "상품명";
            // 
            // txtProPrice
            // 
            this.txtProPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtProPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProPrice.Location = new System.Drawing.Point(85, 107);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(100, 14);
            this.txtProPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "판매가";
            // 
            // txtMainComment
            // 
            this.txtMainComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtMainComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMainComment.Location = new System.Drawing.Point(85, 356);
            this.txtMainComment.Multiline = true;
            this.txtMainComment.Name = "txtMainComment";
            this.txtMainComment.Size = new System.Drawing.Size(387, 250);
            this.txtMainComment.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "주요정보";
            // 
            // txtSubComment
            // 
            this.txtSubComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtSubComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubComment.Location = new System.Drawing.Point(582, 356);
            this.txtSubComment.Multiline = true;
            this.txtSubComment.Name = "txtSubComment";
            this.txtSubComment.Size = new System.Drawing.Size(374, 250);
            this.txtSubComment.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "세부정보";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F",
            "A"});
            this.cmbGender.Location = new System.Drawing.Point(372, 108);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 20);
            this.cmbGender.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "성별";
            // 
            // cmbCatID
            // 
            this.cmbCatID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.cmbCatID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatID.FormattingEnabled = true;
            this.cmbCatID.Location = new System.Drawing.Point(372, 78);
            this.cmbCatID.Name = "cmbCatID";
            this.cmbCatID.Size = new System.Drawing.Size(100, 20);
            this.cmbCatID.TabIndex = 15;
            // 
            // proPic
            // 
            this.proPic.Location = new System.Drawing.Point(582, 107);
            this.proPic.Name = "proPic";
            this.proPic.Size = new System.Drawing.Size(374, 244);
            this.proPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proPic.TabIndex = 16;
            this.proPic.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "상품 이미지";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.button2.Location = new System.Drawing.Point(968, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "이미지 등록";
            this.button2.UseVisualStyleBackColor = false;
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
            this.lblImgNo.Location = new System.Drawing.Point(966, 312);
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
            this.chkSizeS.Location = new System.Drawing.Point(85, 134);
            this.chkSizeS.Name = "chkSizeS";
            this.chkSizeS.Size = new System.Drawing.Size(32, 16);
            this.chkSizeS.TabIndex = 20;
            this.chkSizeS.Text = "S";
            this.chkSizeS.UseVisualStyleBackColor = true;
            // 
            // chkSizeM
            // 
            this.chkSizeM.AutoSize = true;
            this.chkSizeM.Location = new System.Drawing.Point(123, 134);
            this.chkSizeM.Name = "chkSizeM";
            this.chkSizeM.Size = new System.Drawing.Size(35, 16);
            this.chkSizeM.TabIndex = 21;
            this.chkSizeM.Text = "M";
            this.chkSizeM.UseVisualStyleBackColor = true;
            // 
            // chkSizeL
            // 
            this.chkSizeL.AutoSize = true;
            this.chkSizeL.Location = new System.Drawing.Point(164, 134);
            this.chkSizeL.Name = "chkSizeL";
            this.chkSizeL.Size = new System.Drawing.Size(31, 16);
            this.chkSizeL.TabIndex = 22;
            this.chkSizeL.Text = "L";
            this.chkSizeL.UseVisualStyleBackColor = true;
            // 
            // chkSizeXL
            // 
            this.chkSizeXL.AutoSize = true;
            this.chkSizeXL.Location = new System.Drawing.Point(205, 134);
            this.chkSizeXL.Name = "chkSizeXL";
            this.chkSizeXL.Size = new System.Drawing.Size(39, 16);
            this.chkSizeXL.TabIndex = 23;
            this.chkSizeXL.Text = "XL";
            this.chkSizeXL.UseVisualStyleBackColor = true;
            // 
            // chkSizeXXL
            // 
            this.chkSizeXXL.AutoSize = true;
            this.chkSizeXXL.Location = new System.Drawing.Point(246, 134);
            this.chkSizeXXL.Name = "chkSizeXXL";
            this.chkSizeXXL.Size = new System.Drawing.Size(47, 16);
            this.chkSizeXXL.TabIndex = 24;
            this.chkSizeXXL.Text = "XXL";
            this.chkSizeXXL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "사이즈 선택";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "수량";
            // 
            // numStockCount
            // 
            this.numStockCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.numStockCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numStockCount.Location = new System.Drawing.Point(372, 135);
            this.numStockCount.Name = "numStockCount";
            this.numStockCount.Size = new System.Drawing.Size(100, 17);
            this.numStockCount.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 72);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button3.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1006, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 49);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 54);
            this.label11.TabIndex = 22;
            this.label11.Text = "JinTeam";
            // 
            // FrmInsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1070, 653);
            this.Controls.Add(this.panel1);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertProduct";
            this.Text = "FrmInsertProduct";
            this.Load += new System.EventHandler(this.FrmInsertProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}