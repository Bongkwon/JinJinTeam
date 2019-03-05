namespace JinTeamForSeller
{
    partial class FrmInsertSeller
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtChkPass = new System.Windows.Forms.TextBox();
            this.lblchkPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBossName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCheckOverlap = new System.Windows.Forms.Button();
            this.txtReturnAddr = new System.Windows.Forms.TextBox();
            this.btnInsertPic = new System.Windows.Forms.Button();
            this.imgRegistration = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorpRegistrationNo = new System.Windows.Forms.TextBox();
            this.btnSearchAddr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistration)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtId.Location = new System.Drawing.Point(114, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 14);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtChkPass
            // 
            this.txtChkPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtChkPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChkPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtChkPass.Location = new System.Drawing.Point(114, 132);
            this.txtChkPass.Name = "txtChkPass";
            this.txtChkPass.Size = new System.Drawing.Size(189, 14);
            this.txtChkPass.TabIndex = 3;
            this.txtChkPass.TextChanged += new System.EventHandler(this.txtChkPass_TextChanged);
            // 
            // lblchkPass
            // 
            this.lblchkPass.AutoSize = true;
            this.lblchkPass.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblchkPass.Location = new System.Drawing.Point(14, 135);
            this.lblchkPass.Name = "lblchkPass";
            this.lblchkPass.Size = new System.Drawing.Size(81, 12);
            this.lblchkPass.TabIndex = 2;
            this.lblchkPass.Text = "비밀번호 확인";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtPass.Location = new System.Drawing.Point(114, 105);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(189, 14);
            this.txtPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "회사명";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtEmail.Location = new System.Drawing.Point(114, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 14);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "대표자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "비밀번호";
            // 
            // txtComName
            // 
            this.txtComName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtComName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtComName.Location = new System.Drawing.Point(114, 159);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(189, 14);
            this.txtComName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(14, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "대표 번호";
            // 
            // txtPostal
            // 
            this.txtPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtPostal.Location = new System.Drawing.Point(114, 240);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(113, 14);
            this.txtPostal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(13, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "회사 주소";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtPhone.Location = new System.Drawing.Point(114, 213);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(189, 14);
            this.txtPhone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(10, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "회사 이메일";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtFax.Location = new System.Drawing.Point(114, 364);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(189, 14);
            this.txtFax.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "반품지 주소";
            // 
            // txtAddr
            // 
            this.txtAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtAddr.Location = new System.Drawing.Point(114, 267);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(189, 64);
            this.txtAddr.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(10, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "회사 팩스 번호";
            // 
            // txtBossName
            // 
            this.txtBossName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtBossName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBossName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtBossName.Location = new System.Drawing.Point(114, 186);
            this.txtBossName.Name = "txtBossName";
            this.txtBossName.Size = new System.Drawing.Size(189, 14);
            this.txtBossName.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(14, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "우편번호";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnSubmit.Location = new System.Drawing.Point(505, 418);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 64);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "확인";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCheckOverlap
            // 
            this.btnCheckOverlap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnCheckOverlap.FlatAppearance.BorderSize = 0;
            this.btnCheckOverlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOverlap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnCheckOverlap.Location = new System.Drawing.Point(233, 78);
            this.btnCheckOverlap.Name = "btnCheckOverlap";
            this.btnCheckOverlap.Size = new System.Drawing.Size(70, 21);
            this.btnCheckOverlap.TabIndex = 23;
            this.btnCheckOverlap.Text = "중복 확인";
            this.btnCheckOverlap.UseVisualStyleBackColor = false;
            this.btnCheckOverlap.Click += new System.EventHandler(this.btnCheckOverlap_Click);
            // 
            // txtReturnAddr
            // 
            this.txtReturnAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtReturnAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReturnAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtReturnAddr.Location = new System.Drawing.Point(114, 418);
            this.txtReturnAddr.Multiline = true;
            this.txtReturnAddr.Name = "txtReturnAddr";
            this.txtReturnAddr.Size = new System.Drawing.Size(189, 64);
            this.txtReturnAddr.TabIndex = 26;
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnInsertPic.FlatAppearance.BorderSize = 0;
            this.btnInsertPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnInsertPic.Location = new System.Drawing.Point(416, 391);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(189, 23);
            this.btnInsertPic.TabIndex = 27;
            this.btnInsertPic.Text = "사업자 등록증 첨부";
            this.btnInsertPic.UseVisualStyleBackColor = false;
            this.btnInsertPic.Click += new System.EventHandler(this.btnInsertPic_Click);
            // 
            // imgRegistration
            // 
            this.imgRegistration.Location = new System.Drawing.Point(314, 78);
            this.imgRegistration.Name = "imgRegistration";
            this.imgRegistration.Size = new System.Drawing.Size(291, 280);
            this.imgRegistration.TabIndex = 28;
            this.imgRegistration.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(377, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "※반품지 주소를 따로 입력하시지 않으시면 회사 주소로 지정 됩니다.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.textBox1.Location = new System.Drawing.Point(114, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 14);
            this.textBox1.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(312, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "사업자 등록 번호";
            // 
            // txtCorpRegistrationNo
            // 
            this.txtCorpRegistrationNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.txtCorpRegistrationNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorpRegistrationNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtCorpRegistrationNo.Location = new System.Drawing.Point(416, 364);
            this.txtCorpRegistrationNo.Name = "txtCorpRegistrationNo";
            this.txtCorpRegistrationNo.Size = new System.Drawing.Size(189, 14);
            this.txtCorpRegistrationNo.TabIndex = 31;
            // 
            // btnSearchAddr
            // 
            this.btnSearchAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.btnSearchAddr.FlatAppearance.BorderSize = 0;
            this.btnSearchAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.btnSearchAddr.Location = new System.Drawing.Point(233, 240);
            this.btnSearchAddr.Name = "btnSearchAddr";
            this.btnSearchAddr.Size = new System.Drawing.Size(70, 21);
            this.btnSearchAddr.TabIndex = 33;
            this.btnSearchAddr.Text = "검색";
            this.btnSearchAddr.UseVisualStyleBackColor = false;
            this.btnSearchAddr.Click += new System.EventHandler(this.btnSearchAddr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 72);
            this.panel1.TabIndex = 34;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 54);
            this.label2.TabIndex = 36;
            this.label2.Text = "회원가입";
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
            this.button1.Location = new System.Drawing.Point(552, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.button3.BackgroundImage = global::JinTeamForSeller.Properties.Resources.cancel;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(779, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 49);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmInsertSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(616, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchAddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCorpRegistrationNo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.imgRegistration);
            this.Controls.Add(this.btnInsertPic);
            this.Controls.Add(this.txtReturnAddr);
            this.Controls.Add(this.btnCheckOverlap);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBossName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChkPass);
            this.Controls.Add(this.lblchkPass);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertSeller";
            this.Text = "판매자 회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtChkPass;
        private System.Windows.Forms.Label lblchkPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBossName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCheckOverlap;
        private System.Windows.Forms.Button btnInsertPic;
        private System.Windows.Forms.PictureBox imgRegistration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCorpRegistrationNo;
        private System.Windows.Forms.Button btnSearchAddr;
        internal System.Windows.Forms.TextBox txtPostal;
        internal System.Windows.Forms.TextBox txtAddr;
        internal System.Windows.Forms.TextBox txtReturnAddr;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}