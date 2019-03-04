namespace JinTeamForSeller
{
    partial class FrmSellAndTransport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gViewPayInfo = new System.Windows.Forms.DataGridView();
            this.rdoShowAll = new System.Windows.Forms.RadioButton();
            this.rdoShowYet = new System.Windows.Forms.RadioButton();
            this.rdoShowIng = new System.Windows.Forms.RadioButton();
            this.rdoShowFin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWaybill_ID = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gViewPayInfo
            // 
            this.gViewPayInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gViewPayInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gViewPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gViewPayInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gViewPayInfo.EnableHeadersVisualStyles = false;
            this.gViewPayInfo.Location = new System.Drawing.Point(12, 96);
            this.gViewPayInfo.Name = "gViewPayInfo";
            this.gViewPayInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gViewPayInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            this.gViewPayInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gViewPayInfo.RowTemplate.Height = 23;
            this.gViewPayInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewPayInfo.Size = new System.Drawing.Size(1558, 479);
            this.gViewPayInfo.TabIndex = 0;
            this.gViewPayInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewPayInfo_CellClick);
            this.gViewPayInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewPayInfo_CellDoubleClick);
            // 
            // rdoShowAll
            // 
            this.rdoShowAll.AutoSize = true;
            this.rdoShowAll.Checked = true;
            this.rdoShowAll.Location = new System.Drawing.Point(12, 69);
            this.rdoShowAll.Name = "rdoShowAll";
            this.rdoShowAll.Size = new System.Drawing.Size(71, 16);
            this.rdoShowAll.TabIndex = 1;
            this.rdoShowAll.TabStop = true;
            this.rdoShowAll.Text = "모두보기";
            this.rdoShowAll.UseVisualStyleBackColor = true;
            this.rdoShowAll.CheckedChanged += new System.EventHandler(this.rdoShowAll_CheckedChanged);
            // 
            // rdoShowYet
            // 
            this.rdoShowYet.AutoSize = true;
            this.rdoShowYet.Location = new System.Drawing.Point(89, 69);
            this.rdoShowYet.Name = "rdoShowYet";
            this.rdoShowYet.Size = new System.Drawing.Size(127, 16);
            this.rdoShowYet.TabIndex = 2;
            this.rdoShowYet.Text = "배송전인 상품 보기";
            this.rdoShowYet.UseVisualStyleBackColor = true;
            this.rdoShowYet.CheckedChanged += new System.EventHandler(this.rdoShowYet_CheckedChanged);
            // 
            // rdoShowIng
            // 
            this.rdoShowIng.AutoSize = true;
            this.rdoShowIng.Location = new System.Drawing.Point(222, 69);
            this.rdoShowIng.Name = "rdoShowIng";
            this.rdoShowIng.Size = new System.Drawing.Size(127, 16);
            this.rdoShowIng.TabIndex = 3;
            this.rdoShowIng.Text = "배송중인 상품 보기";
            this.rdoShowIng.UseVisualStyleBackColor = true;
            this.rdoShowIng.CheckedChanged += new System.EventHandler(this.rdoShowIng_CheckedChanged);
            // 
            // rdoShowFin
            // 
            this.rdoShowFin.AutoSize = true;
            this.rdoShowFin.Location = new System.Drawing.Point(355, 69);
            this.rdoShowFin.Name = "rdoShowFin";
            this.rdoShowFin.Size = new System.Drawing.Size(127, 16);
            this.rdoShowFin.TabIndex = 4;
            this.rdoShowFin.Text = "배송완료 상품 보기";
            this.rdoShowFin.UseVisualStyleBackColor = true;
            this.rdoShowFin.CheckedChanged += new System.EventHandler(this.rdoShowFin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "*운송장 번호를 입력한 뒤 아래 운송장 등록 버튼을 클릭하시면 운송장 등록이 완료 됩니다.";
            // 
            // btnSaveWaybill_ID
            // 
            this.btnSaveWaybill_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnSaveWaybill_ID.FlatAppearance.BorderSize = 0;
            this.btnSaveWaybill_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWaybill_ID.Location = new System.Drawing.Point(1405, 581);
            this.btnSaveWaybill_ID.Name = "btnSaveWaybill_ID";
            this.btnSaveWaybill_ID.Size = new System.Drawing.Size(165, 23);
            this.btnSaveWaybill_ID.TabIndex = 6;
            this.btnSaveWaybill_ID.Text = "운송장 저장";
            this.btnSaveWaybill_ID.UseVisualStyleBackColor = false;
            this.btnSaveWaybill_ID.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1583, 54);
            this.panel7.TabIndex = 40;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 54);
            this.label6.TabIndex = 36;
            this.label6.Text = "배송 정보";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button2.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1522, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 48);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSellAndTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1583, 632);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnSaveWaybill_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoShowFin);
            this.Controls.Add(this.rdoShowIng);
            this.Controls.Add(this.rdoShowYet);
            this.Controls.Add(this.rdoShowAll);
            this.Controls.Add(this.gViewPayInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSellAndTransport";
            this.Text = "FrmSellAndTransport";
            this.Load += new System.EventHandler(this.FrmSellAndTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gViewPayInfo;
        private System.Windows.Forms.RadioButton rdoShowAll;
        private System.Windows.Forms.RadioButton rdoShowYet;
        private System.Windows.Forms.RadioButton rdoShowIng;
        private System.Windows.Forms.RadioButton rdoShowFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveWaybill_ID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}