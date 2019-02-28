namespace JinTeamForAdmin.Bus
{
    partial class Sales_Manager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rd_Price = new System.Windows.Forms.RadioButton();
            this.rd_Count = new System.Windows.Forms.RadioButton();
            this.rd_mm = new System.Windows.Forms.RadioButton();
            this.rd_dd = new System.Windows.Forms.RadioButton();
            this.gb_sales_S_C = new System.Windows.Forms.GroupBox();
            this.gb_sales_D_M = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            this.gb_sales_S_C.SuspendLayout();
            this.gb_sales_D_M.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_sales
            // 
            this.chart_sales.BackColor = System.Drawing.Color.LightGray;
            this.chart_sales.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_sales.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart_sales.BorderSkin.PageColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.LightGray;
            legend1.Name = "Legend1";
            this.chart_sales.Legends.Add(legend1);
            this.chart_sales.Location = new System.Drawing.Point(0, 98);
            this.chart_sales.Name = "chart_sales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_sales.Series.Add(series1);
            this.chart_sales.Size = new System.Drawing.Size(509, 389);
            this.chart_sales.TabIndex = 0;
            this.chart_sales.Text = "chart_sales";
            this.chart_sales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // rd_Price
            // 
            this.rd_Price.AutoSize = true;
            this.rd_Price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.rd_Price.Location = new System.Drawing.Point(3, 12);
            this.rd_Price.Name = "rd_Price";
            this.rd_Price.Size = new System.Drawing.Size(60, 20);
            this.rd_Price.TabIndex = 1;
            this.rd_Price.TabStop = true;
            this.rd_Price.Text = "매출";
            this.rd_Price.UseVisualStyleBackColor = true;
            this.rd_Price.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_Count
            // 
            this.rd_Count.AutoSize = true;
            this.rd_Count.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.rd_Count.Location = new System.Drawing.Point(69, 12);
            this.rd_Count.Name = "rd_Count";
            this.rd_Count.Size = new System.Drawing.Size(94, 20);
            this.rd_Count.TabIndex = 2;
            this.rd_Count.TabStop = true;
            this.rd_Count.Text = "주문건수";
            this.rd_Count.UseVisualStyleBackColor = true;
            this.rd_Count.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_mm
            // 
            this.rd_mm.AutoSize = true;
            this.rd_mm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd_mm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.rd_mm.Location = new System.Drawing.Point(69, 12);
            this.rd_mm.Name = "rd_mm";
            this.rd_mm.Size = new System.Drawing.Size(60, 20);
            this.rd_mm.TabIndex = 7;
            this.rd_mm.TabStop = true;
            this.rd_mm.Text = "월별";
            this.rd_mm.UseVisualStyleBackColor = true;
            this.rd_mm.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_dd
            // 
            this.rd_dd.AutoSize = true;
            this.rd_dd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rd_dd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.rd_dd.Location = new System.Drawing.Point(3, 12);
            this.rd_dd.Name = "rd_dd";
            this.rd_dd.Size = new System.Drawing.Size(60, 20);
            this.rd_dd.TabIndex = 6;
            this.rd_dd.TabStop = true;
            this.rd_dd.Text = "일별";
            this.rd_dd.UseVisualStyleBackColor = true;
            this.rd_dd.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // gb_sales_S_C
            // 
            this.gb_sales_S_C.BackColor = System.Drawing.Color.LightGray;
            this.gb_sales_S_C.Controls.Add(this.rd_Price);
            this.gb_sales_S_C.Controls.Add(this.rd_Count);
            this.gb_sales_S_C.Location = new System.Drawing.Point(0, 57);
            this.gb_sales_S_C.Name = "gb_sales_S_C";
            this.gb_sales_S_C.Size = new System.Drawing.Size(167, 39);
            this.gb_sales_S_C.TabIndex = 8;
            this.gb_sales_S_C.TabStop = false;
            // 
            // gb_sales_D_M
            // 
            this.gb_sales_D_M.BackColor = System.Drawing.Color.LightGray;
            this.gb_sales_D_M.Controls.Add(this.rd_mm);
            this.gb_sales_D_M.Controls.Add(this.rd_dd);
            this.gb_sales_D_M.Location = new System.Drawing.Point(173, 57);
            this.gb_sales_D_M.Name = "gb_sales_D_M";
            this.gb_sales_D_M.Size = new System.Drawing.Size(157, 38);
            this.gb_sales_D_M.TabIndex = 9;
            this.gb_sales_D_M.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(517, 54);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(168, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "매출 정보";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Exit.Location = new System.Drawing.Point(467, 9);
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
            this.label13.Location = new System.Drawing.Point(5, -5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 54);
            this.label13.TabIndex = 34;
            this.label13.Text = "JinShop";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Sales_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(518, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_sales_S_C);
            this.Controls.Add(this.gb_sales_D_M);
            this.Controls.Add(this.chart_sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Manager";
            this.Text = "Sales_Manager";
            this.Load += new System.EventHandler(this.Sales_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            this.gb_sales_S_C.ResumeLayout(false);
            this.gb_sales_S_C.PerformLayout();
            this.gb_sales_D_M.ResumeLayout(false);
            this.gb_sales_D_M.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
        private System.Windows.Forms.RadioButton rd_Price;
        private System.Windows.Forms.RadioButton rd_Count;
        private System.Windows.Forms.RadioButton rd_mm;
        private System.Windows.Forms.RadioButton rd_dd;
        private System.Windows.Forms.GroupBox gb_sales_S_C;
        private System.Windows.Forms.GroupBox gb_sales_D_M;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label label13;
    }
}