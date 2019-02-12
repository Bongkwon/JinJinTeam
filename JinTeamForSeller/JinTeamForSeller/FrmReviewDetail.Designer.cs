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
            ((System.ComponentModel.ISupportInitialize)(this.picInquireImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.Location = new System.Drawing.Point(713, 393);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateReview.TabIndex = 34;
            this.btnUpdateReview.Text = "답글 달기";
            this.btnUpdateReview.UseVisualStyleBackColor = true;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // txtReBody
            // 
            this.txtReBody.Location = new System.Drawing.Point(13, 262);
            this.txtReBody.Multiline = true;
            this.txtReBody.Name = "txtReBody";
            this.txtReBody.Size = new System.Drawing.Size(423, 154);
            this.txtReBody.TabIndex = 33;
            // 
            // txtReviewBody
            // 
            this.txtReviewBody.Location = new System.Drawing.Point(14, 92);
            this.txtReviewBody.Multiline = true;
            this.txtReviewBody.Name = "txtReviewBody";
            this.txtReviewBody.ReadOnly = true;
            this.txtReviewBody.Size = new System.Drawing.Size(423, 152);
            this.txtReviewBody.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "답글 내용";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.Location = new System.Drawing.Point(230, 13);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(38, 12);
            this.lblReviewDate.TabIndex = 30;
            this.lblReviewDate.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "날짜";
            // 
            // lblReviewStockId
            // 
            this.lblReviewStockId.AutoSize = true;
            this.lblReviewStockId.Location = new System.Drawing.Point(76, 34);
            this.lblReviewStockId.Name = "lblReviewStockId";
            this.lblReviewStockId.Size = new System.Drawing.Size(38, 12);
            this.lblReviewStockId.TabIndex = 27;
            this.lblReviewStockId.Text = "label8";
            // 
            // lblReviewCusName
            // 
            this.lblReviewCusName.AutoSize = true;
            this.lblReviewCusName.Location = new System.Drawing.Point(76, 13);
            this.lblReviewCusName.Name = "lblReviewCusName";
            this.lblReviewCusName.Size = new System.Drawing.Size(38, 12);
            this.lblReviewCusName.TabIndex = 26;
            this.lblReviewCusName.Text = "label7";
            // 
            // picInquireImg
            // 
            this.picInquireImg.Location = new System.Drawing.Point(443, 92);
            this.picInquireImg.Name = "picInquireImg";
            this.picInquireImg.Size = new System.Drawing.Size(346, 295);
            this.picInquireImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInquireImg.TabIndex = 24;
            this.picInquireImg.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "리뷰 내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "상품 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "고객명";
            // 
            // FrmReviewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmReviewDetail";
            this.Text = "FrmReviewDetail";
            this.Load += new System.EventHandler(this.FrmReviewDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInquireImg)).EndInit();
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
    }
}