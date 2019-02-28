namespace JinTeamForAdmin.Bus
{
    partial class Inquire_Admin_Detail
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
            this.txt_body = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_inq_no = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_redate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(14, 254);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.ReadOnly = true;
            this.txt_body.Size = new System.Drawing.Size(456, 196);
            this.txt_body.TabIndex = 2;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(14, 209);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(456, 21);
            this.txt_title.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(15, 114);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(206, 21);
            this.txt_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "문의자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "문의 제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "문의 내용";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(263, 162);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(206, 21);
            this.txt_date.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "문의 날짜";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 79);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "첨부 이미지";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(315, 618);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "답글 달기";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(396, 618);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "취소";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "문의 타입";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(14, 162);
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(206, 21);
            this.txt_type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "문의 번호";
            // 
            // lbl_inq_no
            // 
            this.lbl_inq_no.AutoSize = true;
            this.lbl_inq_no.Location = new System.Drawing.Point(75, 71);
            this.lbl_inq_no.Name = "lbl_inq_no";
            this.lbl_inq_no.Size = new System.Drawing.Size(63, 12);
            this.lbl_inq_no.TabIndex = 18;
            this.lbl_inq_no.Text = "inquire_no";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "이메일";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(263, 114);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(206, 21);
            this.txt_email.TabIndex = 19;
            // 
            // lbl_redate
            // 
            this.lbl_redate.AutoSize = true;
            this.lbl_redate.Location = new System.Drawing.Point(75, 632);
            this.lbl_redate.Name = "lbl_redate";
            this.lbl_redate.Size = new System.Drawing.Size(29, 12);
            this.lbl_redate.TabIndex = 22;
            this.lbl_redate.Text = "없음";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "답변 날짜";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 54);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(163, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "문의 정보";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Exit.Location = new System.Drawing.Point(434, 7);
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
            this.label13.Location = new System.Drawing.Point(3, -7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 54);
            this.label13.TabIndex = 34;
            this.label13.Text = "JinShop";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Inquire_Admin_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(480, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_redate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_inq_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inquire_Admin_Detail";
            this.Text = "Inquire_Admin_Detail";
            this.Load += new System.EventHandler(this.Inquire_Admin_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_body;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_inq_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_redate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}