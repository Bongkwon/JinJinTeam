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
            this.rdo_deactive_cus = new System.Windows.Forms.RadioButton();
            this.rdo_deactive_pro = new System.Windows.Forms.RadioButton();
            this.rdo_all_pro = new System.Windows.Forms.RadioButton();
            this.rdo_deactive_seller = new System.Windows.Forms.RadioButton();
            this.rdo_all_seller = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seller목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.products목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_pro = new System.Windows.Forms.GroupBox();
            this.gb_seller = new System.Windows.Forms.GroupBox();
            this.gb_cus = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_Disabled_seller = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_pro.SuspendLayout();
            this.gb_seller.SuspendLayout();
            this.gb_cus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // rdo_all_cus
            // 
            this.rdo_all_cus.AutoSize = true;
            this.rdo_all_cus.Checked = true;
            this.rdo_all_cus.Location = new System.Drawing.Point(6, 14);
            this.rdo_all_cus.Name = "rdo_all_cus";
            this.rdo_all_cus.Size = new System.Drawing.Size(75, 16);
            this.rdo_all_cus.TabIndex = 2;
            this.rdo_all_cus.TabStop = true;
            this.rdo_all_cus.Text = "전체 회원";
            this.rdo_all_cus.UseVisualStyleBackColor = true;
            this.rdo_all_cus.CheckedChanged += new System.EventHandler(this.cus_Changed);
            // 
            // rdo_deactive_cus
            // 
            this.rdo_deactive_cus.AutoSize = true;
            this.rdo_deactive_cus.Location = new System.Drawing.Point(95, 14);
            this.rdo_deactive_cus.Name = "rdo_deactive_cus";
            this.rdo_deactive_cus.Size = new System.Drawing.Size(103, 16);
            this.rdo_deactive_cus.TabIndex = 5;
            this.rdo_deactive_cus.Text = "탈퇴 대기 회원";
            this.rdo_deactive_cus.UseVisualStyleBackColor = true;
            this.rdo_deactive_cus.CheckedChanged += new System.EventHandler(this.cus_Changed);
            // 
            // rdo_deactive_pro
            // 
            this.rdo_deactive_pro.AutoSize = true;
            this.rdo_deactive_pro.Location = new System.Drawing.Point(95, 14);
            this.rdo_deactive_pro.Name = "rdo_deactive_pro";
            this.rdo_deactive_pro.Size = new System.Drawing.Size(99, 16);
            this.rdo_deactive_pro.TabIndex = 8;
            this.rdo_deactive_pro.Text = "비활성화 상품";
            this.rdo_deactive_pro.UseVisualStyleBackColor = true;
            // 
            // rdo_all_pro
            // 
            this.rdo_all_pro.AutoSize = true;
            this.rdo_all_pro.Checked = true;
            this.rdo_all_pro.Location = new System.Drawing.Point(6, 14);
            this.rdo_all_pro.Name = "rdo_all_pro";
            this.rdo_all_pro.Size = new System.Drawing.Size(75, 16);
            this.rdo_all_pro.TabIndex = 7;
            this.rdo_all_pro.TabStop = true;
            this.rdo_all_pro.Text = "전체 상품";
            this.rdo_all_pro.UseVisualStyleBackColor = true;
            this.rdo_all_pro.CheckedChanged += new System.EventHandler(this.pro_changed);
            // 
            // rdo_deactive_seller
            // 
            this.rdo_deactive_seller.AutoSize = true;
            this.rdo_deactive_seller.Location = new System.Drawing.Point(95, 15);
            this.rdo_deactive_seller.Name = "rdo_deactive_seller";
            this.rdo_deactive_seller.Size = new System.Drawing.Size(99, 16);
            this.rdo_deactive_seller.TabIndex = 10;
            this.rdo_deactive_seller.Text = "미가입 판매자";
            this.rdo_deactive_seller.UseVisualStyleBackColor = true;
            this.rdo_deactive_seller.CheckedChanged += new System.EventHandler(this.seller_changed);
            // 
            // rdo_all_seller
            // 
            this.rdo_all_seller.AutoSize = true;
            this.rdo_all_seller.Checked = true;
            this.rdo_all_seller.Location = new System.Drawing.Point(6, 15);
            this.rdo_all_seller.Name = "rdo_all_seller";
            this.rdo_all_seller.Size = new System.Drawing.Size(87, 16);
            this.rdo_all_seller.TabIndex = 9;
            this.rdo_all_seller.TabStop = true;
            this.rdo_all_seller.Text = "전체 판매자";
            this.rdo_all_seller.UseVisualStyleBackColor = true;
            this.rdo_all_seller.CheckedChanged += new System.EventHandler(this.seller_changed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seller목록ToolStripMenuItem,
            this.customer목록ToolStripMenuItem,
            this.products목록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seller목록ToolStripMenuItem
            // 
            this.seller목록ToolStripMenuItem.Name = "seller목록ToolStripMenuItem";
            this.seller목록ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.seller목록ToolStripMenuItem.Text = "seller 목록";
            this.seller목록ToolStripMenuItem.Click += new System.EventHandler(this.seller목록ToolStripMenuItem_Click);
            // 
            // customer목록ToolStripMenuItem
            // 
            this.customer목록ToolStripMenuItem.Name = "customer목록ToolStripMenuItem";
            this.customer목록ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.customer목록ToolStripMenuItem.Text = "customer 목록";
            this.customer목록ToolStripMenuItem.Click += new System.EventHandler(this.customer목록ToolStripMenuItem_Click);
            // 
            // products목록ToolStripMenuItem
            // 
            this.products목록ToolStripMenuItem.Name = "products목록ToolStripMenuItem";
            this.products목록ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.products목록ToolStripMenuItem.Text = "products 목록";
            this.products목록ToolStripMenuItem.Click += new System.EventHandler(this.products목록ToolStripMenuItem_Click);
            // 
            // gb_pro
            // 
            this.gb_pro.Controls.Add(this.rdo_deactive_pro);
            this.gb_pro.Controls.Add(this.rdo_all_pro);
            this.gb_pro.Location = new System.Drawing.Point(424, 27);
            this.gb_pro.Name = "gb_pro";
            this.gb_pro.Size = new System.Drawing.Size(200, 36);
            this.gb_pro.TabIndex = 12;
            this.gb_pro.TabStop = false;
            this.gb_pro.Text = "products";
            // 
            // gb_seller
            // 
            this.gb_seller.Controls.Add(this.rdo_Disabled_seller);
            this.gb_seller.Controls.Add(this.rdo_deactive_seller);
            this.gb_seller.Controls.Add(this.rdo_all_seller);
            this.gb_seller.Location = new System.Drawing.Point(12, 27);
            this.gb_seller.Name = "gb_seller";
            this.gb_seller.Size = new System.Drawing.Size(309, 36);
            this.gb_seller.TabIndex = 13;
            this.gb_seller.TabStop = false;
            this.gb_seller.Text = "sellers";
            // 
            // gb_cus
            // 
            this.gb_cus.Controls.Add(this.rdo_deactive_cus);
            this.gb_cus.Controls.Add(this.rdo_all_cus);
            this.gb_cus.Location = new System.Drawing.Point(630, 27);
            this.gb_cus.Name = "gb_cus";
            this.gb_cus.Size = new System.Drawing.Size(200, 36);
            this.gb_cus.TabIndex = 14;
            this.gb_cus.TabStop = false;
            this.gb_cus.Text = "customers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_Disabled_seller
            // 
            this.rdo_Disabled_seller.AutoSize = true;
            this.rdo_Disabled_seller.Location = new System.Drawing.Point(196, 15);
            this.rdo_Disabled_seller.Name = "rdo_Disabled_seller";
            this.rdo_Disabled_seller.Size = new System.Drawing.Size(111, 16);
            this.rdo_Disabled_seller.TabIndex = 11;
            this.rdo_Disabled_seller.Text = "비활성화 판매자";
            this.rdo_Disabled_seller.UseVisualStyleBackColor = true;
            this.rdo_Disabled_seller.CheckedChanged += new System.EventHandler(this.seller_changed);
            // 
            // Admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_cus);
            this.Controls.Add(this.gb_seller);
            this.Controls.Add(this.gb_pro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_main";
            this.Text = "Admin_main";
            this.Load += new System.EventHandler(this.Admin_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_pro.ResumeLayout(false);
            this.gb_pro.PerformLayout();
            this.gb_seller.ResumeLayout(false);
            this.gb_seller.PerformLayout();
            this.gb_cus.ResumeLayout(false);
            this.gb_cus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdo_all_cus;
        private System.Windows.Forms.RadioButton rdo_deactive_cus;
        private System.Windows.Forms.RadioButton rdo_deactive_pro;
        private System.Windows.Forms.RadioButton rdo_all_pro;
        private System.Windows.Forms.RadioButton rdo_deactive_seller;
        private System.Windows.Forms.RadioButton rdo_all_seller;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seller목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customer목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem products목록ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_pro;
        private System.Windows.Forms.GroupBox gb_seller;
        private System.Windows.Forms.GroupBox gb_cus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_Disabled_seller;
    }
}