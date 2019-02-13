namespace JinTeamForSeller
{
    partial class FrmSaleManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPicFromDate = new System.Windows.Forms.DateTimePicker();
            this.dTPicToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoDayDay = new System.Windows.Forms.RadioButton();
            this.rdoMonthMonth = new System.Windows.Forms.RadioButton();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(775, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "총 매출액 : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(752, 485);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 12);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "43214";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(605, 485);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(35, 12);
            this.lblTotalCount.TabIndex = 4;
            this.lblTotalCount.Text = "43214";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "총 판매량 : ";
            // 
            // dTPicFromDate
            // 
            this.dTPicFromDate.Location = new System.Drawing.Point(12, 12);
            this.dTPicFromDate.Name = "dTPicFromDate";
            this.dTPicFromDate.Size = new System.Drawing.Size(113, 21);
            this.dTPicFromDate.TabIndex = 5;
            // 
            // dTPicToDate
            // 
            this.dTPicToDate.Location = new System.Drawing.Point(151, 12);
            this.dTPicToDate.Name = "dTPicToDate";
            this.dTPicToDate.Size = new System.Drawing.Size(113, 21);
            this.dTPicToDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "까지";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "매출 분석";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoDayDay
            // 
            this.rdoDayDay.AutoSize = true;
            this.rdoDayDay.Location = new System.Drawing.Point(440, 14);
            this.rdoDayDay.Name = "rdoDayDay";
            this.rdoDayDay.Size = new System.Drawing.Size(47, 16);
            this.rdoDayDay.TabIndex = 10;
            this.rdoDayDay.Text = "일별";
            this.rdoDayDay.UseVisualStyleBackColor = true;
            // 
            // rdoMonthMonth
            // 
            this.rdoMonthMonth.AutoSize = true;
            this.rdoMonthMonth.Checked = true;
            this.rdoMonthMonth.Location = new System.Drawing.Point(387, 14);
            this.rdoMonthMonth.Name = "rdoMonthMonth";
            this.rdoMonthMonth.Size = new System.Drawing.Size(47, 16);
            this.rdoMonthMonth.TabIndex = 11;
            this.rdoMonthMonth.TabStop = true;
            this.rdoMonthMonth.Text = "월별";
            this.rdoMonthMonth.UseVisualStyleBackColor = true;
            // 
            // chartSales
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSales.Legends.Add(legend2);
            this.chartSales.Location = new System.Drawing.Point(11, 39);
            this.chartSales.Name = "chartSales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSales.Series.Add(series2);
            this.chartSales.Size = new System.Drawing.Size(476, 323);
            this.chartSales.TabIndex = 12;
            this.chartSales.Text = "chart1";
            // 
            // FrmSaleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.rdoMonthMonth);
            this.Controls.Add(this.rdoDayDay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPicToDate);
            this.Controls.Add(this.dTPicFromDate);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSaleManagement";
            this.Text = "FrmSaleManagement";
            this.Load += new System.EventHandler(this.FrmSaleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPicFromDate;
        private System.Windows.Forms.DateTimePicker dTPicToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoDayDay;
        private System.Windows.Forms.RadioButton rdoMonthMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
    }
}