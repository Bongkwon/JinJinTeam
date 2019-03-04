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
            this.btnImgInsert = new System.Windows.Forms.Button();
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
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numStockCount = new System.Windows.Forms.NumericUpDown();
            this.btnInsertStock = new System.Windows.Forms.Button();
            this.openImg = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImgNo
            // 
            this.lblImgNo.AutoSize = true;
            this.lblImgNo.Location = new System.Drawing.Point(943, 335);
            this.lblImgNo.Name = "lblImgNo";
            this.lblImgNo.Size = new System.Drawing.Size(0, 12);
            this.lblImgNo.TabIndex = 38;
            // 
            // btnImgInsert
            // 
            this.btnImgInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnImgInsert.FlatAppearance.BorderSize = 0;
            this.btnImgInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgInsert.Location = new System.Drawing.Point(945, 307);
            this.btnImgInsert.Name = "btnImgInsert";
            this.btnImgInsert.Size = new System.Drawing.Size(86, 23);
            this.btnImgInsert.TabIndex = 37;
            this.btnImgInsert.Text = "이미지 등록";
            this.btnImgInsert.UseVisualStyleBackColor = false;
            this.btnImgInsert.Click += new System.EventHandler(this.btnImgInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "상품 이미지";
            // 
            // proPic
            // 
            this.proPic.Location = new System.Drawing.Point(559, 63);
            this.proPic.Name = "proPic";
            this.proPic.Size = new System.Drawing.Size(374, 272);
            this.proPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proPic.TabIndex = 35;
            this.proPic.TabStop = false;
            // 
            // cmbCatID
            // 
            this.cmbCatID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.cmbCatID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatID.FormattingEnabled = true;
            this.cmbCatID.Location = new System.Drawing.Point(286, 61);
            this.cmbCatID.Name = "cmbCatID";
            this.cmbCatID.Size = new System.Drawing.Size(100, 20);
            this.cmbCatID.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "성별";
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
            this.cmbGender.Location = new System.Drawing.Point(286, 87);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 20);
            this.cmbGender.TabIndex = 32;
            // 
            // txtSubComment
            // 
            this.txtSubComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.txtSubComment.Location = new System.Drawing.Point(559, 341);
            this.txtSubComment.Multiline = true;
            this.txtSubComment.Name = "txtSubComment";
            this.txtSubComment.Size = new System.Drawing.Size(374, 285);
            this.txtSubComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "세부정보";
            // 
            // txtMainComment
            // 
            this.txtMainComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.txtMainComment.Location = new System.Drawing.Point(92, 379);
            this.txtMainComment.Multiline = true;
            this.txtMainComment.Name = "txtMainComment";
            this.txtMainComment.Size = new System.Drawing.Size(387, 250);
            this.txtMainComment.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "주요정보";
            // 
            // txtProPrice
            // 
            this.txtProPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtProPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProPrice.Location = new System.Drawing.Point(92, 93);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(100, 14);
            this.txtProPrice.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "판매가";
            // 
            // txtProName
            // 
            this.txtProName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.txtProName.Location = new System.Drawing.Point(92, 186);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(387, 187);
            this.txtProName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "카테고리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "상품번호";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(945, 603);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "수정";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPro_No
            // 
            this.lblPro_No.AutoSize = true;
            this.lblPro_No.Location = new System.Drawing.Point(90, 66);
            this.lblPro_No.Name = "lblPro_No";
            this.lblPro_No.Size = new System.Drawing.Size(53, 12);
            this.lblPro_No.TabIndex = 39;
            this.lblPro_No.Text = "상품번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "할인율";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Location = new System.Drawing.Point(92, 122);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 14);
            this.txtDiscount.TabIndex = 41;
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.cmbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmbSize.Location = new System.Drawing.Point(92, 149);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(100, 20);
            this.cmbSize.TabIndex = 42;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "사이즈";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "재고";
            // 
            // numStockCount
            // 
            this.numStockCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.numStockCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numStockCount.Location = new System.Drawing.Point(286, 150);
            this.numStockCount.Name = "numStockCount";
            this.numStockCount.Size = new System.Drawing.Size(100, 17);
            this.numStockCount.TabIndex = 46;
            // 
            // btnInsertStock
            // 
            this.btnInsertStock.Location = new System.Drawing.Point(393, 149);
            this.btnInsertStock.Name = "btnInsertStock";
            this.btnInsertStock.Size = new System.Drawing.Size(86, 22);
            this.btnInsertStock.TabIndex = 47;
            this.btnInsertStock.Text = "사이즈 추가";
            this.btnInsertStock.UseVisualStyleBackColor = true;
            this.btnInsertStock.Click += new System.EventHandler(this.btnInsertStock_Click);
            // 
            // openImg
            // 
            this.openImg.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 55);
            this.panel1.TabIndex = 48;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 54);
            this.label12.TabIndex = 21;
            this.label12.Text = "JinTeam";
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
            this.button1.Location = new System.Drawing.Point(1000, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDetailPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1055, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInsertStock);
            this.Controls.Add(this.numStockCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPro_No);
            this.Controls.Add(this.lblImgNo);
            this.Controls.Add(this.btnImgInsert);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetailPro";
            this.Text = "FrmDetailPro";
            this.Load += new System.EventHandler(this.FrmDetailPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImgNo;
        private System.Windows.Forms.Button btnImgInsert;
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
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numStockCount;
        private System.Windows.Forms.Button btnInsertStock;
        private System.Windows.Forms.OpenFileDialog openImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
    }
}