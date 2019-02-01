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
            this.gViewPayInfo = new System.Windows.Forms.DataGridView();
            this.rdoShowAll = new System.Windows.Forms.RadioButton();
            this.rdoShowYet = new System.Windows.Forms.RadioButton();
            this.rdoShowIng = new System.Windows.Forms.RadioButton();
            this.rdoShowFin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWaybill_ID = new System.Windows.Forms.Button();
            this.btnSaveTrans_State = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewPayInfo
            // 
            this.gViewPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewPayInfo.Location = new System.Drawing.Point(13, 39);
            this.gViewPayInfo.Name = "gViewPayInfo";
            this.gViewPayInfo.RowTemplate.Height = 23;
            this.gViewPayInfo.Size = new System.Drawing.Size(1558, 479);
            this.gViewPayInfo.TabIndex = 0;
            this.gViewPayInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewPayInfo_CellDoubleClick);
            // 
            // rdoShowAll
            // 
            this.rdoShowAll.AutoSize = true;
            this.rdoShowAll.Checked = true;
            this.rdoShowAll.Location = new System.Drawing.Point(13, 12);
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
            this.rdoShowYet.Location = new System.Drawing.Point(90, 12);
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
            this.rdoShowIng.Location = new System.Drawing.Point(223, 12);
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
            this.rdoShowFin.Location = new System.Drawing.Point(356, 12);
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
            this.label1.Location = new System.Drawing.Point(611, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "*운송장 번호를 입력한 뒤 아래 운송장 등록 버튼을 클릭하시면 운송장 등록이 완료 됩니다.";
            // 
            // btnSaveWaybill_ID
            // 
            this.btnSaveWaybill_ID.Location = new System.Drawing.Point(1406, 524);
            this.btnSaveWaybill_ID.Name = "btnSaveWaybill_ID";
            this.btnSaveWaybill_ID.Size = new System.Drawing.Size(165, 23);
            this.btnSaveWaybill_ID.TabIndex = 6;
            this.btnSaveWaybill_ID.Text = "운송장 저장";
            this.btnSaveWaybill_ID.UseVisualStyleBackColor = true;
            this.btnSaveWaybill_ID.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveTrans_State
            // 
            this.btnSaveTrans_State.Location = new System.Drawing.Point(1235, 524);
            this.btnSaveTrans_State.Name = "btnSaveTrans_State";
            this.btnSaveTrans_State.Size = new System.Drawing.Size(165, 23);
            this.btnSaveTrans_State.TabIndex = 7;
            this.btnSaveTrans_State.Text = "배송 상태 저장";
            this.btnSaveTrans_State.UseVisualStyleBackColor = true;
            this.btnSaveTrans_State.Click += new System.EventHandler(this.btnSaveTrans_State_Click);
            // 
            // FrmSellAndTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 577);
            this.Controls.Add(this.btnSaveTrans_State);
            this.Controls.Add(this.btnSaveWaybill_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoShowFin);
            this.Controls.Add(this.rdoShowIng);
            this.Controls.Add(this.rdoShowYet);
            this.Controls.Add(this.rdoShowAll);
            this.Controls.Add(this.gViewPayInfo);
            this.Name = "FrmSellAndTransport";
            this.Text = "FrmSellAndTransport";
            this.Load += new System.EventHandler(this.FrmSellAndTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).EndInit();
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
        private System.Windows.Forms.Button btnSaveTrans_State;
    }
}