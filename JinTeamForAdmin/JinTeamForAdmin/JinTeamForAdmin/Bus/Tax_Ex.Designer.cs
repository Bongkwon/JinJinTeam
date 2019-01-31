namespace JinTeamForAdmin.Bus
{
    partial class Tax_Ex
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
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_saveLocation = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.lbl_corporate_registration_no = new System.Windows.Forms.Label();
            this.lbl_seller_Id = new System.Windows.Forms.Label();
            this.lbl_seller_boss = new System.Windows.Forms.Label();
            this.lbl_seller_addr = new System.Windows.Forms.Label();
            this.lbl_pay_date_1 = new System.Windows.Forms.Label();
            this.lbl_pay_price_2 = new System.Windows.Forms.Label();
            this.lbl_pay_price_5 = new System.Windows.Forms.Label();
            this.lbl_pay_date_2 = new System.Windows.Forms.Label();
            this.lbl_stock_id = new System.Windows.Forms.Label();
            this.lbl_pay_count = new System.Windows.Forms.Label();
            this.lbl_pay_price_3 = new System.Windows.Forms.Label();
            this.lbl_pay_price_1 = new System.Windows.Forms.Label();
            this.lbl_pay_price_4 = new System.Windows.Forms.Label();
            this.lbl_pay_price_6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_output
            // 
            this.btn_output.Enabled = false;
            this.btn_output.Location = new System.Drawing.Point(795, 336);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(75, 23);
            this.btn_output.TabIndex = 0;
            this.btn_output.Text = "출력";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_saveLocation
            // 
            this.btn_saveLocation.Location = new System.Drawing.Point(3, 336);
            this.btn_saveLocation.Name = "btn_saveLocation";
            this.btn_saveLocation.Size = new System.Drawing.Size(88, 23);
            this.btn_saveLocation.TabIndex = 1;
            this.btn_saveLocation.Text = "파일위치지정";
            this.btn_saveLocation.UseVisualStyleBackColor = true;
            this.btn_saveLocation.Click += new System.EventHandler(this.btn_saveLocation_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(97, 341);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(38, 12);
            this.lbl_path.TabIndex = 2;
            this.lbl_path.Text = "label1";
            // 
            // lbl_corporate_registration_no
            // 
            this.lbl_corporate_registration_no.AutoSize = true;
            this.lbl_corporate_registration_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_corporate_registration_no.Location = new System.Drawing.Point(170, 52);
            this.lbl_corporate_registration_no.Name = "lbl_corporate_registration_no";
            this.lbl_corporate_registration_no.Size = new System.Drawing.Size(146, 12);
            this.lbl_corporate_registration_no.TabIndex = 3;
            this.lbl_corporate_registration_no.Text = "corporate_registration_no";
            // 
            // lbl_seller_Id
            // 
            this.lbl_seller_Id.AutoSize = true;
            this.lbl_seller_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_Id.Location = new System.Drawing.Point(170, 73);
            this.lbl_seller_Id.Name = "lbl_seller_Id";
            this.lbl_seller_Id.Size = new System.Drawing.Size(52, 12);
            this.lbl_seller_Id.TabIndex = 4;
            this.lbl_seller_Id.Text = "seller_Id";
            // 
            // lbl_seller_boss
            // 
            this.lbl_seller_boss.AutoSize = true;
            this.lbl_seller_boss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_boss.Location = new System.Drawing.Point(383, 73);
            this.lbl_seller_boss.Name = "lbl_seller_boss";
            this.lbl_seller_boss.Size = new System.Drawing.Size(70, 12);
            this.lbl_seller_boss.TabIndex = 5;
            this.lbl_seller_boss.Text = "seller_boss";
            // 
            // lbl_seller_addr
            // 
            this.lbl_seller_addr.AutoSize = true;
            this.lbl_seller_addr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_addr.Location = new System.Drawing.Point(170, 95);
            this.lbl_seller_addr.Name = "lbl_seller_addr";
            this.lbl_seller_addr.Size = new System.Drawing.Size(67, 12);
            this.lbl_seller_addr.TabIndex = 6;
            this.lbl_seller_addr.Text = "seller_addr";
            // 
            // lbl_pay_date_1
            // 
            this.lbl_pay_date_1.AutoSize = true;
            this.lbl_pay_date_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_date_1.Location = new System.Drawing.Point(8, 160);
            this.lbl_pay_date_1.Name = "lbl_pay_date_1";
            this.lbl_pay_date_1.Size = new System.Drawing.Size(68, 12);
            this.lbl_pay_date_1.TabIndex = 7;
            this.lbl_pay_date_1.Text = "pay_date_1";
            // 
            // lbl_pay_price_2
            // 
            this.lbl_pay_price_2.AutoSize = true;
            this.lbl_pay_price_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_2.Location = new System.Drawing.Point(170, 161);
            this.lbl_pay_price_2.Name = "lbl_pay_price_2";
            this.lbl_pay_price_2.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_2.TabIndex = 8;
            this.lbl_pay_price_2.Text = "pay_price_2 * 0.9";
            // 
            // lbl_pay_price_5
            // 
            this.lbl_pay_price_5.AutoSize = true;
            this.lbl_pay_price_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_5.Location = new System.Drawing.Point(456, 161);
            this.lbl_pay_price_5.Name = "lbl_pay_price_5";
            this.lbl_pay_price_5.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_5.TabIndex = 9;
            this.lbl_pay_price_5.Text = "pay_price_5 * 0.1";
            // 
            // lbl_pay_date_2
            // 
            this.lbl_pay_date_2.AutoSize = true;
            this.lbl_pay_date_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_date_2.Location = new System.Drawing.Point(4, 204);
            this.lbl_pay_date_2.Name = "lbl_pay_date_2";
            this.lbl_pay_date_2.Size = new System.Drawing.Size(68, 12);
            this.lbl_pay_date_2.TabIndex = 10;
            this.lbl_pay_date_2.Text = "pay_date_2";
            // 
            // lbl_stock_id
            // 
            this.lbl_stock_id.AutoSize = true;
            this.lbl_stock_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_stock_id.Location = new System.Drawing.Point(79, 203);
            this.lbl_stock_id.Name = "lbl_stock_id";
            this.lbl_stock_id.Size = new System.Drawing.Size(51, 12);
            this.lbl_stock_id.TabIndex = 11;
            this.lbl_stock_id.Text = "stock_id";
            // 
            // lbl_pay_count
            // 
            this.lbl_pay_count.AutoSize = true;
            this.lbl_pay_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_count.Location = new System.Drawing.Point(313, 203);
            this.lbl_pay_count.Name = "lbl_pay_count";
            this.lbl_pay_count.Size = new System.Drawing.Size(63, 12);
            this.lbl_pay_count.TabIndex = 12;
            this.lbl_pay_count.Text = "pay_count";
            // 
            // lbl_pay_price_3
            // 
            this.lbl_pay_price_3.AutoSize = true;
            this.lbl_pay_price_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_3.Location = new System.Drawing.Point(553, 203);
            this.lbl_pay_price_3.Name = "lbl_pay_price_3";
            this.lbl_pay_price_3.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_3.TabIndex = 13;
            this.lbl_pay_price_3.Text = "pay_price_3 * 0.9";
            // 
            // lbl_pay_price_1
            // 
            this.lbl_pay_price_1.AutoSize = true;
            this.lbl_pay_price_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_1.Location = new System.Drawing.Point(383, 203);
            this.lbl_pay_price_1.Name = "lbl_pay_price_1";
            this.lbl_pay_price_1.Size = new System.Drawing.Size(72, 12);
            this.lbl_pay_price_1.TabIndex = 14;
            this.lbl_pay_price_1.Text = "pay_price_1";
            // 
            // lbl_pay_price_4
            // 
            this.lbl_pay_price_4.AutoSize = true;
            this.lbl_pay_price_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_4.Location = new System.Drawing.Point(743, 203);
            this.lbl_pay_price_4.Name = "lbl_pay_price_4";
            this.lbl_pay_price_4.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_4.TabIndex = 15;
            this.lbl_pay_price_4.Text = "pay_price_4 * 0.1";
            // 
            // lbl_pay_price_6
            // 
            this.lbl_pay_price_6.AutoSize = true;
            this.lbl_pay_price_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_6.Location = new System.Drawing.Point(7, 314);
            this.lbl_pay_price_6.Name = "lbl_pay_price_6";
            this.lbl_pay_price_6.Size = new System.Drawing.Size(91, 12);
            this.lbl_pay_price_6.TabIndex = 16;
            this.lbl_pay_price_6.Text = "lbl_pay_price_6";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(876, 336);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Tax_Ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JinTeamForAdmin.Properties.Resources.세금계산서_예시;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 360);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_pay_price_6);
            this.Controls.Add(this.lbl_pay_price_4);
            this.Controls.Add(this.lbl_pay_price_1);
            this.Controls.Add(this.lbl_pay_price_3);
            this.Controls.Add(this.lbl_pay_count);
            this.Controls.Add(this.lbl_stock_id);
            this.Controls.Add(this.lbl_pay_date_2);
            this.Controls.Add(this.lbl_pay_price_5);
            this.Controls.Add(this.lbl_pay_price_2);
            this.Controls.Add(this.lbl_pay_date_1);
            this.Controls.Add(this.lbl_seller_addr);
            this.Controls.Add(this.lbl_seller_boss);
            this.Controls.Add(this.lbl_seller_Id);
            this.Controls.Add(this.lbl_corporate_registration_no);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_saveLocation);
            this.Controls.Add(this.btn_output);
            this.DoubleBuffered = true;
            this.Name = "Tax_Ex";
            this.Text = "Tax_Ex";
            this.Load += new System.EventHandler(this.Tax_Ex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_saveLocation;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_corporate_registration_no;
        private System.Windows.Forms.Label lbl_seller_Id;
        private System.Windows.Forms.Label lbl_seller_boss;
        private System.Windows.Forms.Label lbl_seller_addr;
        private System.Windows.Forms.Label lbl_pay_date_1;
        private System.Windows.Forms.Label lbl_pay_price_2;
        private System.Windows.Forms.Label lbl_pay_price_5;
        private System.Windows.Forms.Label lbl_pay_date_2;
        private System.Windows.Forms.Label lbl_stock_id;
        private System.Windows.Forms.Label lbl_pay_count;
        private System.Windows.Forms.Label lbl_pay_price_3;
        private System.Windows.Forms.Label lbl_pay_price_1;
        private System.Windows.Forms.Label lbl_pay_price_4;
        private System.Windows.Forms.Label lbl_pay_price_6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_cancel;
    }
}