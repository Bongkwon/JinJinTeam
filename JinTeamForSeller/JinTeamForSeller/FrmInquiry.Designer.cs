namespace JinTeamForSeller
{
    partial class FrmInquiry
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
            this.rdoInquryOfProduct = new System.Windows.Forms.RadioButton();
            this.rdoReviewForPro = new System.Windows.Forms.RadioButton();
            this.rdoInquireToSys = new System.Windows.Forms.RadioButton();
            this.gViewInquiry = new System.Windows.Forms.DataGridView();
            this.btnInsertInquiry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoInquryOfProduct
            // 
            this.rdoInquryOfProduct.AutoSize = true;
            this.rdoInquryOfProduct.Checked = true;
            this.rdoInquryOfProduct.Location = new System.Drawing.Point(13, 13);
            this.rdoInquryOfProduct.Name = "rdoInquryOfProduct";
            this.rdoInquryOfProduct.Size = new System.Drawing.Size(75, 16);
            this.rdoInquryOfProduct.TabIndex = 0;
            this.rdoInquryOfProduct.TabStop = true;
            this.rdoInquryOfProduct.Text = "상품 문의";
            this.rdoInquryOfProduct.UseVisualStyleBackColor = true;
            this.rdoInquryOfProduct.CheckedChanged += new System.EventHandler(this.rdoInquryOfProduct_CheckedChanged);
            // 
            // rdoReviewForPro
            // 
            this.rdoReviewForPro.AutoSize = true;
            this.rdoReviewForPro.Location = new System.Drawing.Point(122, 12);
            this.rdoReviewForPro.Name = "rdoReviewForPro";
            this.rdoReviewForPro.Size = new System.Drawing.Size(75, 16);
            this.rdoReviewForPro.TabIndex = 1;
            this.rdoReviewForPro.Text = "상품 리뷰";
            this.rdoReviewForPro.UseVisualStyleBackColor = true;
            this.rdoReviewForPro.CheckedChanged += new System.EventHandler(this.rdoReviewForPro_CheckedChanged);
            // 
            // rdoInquireToSys
            // 
            this.rdoInquireToSys.AutoSize = true;
            this.rdoInquireToSys.Location = new System.Drawing.Point(231, 13);
            this.rdoInquireToSys.Name = "rdoInquireToSys";
            this.rdoInquireToSys.Size = new System.Drawing.Size(161, 16);
            this.rdoInquireToSys.TabIndex = 2;
            this.rdoInquireToSys.Text = "관리자에게 문의 / 피드백";
            this.rdoInquireToSys.UseVisualStyleBackColor = true;
            this.rdoInquireToSys.CheckedChanged += new System.EventHandler(this.rdoInquireToSys_CheckedChanged);
            // 
            // gViewInquiry
            // 
            this.gViewInquiry.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gViewInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewInquiry.GridColor = System.Drawing.SystemColors.Control;
            this.gViewInquiry.Location = new System.Drawing.Point(13, 36);
            this.gViewInquiry.MultiSelect = false;
            this.gViewInquiry.Name = "gViewInquiry";
            this.gViewInquiry.ReadOnly = true;
            this.gViewInquiry.RowTemplate.Height = 23;
            this.gViewInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewInquiry.Size = new System.Drawing.Size(1130, 402);
            this.gViewInquiry.TabIndex = 3;
            this.gViewInquiry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewInquiry_CellDoubleClick);
            // 
            // btnInsertInquiry
            // 
            this.btnInsertInquiry.Location = new System.Drawing.Point(943, 5);
            this.btnInsertInquiry.Name = "btnInsertInquiry";
            this.btnInsertInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnInsertInquiry.TabIndex = 4;
            this.btnInsertInquiry.Text = "문의하기";
            this.btnInsertInquiry.UseVisualStyleBackColor = true;
            this.btnInsertInquiry.Visible = false;
            this.btnInsertInquiry.Click += new System.EventHandler(this.btnInsertInquiry_Click);
            // 
            // FrmInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.btnInsertInquiry);
            this.Controls.Add(this.gViewInquiry);
            this.Controls.Add(this.rdoInquireToSys);
            this.Controls.Add(this.rdoReviewForPro);
            this.Controls.Add(this.rdoInquryOfProduct);
            this.Name = "FrmInquiry";
            this.Text = "FrmInquiry";
            this.Load += new System.EventHandler(this.FrmInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewInquiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoInquryOfProduct;
        private System.Windows.Forms.RadioButton rdoReviewForPro;
        private System.Windows.Forms.RadioButton rdoInquireToSys;
        private System.Windows.Forms.DataGridView gViewInquiry;
        private System.Windows.Forms.Button btnInsertInquiry;
    }
}