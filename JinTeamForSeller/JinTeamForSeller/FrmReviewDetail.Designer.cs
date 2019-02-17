namespace JinTeamForSeller
{
    partial class FrmReviewDetail
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
            this.btnUpdateReview = new System.Windows.Forms.Button();
            this.txtReBody = new System.Windows.Forms.TextBox();
            this.txtReviewBody = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReviewStockId = new System.Windows.Forms.Label();
            this.lblReviewCusName = new System.Windows.Forms.Label();
            this.picInquireImg = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picInquireImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnUpdateReview.FlatAppearance.BorderSize = 0;
            this.btnUpdateReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReview.Location = new System.Drawing.Point(711, 465);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateReview.TabIndex = 34;
            this.btnUpdateReview.Text = "답글 달기";
            this.btnUpdateReview.UseVisualStyleBackColor = false;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // txtReBody
            // 
            this.txtReBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtReBody.Location = new System.Drawing.Point(11, 334);
            this.txtReBody.Multiline = true;
            this.txtReBody.Name = "txtReBody";
            this.txtReBody.Size = new System.Drawing.Size(423, 154);
            this.txtReBody.TabIndex = 33;
            // 
            // txtReviewBody
            // 
            this.txtReviewBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtReviewBody.Location = new System.Drawing.Point(12, 164);
            this.txtReviewBody.Multiline = true;
            this.txtReviewBody.Name = "txtReviewBody";
            this.txtReviewBody.ReadOnly = true;
            this.txtReviewBody.Size = new System.Drawing.Size(423, 152);
            this.txtReviewBody.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "답글 내용";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.Location = new System.Drawing.Point(228, 85);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(38, 12);
            this.lblReviewDate.TabIndex = 30;
            this.lblReviewDate.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "날짜";
            // 
            // lblReviewStockId
            // 
            this.lblReviewStockId.AutoSize = true;
            this.lblReviewStockId.Location = new System.Drawing.Point(74, 106);
            this.lblReviewStockId.Name = "lblReviewStockId";
            this.lblReviewStockId.Size = new System.Drawing.Size(38, 12);
            this.lblReviewStockId.TabIndex = 27;
            this.lblReviewStockId.Text = "label8";
            // 
            // lblReviewCusName
            // 
            this.lblReviewCusName.AutoSize = true;
            this.lblReviewCusName.Location = new System.Drawing.Point(74, 85);
            this.lblReviewCusName.Name = "lblReviewCusName";
            this.lblReviewCusName.Size = new System.Drawing.Size(38, 12);
            this.lblReviewCusName.TabIndex = 26;
            this.lblReviewCusName.Text = "label7";
            // 
            // picInquireImg
            // 
            this.picInquireImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.picInquireImg.Location = new System.Drawing.Point(441, 164);
            this.picInquireImg.Name = "picInquireImg";
            this.picInquireImg.Size = new System.Drawing.Size(346, 295);
            this.picInquireImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInquireImg.TabIndex = 24;
            this.picInquireImg.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "리뷰 내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "상품 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "고객명";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button1.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(736, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button3.Location = new System.Drawing.Point(871, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 49);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 54);
            this.label6.TabIndex = 36;
            this.label6.Text = "JinTeam";
            // 
            // FrmReviewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateReview);
            this.Controls.Add(this.txtReBody);
            this.Controls.Add(this.txtReviewBody);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblReviewDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblReviewStockId);
            this.Controls.Add(this.lblReviewCusName);
            this.Controls.Add(this.picInquireImg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReviewDetail";
            this.Text = "FrmReviewDetail";
            this.Load += new System.EventHandler(this.FrmReviewDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInquireImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateReview;
        private System.Windows.Forms.TextBox txtReBody;
        private System.Windows.Forms.TextBox txtReviewBody;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReviewStockId;
        private System.Windows.Forms.Label lblReviewCusName;
        private System.Windows.Forms.PictureBox picInquireImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}