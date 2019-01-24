namespace JinTeamForSeller.Bus
{
    partial class Admin_main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdo_all_cus = new System.Windows.Forms.RadioButton();
            this.btn_seller_List = new System.Windows.Forms.Button();
            this.btn_cus_List = new System.Windows.Forms.Button();
            this.rdo_deactive_cus = new System.Windows.Forms.RadioButton();
            this.btn_pro_List = new System.Windows.Forms.Button();
            this.rdo_deactive_pro = new System.Windows.Forms.RadioButton();
            this.rdo_all_pro = new System.Windows.Forms.RadioButton();
            this.rdo_deactive_seller = new System.Windows.Forms.RadioButton();
            this.rdo_all_seller = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(964, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdo_all_cus
            // 
            this.rdo_all_cus.AutoSize = true;
            this.rdo_all_cus.Location = new System.Drawing.Point(121, 39);
            this.rdo_all_cus.Name = "rdo_all_cus";
            this.rdo_all_cus.Size = new System.Drawing.Size(75, 16);
            this.rdo_all_cus.TabIndex = 2;
            this.rdo_all_cus.TabStop = true;
            this.rdo_all_cus.Text = "전체 회원";
            this.rdo_all_cus.UseVisualStyleBackColor = true;
            this.rdo_all_cus.Visible = false;
            // 
            // btn_seller_List
            // 
            this.btn_seller_List.Location = new System.Drawing.Point(12, 7);
            this.btn_seller_List.Name = "btn_seller_List";
            this.btn_seller_List.Size = new System.Drawing.Size(100, 23);
            this.btn_seller_List.TabIndex = 3;
            this.btn_seller_List.Text = "seller목록";
            this.btn_seller_List.UseVisualStyleBackColor = true;
            this.btn_seller_List.Click += new System.EventHandler(this.btn_seller_List_Click);
            // 
            // btn_cus_List
            // 
            this.btn_cus_List.Location = new System.Drawing.Point(12, 36);
            this.btn_cus_List.Name = "btn_cus_List";
            this.btn_cus_List.Size = new System.Drawing.Size(100, 23);
            this.btn_cus_List.TabIndex = 4;
            this.btn_cus_List.Text = "customers목록";
            this.btn_cus_List.UseVisualStyleBackColor = true;
            // 
            // rdo_deactive_cus
            // 
            this.rdo_deactive_cus.AutoSize = true;
            this.rdo_deactive_cus.Location = new System.Drawing.Point(231, 39);
            this.rdo_deactive_cus.Name = "rdo_deactive_cus";
            this.rdo_deactive_cus.Size = new System.Drawing.Size(103, 16);
            this.rdo_deactive_cus.TabIndex = 5;
            this.rdo_deactive_cus.TabStop = true;
            this.rdo_deactive_cus.Text = "탈퇴 대기 회원";
            this.rdo_deactive_cus.UseVisualStyleBackColor = true;
            this.rdo_deactive_cus.Visible = false;
            // 
            // btn_pro_List
            // 
            this.btn_pro_List.Location = new System.Drawing.Point(12, 65);
            this.btn_pro_List.Name = "btn_pro_List";
            this.btn_pro_List.Size = new System.Drawing.Size(100, 23);
            this.btn_pro_List.TabIndex = 6;
            this.btn_pro_List.Text = "produts목록";
            this.btn_pro_List.UseVisualStyleBackColor = true;
            // 
            // rdo_deactive_pro
            // 
            this.rdo_deactive_pro.AutoSize = true;
            this.rdo_deactive_pro.Location = new System.Drawing.Point(231, 68);
            this.rdo_deactive_pro.Name = "rdo_deactive_pro";
            this.rdo_deactive_pro.Size = new System.Drawing.Size(99, 16);
            this.rdo_deactive_pro.TabIndex = 8;
            this.rdo_deactive_pro.TabStop = true;
            this.rdo_deactive_pro.Text = "비활성화 상품";
            this.rdo_deactive_pro.UseVisualStyleBackColor = true;
            this.rdo_deactive_pro.Visible = false;
            // 
            // rdo_all_pro
            // 
            this.rdo_all_pro.AutoSize = true;
            this.rdo_all_pro.Location = new System.Drawing.Point(121, 68);
            this.rdo_all_pro.Name = "rdo_all_pro";
            this.rdo_all_pro.Size = new System.Drawing.Size(75, 16);
            this.rdo_all_pro.TabIndex = 7;
            this.rdo_all_pro.TabStop = true;
            this.rdo_all_pro.Text = "전체 상품";
            this.rdo_all_pro.UseVisualStyleBackColor = true;
            this.rdo_all_pro.Visible = false;
            // 
            // rdo_deactive_seller
            // 
            this.rdo_deactive_seller.AutoSize = true;
            this.rdo_deactive_seller.Location = new System.Drawing.Point(231, 12);
            this.rdo_deactive_seller.Name = "rdo_deactive_seller";
            this.rdo_deactive_seller.Size = new System.Drawing.Size(99, 16);
            this.rdo_deactive_seller.TabIndex = 10;
            this.rdo_deactive_seller.TabStop = true;
            this.rdo_deactive_seller.Text = "비활성화 상품";
            this.rdo_deactive_seller.UseVisualStyleBackColor = true;
            this.rdo_deactive_seller.Visible = false;
            // 
            // rdo_all_seller
            // 
            this.rdo_all_seller.AutoSize = true;
            this.rdo_all_seller.Location = new System.Drawing.Point(121, 12);
            this.rdo_all_seller.Name = "rdo_all_seller";
            this.rdo_all_seller.Size = new System.Drawing.Size(87, 16);
            this.rdo_all_seller.TabIndex = 9;
            this.rdo_all_seller.TabStop = true;
            this.rdo_all_seller.Text = "전체 판매자";
            this.rdo_all_seller.UseVisualStyleBackColor = true;
            this.rdo_all_seller.Visible = false;
            // 
            // Admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 569);
            this.Controls.Add(this.rdo_deactive_seller);
            this.Controls.Add(this.rdo_all_seller);
            this.Controls.Add(this.rdo_deactive_pro);
            this.Controls.Add(this.rdo_all_pro);
            this.Controls.Add(this.btn_pro_List);
            this.Controls.Add(this.rdo_deactive_cus);
            this.Controls.Add(this.btn_cus_List);
            this.Controls.Add(this.btn_seller_List);
            this.Controls.Add(this.rdo_all_cus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_main";
            this.Text = "Admin_main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdo_all_cus;
        private System.Windows.Forms.Button btn_seller_List;
        private System.Windows.Forms.Button btn_cus_List;
        private System.Windows.Forms.RadioButton rdo_deactive_cus;
        private System.Windows.Forms.Button btn_pro_List;
        private System.Windows.Forms.RadioButton rdo_deactive_pro;
        private System.Windows.Forms.RadioButton rdo_all_pro;
        private System.Windows.Forms.RadioButton rdo_deactive_seller;
        private System.Windows.Forms.RadioButton rdo_all_seller;
    }
}