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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gViewProducts = new System.Windows.Forms.DataGridView();
            this.btnInsertPro = new System.Windows.Forms.Button();
            this.btnUpdatePro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnManagePro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gViewProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            this.gViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.gViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewProducts.GridColor = System.Drawing.Color.LightGray;
            this.gViewProducts.Location = new System.Drawing.Point(0, 58);
            this.gViewProducts.Margin = new System.Windows.Forms.Padding(0);
            this.gViewProducts.MultiSelect = false;
            this.gViewProducts.Name = "gViewProducts";
            this.gViewProducts.ReadOnly = true;
            this.gViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.gViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gViewProducts.RowTemplate.Height = 23;
            this.gViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewProducts.Size = new System.Drawing.Size(1413, 368);
            this.gViewProducts.TabIndex = 0;
            this.gViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewProducts_CellClick);
            this.gViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewProducts_CellDoubleClick);
            // 
            // btnInsertPro
            // 
            this.btnInsertPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnInsertPro.FlatAppearance.BorderSize = 0;
            this.btnInsertPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnInsertPro.Location = new System.Drawing.Point(628, 432);
            this.btnInsertPro.Name = "btnInsertPro";
            this.btnInsertPro.Size = new System.Drawing.Size(150, 50);
            this.btnInsertPro.TabIndex = 1;
            this.btnInsertPro.Text = "상품 등록";
            this.btnInsertPro.UseVisualStyleBackColor = false;
            this.btnInsertPro.Click += new System.EventHandler(this.btnInsertPro_Click);
            // 
            // btnUpdatePro
            // 
            this.btnUpdatePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnUpdatePro.FlatAppearance.BorderSize = 0;
            this.btnUpdatePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnUpdatePro.Location = new System.Drawing.Point(784, 432);
            this.btnUpdatePro.Name = "btnUpdatePro";
            this.btnUpdatePro.Size = new System.Drawing.Size(150, 50);
            this.btnUpdatePro.TabIndex = 2;
            this.btnUpdatePro.Text = "상품 수정";
            this.btnUpdatePro.UseVisualStyleBackColor = false;
            this.btnUpdatePro.Click += new System.EventHandler(this.btnUpdatePro_Click);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnDeletePro.FlatAppearance.BorderSize = 0;
            this.btnDeletePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnDeletePro.Location = new System.Drawing.Point(941, 432);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(150, 50);
            this.btnDeletePro.TabIndex = 3;
            this.btnDeletePro.Text = "상품 삭제";
            this.btnDeletePro.UseVisualStyleBackColor = false;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnRefresh.Location = new System.Drawing.Point(1253, 432);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 50);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnManagePro
            // 
            this.btnManagePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnManagePro.FlatAppearance.BorderSize = 0;
            this.btnManagePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnManagePro.Location = new System.Drawing.Point(1097, 432);
            this.btnManagePro.Name = "btnManagePro";
            this.btnManagePro.Size = new System.Drawing.Size(150, 50);
            this.btnManagePro.TabIndex = 6;
            this.btnManagePro.Text = "상품 판매 / 배송 관리";
            this.btnManagePro.UseVisualStyleBackColor = false;
            this.btnManagePro.Click += new System.EventHandler(this.btnManagePro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 58);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 54);
            this.label4.TabIndex = 19;
            this.label4.Text = "상품 내역";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnClose.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1362, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1416, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnManagePro);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnUpdatePro);
            this.Controls.Add(this.btnInsertPro);
            this.Controls.Add(this.gViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducts";
            this.Text = "상품 관리";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gViewProducts;
        private System.Windows.Forms.Button btnInsertPro;
        private System.Windows.Forms.Button btnUpdatePro;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnManagePro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
    }
}