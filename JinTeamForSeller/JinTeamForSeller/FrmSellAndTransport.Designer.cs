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
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewPayInfo
            // 
            this.gViewPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewPayInfo.Location = new System.Drawing.Point(13, 13);
            this.gViewPayInfo.Name = "gViewPayInfo";
            this.gViewPayInfo.RowTemplate.Height = 23;
            this.gViewPayInfo.Size = new System.Drawing.Size(775, 361);
            this.gViewPayInfo.TabIndex = 0;
            // 
            // FrmSellAndTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gViewPayInfo);
            this.Name = "FrmSellAndTransport";
            this.Text = "FrmSellAndTransport";
            this.Load += new System.EventHandler(this.FrmSellAndTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewPayInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gViewPayInfo;
    }
}