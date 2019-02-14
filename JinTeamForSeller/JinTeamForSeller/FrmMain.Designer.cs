namespace JinTeamForSeller
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnInqury = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSellAndTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 202);
            this.button1.TabIndex = 0;
            this.button1.Text = "상품관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInqury
            // 
            this.btnInqury.Location = new System.Drawing.Point(243, 12);
            this.btnInqury.Name = "btnInqury";
            this.btnInqury.Size = new System.Drawing.Size(225, 202);
            this.btnInqury.TabIndex = 1;
            this.btnInqury.Text = "문의관리";
            this.btnInqury.UseVisualStyleBackColor = true;
            this.btnInqury.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 202);
            this.button3.TabIndex = 2;
            this.button3.Text = "매출관리";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 202);
            this.button4.TabIndex = 3;
            this.button4.Text = "정보수정";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSellAndTrans
            // 
            this.btnSellAndTrans.Location = new System.Drawing.Point(474, 12);
            this.btnSellAndTrans.Name = "btnSellAndTrans";
            this.btnSellAndTrans.Size = new System.Drawing.Size(225, 202);
            this.btnSellAndTrans.TabIndex = 4;
            this.btnSellAndTrans.Text = "판매 / 배송 관리";
            this.btnSellAndTrans.UseVisualStyleBackColor = true;
            this.btnSellAndTrans.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 425);
            this.Controls.Add(this.btnSellAndTrans);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInqury);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInqury;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSellAndTrans;
    }
}