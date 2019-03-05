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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_output
            // 
            this.btn_output.Enabled = false;
            this.btn_output.Location = new System.Drawing.Point(801, 388);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(75, 23);
            this.btn_output.TabIndex = 0;
            this.btn_output.Text = "출력";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_saveLocation
            // 
            this.btn_saveLocation.Location = new System.Drawing.Point(1, 388);
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
            this.lbl_path.Location = new System.Drawing.Point(95, 393);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(38, 12);
            this.lbl_path.TabIndex = 2;
            this.lbl_path.Text = "label1";
            // 
            // lbl_corporate_registration_no
            // 
            this.lbl_corporate_registration_no.AutoSize = true;
            this.lbl_corporate_registration_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_corporate_registration_no.Location = new System.Drawing.Point(170, 104);
            this.lbl_corporate_registration_no.Name = "lbl_corporate_registration_no";
            this.lbl_corporate_registration_no.Size = new System.Drawing.Size(146, 12);
            this.lbl_corporate_registration_no.TabIndex = 3;
            this.lbl_corporate_registration_no.Text = "corporate_registration_no";
            // 
            // lbl_seller_Id
            // 
            this.lbl_seller_Id.AutoSize = true;
            this.lbl_seller_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_Id.Location = new System.Drawing.Point(170, 125);
            this.lbl_seller_Id.Name = "lbl_seller_Id";
            this.lbl_seller_Id.Size = new System.Drawing.Size(52, 12);
            this.lbl_seller_Id.TabIndex = 4;
            this.lbl_seller_Id.Text = "seller_Id";
            // 
            // lbl_seller_boss
            // 
            this.lbl_seller_boss.AutoSize = true;
            this.lbl_seller_boss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_boss.Location = new System.Drawing.Point(383, 125);
            this.lbl_seller_boss.Name = "lbl_seller_boss";
            this.lbl_seller_boss.Size = new System.Drawing.Size(70, 12);
            this.lbl_seller_boss.TabIndex = 5;
            this.lbl_seller_boss.Text = "seller_boss";
            // 
            // lbl_seller_addr
            // 
            this.lbl_seller_addr.AutoSize = true;
            this.lbl_seller_addr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_seller_addr.Location = new System.Drawing.Point(170, 143);
            this.lbl_seller_addr.Name = "lbl_seller_addr";
            this.lbl_seller_addr.Size = new System.Drawing.Size(67, 12);
            this.lbl_seller_addr.TabIndex = 6;
            this.lbl_seller_addr.Text = "seller_addr";
            // 
            // lbl_pay_date_1
            // 
            this.lbl_pay_date_1.AutoSize = true;
            this.lbl_pay_date_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_date_1.Location = new System.Drawing.Point(4, 214);
            this.lbl_pay_date_1.Name = "lbl_pay_date_1";
            this.lbl_pay_date_1.Size = new System.Drawing.Size(68, 12);
            this.lbl_pay_date_1.TabIndex = 7;
            this.lbl_pay_date_1.Text = "pay_date_1";
            // 
            // lbl_pay_price_2
            // 
            this.lbl_pay_price_2.AutoSize = true;
            this.lbl_pay_price_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_2.Location = new System.Drawing.Point(170, 214);
            this.lbl_pay_price_2.Name = "lbl_pay_price_2";
            this.lbl_pay_price_2.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_2.TabIndex = 8;
            this.lbl_pay_price_2.Text = "pay_price_2 * 0.9";
            // 
            // lbl_pay_price_5
            // 
            this.lbl_pay_price_5.AutoSize = true;
            this.lbl_pay_price_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_5.Location = new System.Drawing.Point(457, 214);
            this.lbl_pay_price_5.Name = "lbl_pay_price_5";
            this.lbl_pay_price_5.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_5.TabIndex = 9;
            this.lbl_pay_price_5.Text = "pay_price_5 * 0.1";
            // 
            // lbl_pay_date_2
            // 
            this.lbl_pay_date_2.AutoSize = true;
            this.lbl_pay_date_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_date_2.Location = new System.Drawing.Point(4, 256);
            this.lbl_pay_date_2.Name = "lbl_pay_date_2";
            this.lbl_pay_date_2.Size = new System.Drawing.Size(68, 12);
            this.lbl_pay_date_2.TabIndex = 10;
            this.lbl_pay_date_2.Text = "pay_date_2";
            // 
            // lbl_stock_id
            // 
            this.lbl_stock_id.AutoSize = true;
            this.lbl_stock_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_stock_id.Location = new System.Drawing.Point(81, 256);
            this.lbl_stock_id.Name = "lbl_stock_id";
            this.lbl_stock_id.Size = new System.Drawing.Size(51, 12);
            this.lbl_stock_id.TabIndex = 11;
            this.lbl_stock_id.Text = "stock_id";
            // 
            // lbl_pay_count
            // 
            this.lbl_pay_count.AutoSize = true;
            this.lbl_pay_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_count.Location = new System.Drawing.Point(311, 256);
            this.lbl_pay_count.Name = "lbl_pay_count";
            this.lbl_pay_count.Size = new System.Drawing.Size(63, 12);
            this.lbl_pay_count.TabIndex = 12;
            this.lbl_pay_count.Text = "pay_count";
            // 
            // lbl_pay_price_3
            // 
            this.lbl_pay_price_3.AutoSize = true;
            this.lbl_pay_price_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_3.Location = new System.Drawing.Point(552, 256);
            this.lbl_pay_price_3.Name = "lbl_pay_price_3";
            this.lbl_pay_price_3.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_3.TabIndex = 13;
            this.lbl_pay_price_3.Text = "pay_price_3 * 0.9";
            // 
            // lbl_pay_price_1
            // 
            this.lbl_pay_price_1.AutoSize = true;
            this.lbl_pay_price_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_1.Location = new System.Drawing.Point(383, 256);
            this.lbl_pay_price_1.Name = "lbl_pay_price_1";
            this.lbl_pay_price_1.Size = new System.Drawing.Size(72, 12);
            this.lbl_pay_price_1.TabIndex = 14;
            this.lbl_pay_price_1.Text = "pay_price_1";
            // 
            // lbl_pay_price_4
            // 
            this.lbl_pay_price_4.AutoSize = true;
            this.lbl_pay_price_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_4.Location = new System.Drawing.Point(743, 256);
            this.lbl_pay_price_4.Name = "lbl_pay_price_4";
            this.lbl_pay_price_4.Size = new System.Drawing.Size(102, 12);
            this.lbl_pay_price_4.TabIndex = 15;
            this.lbl_pay_price_4.Text = "pay_price_4 * 0.1";
            // 
            // lbl_pay_price_6
            // 
            this.lbl_pay_price_6.AutoSize = true;
            this.lbl_pay_price_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_pay_price_6.Location = new System.Drawing.Point(4, 367);
            this.lbl_pay_price_6.Name = "lbl_pay_price_6";
            this.lbl_pay_price_6.Size = new System.Drawing.Size(91, 12);
            this.lbl_pay_price_6.TabIndex = 16;
            this.lbl_pay_price_6.Text = "lbl_pay_price_6";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(882, 388);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 334);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Exit.Location = new System.Drawing.Point(914, 9);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(36, 36);
            this.pb_Exit.TabIndex = 33;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label13.Location = new System.Drawing.Point(5, -9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 54);
            this.label13.TabIndex = 34;
            this.label13.Text = "JinShop";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 54);
            this.panel1.TabIndex = 37;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "결제 정보";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Tax_Ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 414);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tax_Ex";
            this.Text = "Tax_Ex";
            this.Load += new System.EventHandler(this.Tax_Ex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}