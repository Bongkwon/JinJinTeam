namespace JinTeamForSeller
{
    partial class FrmSalesDetail
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
            this.lblPay_ID = new System.Windows.Forms.Label();
            this.lblStock_no = new System.Windows.Forms.Label();
            this.lblPro_Count = new System.Windows.Forms.Label();
            this.lblPay_Price = new System.Windows.Forms.Label();
            this.lblWaybill_ID = new System.Windows.Forms.Label();
            this.lblTrans_State = new System.Windows.Forms.Label();
            this.lblOrder_Require = new System.Windows.Forms.Label();
            this.lblShip_Require = new System.Windows.Forms.Label();
            this.lblCus_Name = new System.Windows.Forms.Label();
            this.lblUser_Name = new System.Windows.Forms.Label();
            this.lblUser_Addr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPay_ID
            // 
            this.lblPay_ID.AutoSize = true;
            this.lblPay_ID.Location = new System.Drawing.Point(13, 13);
            this.lblPay_ID.Name = "lblPay_ID";
            this.lblPay_ID.Size = new System.Drawing.Size(69, 12);
            this.lblPay_ID.TabIndex = 0;
            this.lblPay_ID.Text = "결제 번호 : ";
            // 
            // lblStock_no
            // 
            this.lblStock_no.AutoSize = true;
            this.lblStock_no.Location = new System.Drawing.Point(12, 37);
            this.lblStock_no.Name = "lblStock_no";
            this.lblStock_no.Size = new System.Drawing.Size(69, 12);
            this.lblStock_no.TabIndex = 1;
            this.lblStock_no.Text = "상품 번호 : ";
            // 
            // lblPro_Count
            // 
            this.lblPro_Count.AutoSize = true;
            this.lblPro_Count.Location = new System.Drawing.Point(12, 66);
            this.lblPro_Count.Name = "lblPro_Count";
            this.lblPro_Count.Size = new System.Drawing.Size(69, 12);
            this.lblPro_Count.TabIndex = 2;
            this.lblPro_Count.Text = "주문 수량 : ";
            // 
            // lblPay_Price
            // 
            this.lblPay_Price.AutoSize = true;
            this.lblPay_Price.Location = new System.Drawing.Point(283, 37);
            this.lblPay_Price.Name = "lblPay_Price";
            this.lblPay_Price.Size = new System.Drawing.Size(53, 12);
            this.lblPay_Price.TabIndex = 3;
            this.lblPay_Price.Text = "결제가 : ";
            // 
            // lblWaybill_ID
            // 
            this.lblWaybill_ID.AutoSize = true;
            this.lblWaybill_ID.Location = new System.Drawing.Point(13, 92);
            this.lblWaybill_ID.Margin = new System.Windows.Forms.Padding(3);
            this.lblWaybill_ID.Name = "lblWaybill_ID";
            this.lblWaybill_ID.Size = new System.Drawing.Size(0, 12);
            this.lblWaybill_ID.TabIndex = 4;
            // 
            // lblTrans_State
            // 
            this.lblTrans_State.AutoSize = true;
            this.lblTrans_State.Location = new System.Drawing.Point(13, 118);
            this.lblTrans_State.Name = "lblTrans_State";
            this.lblTrans_State.Size = new System.Drawing.Size(69, 12);
            this.lblTrans_State.TabIndex = 5;
            this.lblTrans_State.Text = "배송 상태 : ";
            // 
            // lblOrder_Require
            // 
            this.lblOrder_Require.AutoSize = true;
            this.lblOrder_Require.Location = new System.Drawing.Point(13, 146);
            this.lblOrder_Require.Name = "lblOrder_Require";
            this.lblOrder_Require.Size = new System.Drawing.Size(105, 12);
            this.lblOrder_Require.TabIndex = 6;
            this.lblOrder_Require.Text = "주문시 요구사항 : ";
            // 
            // lblShip_Require
            // 
            this.lblShip_Require.AutoSize = true;
            this.lblShip_Require.Location = new System.Drawing.Point(14, 173);
            this.lblShip_Require.Name = "lblShip_Require";
            this.lblShip_Require.Size = new System.Drawing.Size(105, 12);
            this.lblShip_Require.TabIndex = 7;
            this.lblShip_Require.Text = "배송시 요구사항 : ";
            // 
            // lblCus_Name
            // 
            this.lblCus_Name.AutoSize = true;
            this.lblCus_Name.Location = new System.Drawing.Point(283, 13);
            this.lblCus_Name.Name = "lblCus_Name";
            this.lblCus_Name.Size = new System.Drawing.Size(53, 12);
            this.lblCus_Name.TabIndex = 8;
            this.lblCus_Name.Text = "고객명 : ";
            // 
            // lblUser_Name
            // 
            this.lblUser_Name.AutoSize = true;
            this.lblUser_Name.Location = new System.Drawing.Point(283, 63);
            this.lblUser_Name.Name = "lblUser_Name";
            this.lblUser_Name.Size = new System.Drawing.Size(53, 12);
            this.lblUser_Name.TabIndex = 10;
            this.lblUser_Name.Text = "받을분 : ";
            // 
            // lblUser_Addr
            // 
            this.lblUser_Addr.AutoSize = true;
            this.lblUser_Addr.Location = new System.Drawing.Point(283, 89);
            this.lblUser_Addr.Name = "lblUser_Addr";
            this.lblUser_Addr.Size = new System.Drawing.Size(53, 12);
            this.lblUser_Addr.TabIndex = 11;
            this.lblUser_Addr.Text = "배송지 : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSalesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 195);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblUser_Addr);
            this.Controls.Add(this.lblUser_Name);
            this.Controls.Add(this.lblCus_Name);
            this.Controls.Add(this.lblShip_Require);
            this.Controls.Add(this.lblOrder_Require);
            this.Controls.Add(this.lblTrans_State);
            this.Controls.Add(this.lblWaybill_ID);
            this.Controls.Add(this.lblPay_Price);
            this.Controls.Add(this.lblPro_Count);
            this.Controls.Add(this.lblStock_no);
            this.Controls.Add(this.lblPay_ID);
            this.Name = "FrmSalesDetail";
            this.Text = "FrmSalesDetail";
            this.Load += new System.EventHandler(this.FrmSalesDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPay_ID;
        private System.Windows.Forms.Label lblStock_no;
        private System.Windows.Forms.Label lblPro_Count;
        private System.Windows.Forms.Label lblPay_Price;
        private System.Windows.Forms.Label lblWaybill_ID;
        private System.Windows.Forms.Label lblTrans_State;
        private System.Windows.Forms.Label lblOrder_Require;
        private System.Windows.Forms.Label lblShip_Require;
        private System.Windows.Forms.Label lblCus_Name;
        private System.Windows.Forms.Label lblUser_Name;
        private System.Windows.Forms.Label lblUser_Addr;
        private System.Windows.Forms.Button button2;
    }
}