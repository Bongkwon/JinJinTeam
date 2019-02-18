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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdoInquryOfProduct = new System.Windows.Forms.RadioButton();
            this.rdoReviewForPro = new System.Windows.Forms.RadioButton();
            this.rdoInquireToSys = new System.Windows.Forms.RadioButton();
            this.gViewInquiry = new System.Windows.Forms.DataGridView();
            this.btnInsertInquiry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewInquiry)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoInquryOfProduct
            // 
            this.rdoInquryOfProduct.AutoSize = true;
            this.rdoInquryOfProduct.Checked = true;
            this.rdoInquryOfProduct.Location = new System.Drawing.Point(12, 86);
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
            this.rdoReviewForPro.Location = new System.Drawing.Point(121, 85);
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
            this.rdoInquireToSys.Location = new System.Drawing.Point(230, 86);
            this.rdoInquireToSys.Name = "rdoInquireToSys";
            this.rdoInquireToSys.Size = new System.Drawing.Size(161, 16);
            this.rdoInquireToSys.TabIndex = 2;
            this.rdoInquireToSys.Text = "관리자에게 문의 / 피드백";
            this.rdoInquireToSys.UseVisualStyleBackColor = true;
            this.rdoInquireToSys.CheckedChanged += new System.EventHandler(this.rdoInquireToSys_CheckedChanged);
            // 
            // gViewInquiry
            // 
            this.gViewInquiry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.gViewInquiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gViewInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewInquiry.GridColor = System.Drawing.SystemColors.Control;
            this.gViewInquiry.Location = new System.Drawing.Point(12, 109);
            this.gViewInquiry.MultiSelect = false;
            this.gViewInquiry.Name = "gViewInquiry";
            this.gViewInquiry.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gViewInquiry.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gViewInquiry.RowTemplate.Height = 23;
            this.gViewInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewInquiry.Size = new System.Drawing.Size(1130, 402);
            this.gViewInquiry.TabIndex = 3;
            this.gViewInquiry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewInquiry_CellDoubleClick);
            // 
            // btnInsertInquiry
            // 
            this.btnInsertInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnInsertInquiry.FlatAppearance.BorderSize = 0;
            this.btnInsertInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInquiry.Location = new System.Drawing.Point(1067, 79);
            this.btnInsertInquiry.Name = "btnInsertInquiry";
            this.btnInsertInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnInsertInquiry.TabIndex = 4;
            this.btnInsertInquiry.Text = "문의하기";
            this.btnInsertInquiry.UseVisualStyleBackColor = false;
            this.btnInsertInquiry.Visible = false;
            this.btnInsertInquiry.Click += new System.EventHandler(this.btnInsertInquiry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 72);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.label6.TabIndex = 22;
            this.label6.Text = "JinTeam";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button1.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1094, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1155, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInsertInquiry);
            this.Controls.Add(this.gViewInquiry);
            this.Controls.Add(this.rdoInquireToSys);
            this.Controls.Add(this.rdoReviewForPro);
            this.Controls.Add(this.rdoInquryOfProduct);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInquiry";
            this.Text = "FrmInquiry";
            this.Load += new System.EventHandler(this.FrmInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewInquiry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoInquryOfProduct;
        private System.Windows.Forms.RadioButton rdoReviewForPro;
        private System.Windows.Forms.RadioButton rdoInquireToSys;
        private System.Windows.Forms.DataGridView gViewInquiry;
        private System.Windows.Forms.Button btnInsertInquiry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}