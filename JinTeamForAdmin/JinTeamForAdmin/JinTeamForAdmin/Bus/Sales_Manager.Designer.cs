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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rd_Price = new System.Windows.Forms.RadioButton();
            this.rd_Count = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rd_mm = new System.Windows.Forms.RadioButton();
            this.rd_dd = new System.Windows.Forms.RadioButton();
            this.gb_sales_S_C = new System.Windows.Forms.GroupBox();
            this.gb_sales_D_M = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_sales_S_C.SuspendLayout();
            this.gb_sales_D_M.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(411, 389);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // rd_Price
            // 
            this.rd_Price.AutoSize = true;
            this.rd_Price.Location = new System.Drawing.Point(0, 10);
            this.rd_Price.Name = "rd_Price";
            this.rd_Price.Size = new System.Drawing.Size(47, 16);
            this.rd_Price.TabIndex = 1;
            this.rd_Price.TabStop = true;
            this.rd_Price.Text = "매출";
            this.rd_Price.UseVisualStyleBackColor = true;
            this.rd_Price.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_Count
            // 
            this.rd_Count.AutoSize = true;
            this.rd_Count.Location = new System.Drawing.Point(97, 10);
            this.rd_Count.Name = "rd_Count";
            this.rd_Count.Size = new System.Drawing.Size(71, 16);
            this.rd_Count.TabIndex = 2;
            this.rd_Count.TabStop = true;
            this.rd_Count.Text = "주문건수";
            this.rd_Count.UseVisualStyleBackColor = true;
            this.rd_Count.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(658, 108);
            this.dataGridView1.TabIndex = 5;
            // 
            // rd_mm
            // 
            this.rd_mm.AutoSize = true;
            this.rd_mm.Location = new System.Drawing.Point(101, 12);
            this.rd_mm.Name = "rd_mm";
            this.rd_mm.Size = new System.Drawing.Size(47, 16);
            this.rd_mm.TabIndex = 7;
            this.rd_mm.TabStop = true;
            this.rd_mm.Text = "월별";
            this.rd_mm.UseVisualStyleBackColor = true;
            this.rd_mm.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_dd
            // 
            this.rd_dd.AutoSize = true;
            this.rd_dd.Location = new System.Drawing.Point(3, 12);
            this.rd_dd.Name = "rd_dd";
            this.rd_dd.Size = new System.Drawing.Size(47, 16);
            this.rd_dd.TabIndex = 6;
            this.rd_dd.TabStop = true;
            this.rd_dd.Text = "일별";
            this.rd_dd.UseVisualStyleBackColor = true;
            this.rd_dd.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // gb_sales_S_C
            // 
            this.gb_sales_S_C.Controls.Add(this.rd_Price);
            this.gb_sales_S_C.Controls.Add(this.rd_Count);
            this.gb_sales_S_C.Location = new System.Drawing.Point(472, 63);
            this.gb_sales_S_C.Name = "gb_sales_S_C";
            this.gb_sales_S_C.Size = new System.Drawing.Size(195, 33);
            this.gb_sales_S_C.TabIndex = 8;
            this.gb_sales_S_C.TabStop = false;
            // 
            // gb_sales_D_M
            // 
            this.gb_sales_D_M.Controls.Add(this.rd_mm);
            this.gb_sales_D_M.Controls.Add(this.rd_dd);
            this.gb_sales_D_M.Location = new System.Drawing.Point(469, 109);
            this.gb_sales_D_M.Name = "gb_sales_D_M";
            this.gb_sales_D_M.Size = new System.Drawing.Size(197, 36);
            this.gb_sales_D_M.TabIndex = 9;
            this.gb_sales_D_M.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 234);
            this.textBox1.TabIndex = 10;
            // 
            // Sales_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 589);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gb_sales_D_M);
            this.Controls.Add(this.gb_sales_S_C);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Sales_Manager";
            this.Text = "Sales_Manager";
            this.Load += new System.EventHandler(this.Sales_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_sales_S_C.ResumeLayout(false);
            this.gb_sales_S_C.PerformLayout();
            this.gb_sales_D_M.ResumeLayout(false);
            this.gb_sales_D_M.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rd_Price;
        private System.Windows.Forms.RadioButton rd_Count;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rd_mm;
        private System.Windows.Forms.RadioButton rd_dd;
        private System.Windows.Forms.GroupBox gb_sales_S_C;
        private System.Windows.Forms.GroupBox gb_sales_D_M;
        private System.Windows.Forms.TextBox textBox1;
    }
}