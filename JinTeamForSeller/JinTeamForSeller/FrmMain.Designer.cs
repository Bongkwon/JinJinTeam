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
            this.btnSaleManagement = new System.Windows.Forms.Button();
            this.btnSellAndTrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(50, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "상품관리";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInqury
            // 
            this.btnInqury.BackColor = System.Drawing.Color.Gray;
            this.btnInqury.Location = new System.Drawing.Point(279, 86);
            this.btnInqury.Margin = new System.Windows.Forms.Padding(0);
            this.btnInqury.Name = "btnInqury";
            this.btnInqury.Size = new System.Drawing.Size(147, 137);
            this.btnInqury.TabIndex = 1;
            this.btnInqury.Text = "문의관리";
            this.btnInqury.UseVisualStyleBackColor = false;
            this.btnInqury.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaleManagement
            // 
            this.btnSaleManagement.BackColor = System.Drawing.Color.Gray;
            this.btnSaleManagement.Location = new System.Drawing.Point(50, 270);
            this.btnSaleManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaleManagement.Name = "btnSaleManagement";
            this.btnSaleManagement.Size = new System.Drawing.Size(147, 137);
            this.btnSaleManagement.TabIndex = 2;
            this.btnSaleManagement.Text = "매출관리";
            this.btnSaleManagement.UseVisualStyleBackColor = false;
            this.btnSaleManagement.Click += new System.EventHandler(this.btnSaleManagement_Click);
            // 
            // btnSellAndTrans
            // 
            this.btnSellAndTrans.BackColor = System.Drawing.Color.Gray;
            this.btnSellAndTrans.Location = new System.Drawing.Point(279, 270);
            this.btnSellAndTrans.Margin = new System.Windows.Forms.Padding(0);
            this.btnSellAndTrans.Name = "btnSellAndTrans";
            this.btnSellAndTrans.Size = new System.Drawing.Size(147, 137);
            this.btnSellAndTrans.TabIndex = 4;
            this.btnSellAndTrans.Text = "판매 / 배송 관리";
            this.btnSellAndTrans.UseVisualStyleBackColor = false;
            this.btnSellAndTrans.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(175)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 63);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(175)))), ((int)(((byte)(178)))));
            this.btnClose.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(424, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(480, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSellAndTrans);
            this.Controls.Add(this.btnSaleManagement);
            this.Controls.Add(this.btnInqury);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "메인메뉴";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInqury;
        private System.Windows.Forms.Button btnSaleManagement;
        private System.Windows.Forms.Button btnSellAndTrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}