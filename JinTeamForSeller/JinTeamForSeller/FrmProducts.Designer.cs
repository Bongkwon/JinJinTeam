namespace JinTeamForSeller
{
    partial class FrmProducts
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
            this.gViewProducts = new System.Windows.Forms.DataGridView();
            this.btnInsertPro = new System.Windows.Forms.Button();
            this.btnUpdatePro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnManagePro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewProducts
            // 
            this.gViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewProducts.Location = new System.Drawing.Point(13, 13);
            this.gViewProducts.Name = "gViewProducts";
            this.gViewProducts.RowTemplate.Height = 23;
            this.gViewProducts.Size = new System.Drawing.Size(775, 368);
            this.gViewProducts.TabIndex = 0;
            this.gViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewProducts_CellContentClick);
            // 
            // btnInsertPro
            // 
            this.btnInsertPro.Location = new System.Drawing.Point(13, 387);
            this.btnInsertPro.Name = "btnInsertPro";
            this.btnInsertPro.Size = new System.Drawing.Size(150, 50);
            this.btnInsertPro.TabIndex = 1;
            this.btnInsertPro.Text = "상품 등록";
            this.btnInsertPro.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePro
            // 
            this.btnUpdatePro.Location = new System.Drawing.Point(169, 387);
            this.btnUpdatePro.Name = "btnUpdatePro";
            this.btnUpdatePro.Size = new System.Drawing.Size(150, 50);
            this.btnUpdatePro.TabIndex = 2;
            this.btnUpdatePro.Text = "상품 수정";
            this.btnUpdatePro.UseVisualStyleBackColor = true;
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.Location = new System.Drawing.Point(326, 387);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(150, 50);
            this.btnDeletePro.TabIndex = 3;
            this.btnDeletePro.Text = "상품 삭제";
            this.btnDeletePro.UseVisualStyleBackColor = true;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(638, 387);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(150, 50);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "뒤로가기";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // btnManagePro
            // 
            this.btnManagePro.Location = new System.Drawing.Point(482, 387);
            this.btnManagePro.Name = "btnManagePro";
            this.btnManagePro.Size = new System.Drawing.Size(150, 50);
            this.btnManagePro.TabIndex = 6;
            this.btnManagePro.Text = "상품 판매 / 배송 관리";
            this.btnManagePro.UseVisualStyleBackColor = true;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 443);
            this.Controls.Add(this.btnManagePro);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnUpdatePro);
            this.Controls.Add(this.btnInsertPro);
            this.Controls.Add(this.gViewProducts);
            this.Name = "FrmProducts";
            this.Text = "상품 관리";
            ((System.ComponentModel.ISupportInitialize)(this.gViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gViewProducts;
        private System.Windows.Forms.Button btnInsertPro;
        private System.Windows.Forms.Button btnUpdatePro;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnManagePro;
    }
}