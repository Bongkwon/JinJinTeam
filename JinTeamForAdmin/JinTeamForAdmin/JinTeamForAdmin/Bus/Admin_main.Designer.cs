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
            this.main_GV = new System.Windows.Forms.DataGridView();
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
            this.결제정보세금계산서출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.문의내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_pro = new System.Windows.Forms.GroupBox();
            this.gb_seller = new System.Windows.Forms.GroupBox();
            this.rdo_Disabled_seller = new System.Windows.Forms.RadioButton();
            this.gb_cus = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_inq = new System.Windows.Forms.GroupBox();
            this.cb_inquire = new System.Windows.Forms.ComboBox();
            this.rd_sel_inq = new System.Windows.Forms.RadioButton();
            this.rd_cus_inq = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_GV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_pro.SuspendLayout();
            this.gb_seller.SuspendLayout();
            this.gb_cus.SuspendLayout();
            this.gb_inq.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_GV
            // 
            this.main_GV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.main_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_GV.Location = new System.Drawing.Point(12, 69);
            this.main_GV.MultiSelect = false;
            this.main_GV.Name = "main_GV";
            this.main_GV.ReadOnly = true;
            this.main_GV.RowTemplate.Height = 23;
            this.main_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main_GV.Size = new System.Drawing.Size(978, 380);
            this.main_GV.TabIndex = 0;
            this.main_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.rdo_deactive_seller.Location = new System.Drawing.Point(204, 15);
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
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seller목록ToolStripMenuItem,
            this.customer목록ToolStripMenuItem,
            this.products목록ToolStripMenuItem,
            this.결제정보세금계산서출력ToolStripMenuItem,
            this.문의내역ToolStripMenuItem,
            this.매출관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
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
            // 결제정보세금계산서출력ToolStripMenuItem
            // 
            this.결제정보세금계산서출력ToolStripMenuItem.Name = "결제정보세금계산서출력ToolStripMenuItem";
            this.결제정보세금계산서출력ToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.결제정보세금계산서출력ToolStripMenuItem.Text = "결제정보(세금계산서 출력)";
            this.결제정보세금계산서출력ToolStripMenuItem.Click += new System.EventHandler(this.결제정보세금계산서출력ToolStripMenuItem_Click);
            // 
            // 문의내역ToolStripMenuItem
            // 
            this.문의내역ToolStripMenuItem.Name = "문의내역ToolStripMenuItem";
            this.문의내역ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.문의내역ToolStripMenuItem.Text = "문의내역";
            this.문의내역ToolStripMenuItem.Click += new System.EventHandler(this.문의내역ToolStripMenuItem_Click);
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매출관리ToolStripMenuItem.Text = "매출관리";
            this.매출관리ToolStripMenuItem.Click += new System.EventHandler(this.매출관리ToolStripMenuItem_Click);
            // 
            // gb_pro
            // 
            this.gb_pro.Controls.Add(this.rdo_deactive_pro);
            this.gb_pro.Controls.Add(this.rdo_all_pro);
            this.gb_pro.Location = new System.Drawing.Point(12, 27);
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
            // rdo_Disabled_seller
            // 
            this.rdo_Disabled_seller.AutoSize = true;
            this.rdo_Disabled_seller.Location = new System.Drawing.Point(92, 15);
            this.rdo_Disabled_seller.Name = "rdo_Disabled_seller";
            this.rdo_Disabled_seller.Size = new System.Drawing.Size(111, 16);
            this.rdo_Disabled_seller.TabIndex = 11;
            this.rdo_Disabled_seller.Text = "비활성화 판매자";
            this.rdo_Disabled_seller.UseVisualStyleBackColor = true;
            this.rdo_Disabled_seller.CheckedChanged += new System.EventHandler(this.seller_changed);
            // 
            // gb_cus
            // 
            this.gb_cus.Controls.Add(this.rdo_deactive_cus);
            this.gb_cus.Controls.Add(this.rdo_all_cus);
            this.gb_cus.Location = new System.Drawing.Point(12, 27);
            this.gb_cus.Name = "gb_cus";
            this.gb_cus.Size = new System.Drawing.Size(200, 36);
            this.gb_cus.TabIndex = 14;
            this.gb_cus.TabStop = false;
            this.gb_cus.Text = "customers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(917, 39);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(73, 23);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "새로고침";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_inq
            // 
            this.gb_inq.BackColor = System.Drawing.Color.LightGray;
            this.gb_inq.Controls.Add(this.cb_inquire);
            this.gb_inq.Controls.Add(this.rd_sel_inq);
            this.gb_inq.Controls.Add(this.rd_cus_inq);
            this.gb_inq.Location = new System.Drawing.Point(12, 27);
            this.gb_inq.Name = "gb_inq";
            this.gb_inq.Size = new System.Drawing.Size(318, 36);
            this.gb_inq.TabIndex = 17;
            this.gb_inq.TabStop = false;
            this.gb_inq.Text = "inquire";
            // 
            // cb_inquire
            // 
            this.cb_inquire.FormattingEnabled = true;
            this.cb_inquire.Location = new System.Drawing.Point(190, 11);
            this.cb_inquire.Name = "cb_inquire";
            this.cb_inquire.Size = new System.Drawing.Size(121, 20);
            this.cb_inquire.TabIndex = 18;
            this.cb_inquire.TextChanged += new System.EventHandler(this.cb_inquire_TextChanged);
            // 
            // rd_sel_inq
            // 
            this.rd_sel_inq.AutoSize = true;
            this.rd_sel_inq.Location = new System.Drawing.Point(6, 15);
            this.rd_sel_inq.Name = "rd_sel_inq";
            this.rd_sel_inq.Size = new System.Drawing.Size(93, 16);
            this.rd_sel_inq.TabIndex = 11;
            this.rd_sel_inq.Text = "문의(판매자)";
            this.rd_sel_inq.UseVisualStyleBackColor = true;
            this.rd_sel_inq.CheckedChanged += new System.EventHandler(this.inq_changed);
            // 
            // rd_cus_inq
            // 
            this.rd_cus_inq.AutoSize = true;
            this.rd_cus_inq.Location = new System.Drawing.Point(105, 14);
            this.rd_cus_inq.Name = "rd_cus_inq";
            this.rd_cus_inq.Size = new System.Drawing.Size(81, 16);
            this.rd_cus_inq.TabIndex = 10;
            this.rd_cus_inq.Text = "문의(고객)";
            this.rd_cus_inq.UseVisualStyleBackColor = true;
            this.rd_cus_inq.CheckedChanged += new System.EventHandler(this.inq_changed);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(967, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1002, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gb_inq);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_cus);
            this.Controls.Add(this.gb_seller);
            this.Controls.Add(this.gb_pro);
            this.Controls.Add(this.main_GV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_main";
            this.Text = "Admin_main";
            this.Load += new System.EventHandler(this.Admin_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_GV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_pro.ResumeLayout(false);
            this.gb_pro.PerformLayout();
            this.gb_seller.ResumeLayout(false);
            this.gb_seller.PerformLayout();
            this.gb_cus.ResumeLayout(false);
            this.gb_cus.PerformLayout();
            this.gb_inq.ResumeLayout(false);
            this.gb_inq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView main_GV;
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
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ToolStripMenuItem 결제정보세금계산서출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 문의내역ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_inq;
        private System.Windows.Forms.RadioButton rd_sel_inq;
        private System.Windows.Forms.RadioButton rd_cus_inq;
        private System.Windows.Forms.ComboBox cb_inquire;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}