using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Dao;

namespace JinTeamForSeller
{
    public partial class FrmProducts : Form
    {
        DataGridViewRow dr;
        ProductDAO pro = new ProductDAO();
        public FrmProducts()
        {
            InitializeComponent();
        }
        

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            List<Product> lstPro = pro.select_proEachSeller(Form1.CompanyNo);
            gViewProducts.DataSource = lstPro;
            gViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gViewProducts.Columns["Main_Image"].Visible = false;
            dr = gViewProducts.Rows[0];
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Gray;
            //style.
            gViewProducts.DefaultCellStyle = style;
            gViewProducts.Columns["Seller_NO"].Visible = false;
            gViewProducts.Columns["Sub_Comment"].Visible = false;
            gViewProducts.Columns["Main_Comment"].Visible = false;
            gViewProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            gViewProducts.EnableHeadersVisualStyles = false;
            
        }

        private void gViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gViewProducts[e.ColumnIndex, e.RowIndex] != null)
                {                    
                    FrmDetailPro detail = new FrmDetailPro(gViewProducts.Rows[e.RowIndex]);
                    detail.ShowDialog();
                    this.OnLoad(null);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnInsertPro_Click(object sender, EventArgs e)
        {
            FrmInsertProduct frm = new FrmInsertProduct();
            frm.ShowDialog();
            this.OnLoad(null);            
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            if (dr != null)
            {
                FrmDetailPro detail = new FrmDetailPro(dr);
                detail.Show();
            }
        }

        private void gViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                if (gViewProducts[e.ColumnIndex, e.RowIndex] != null)
                {
                    dr = gViewProducts.Rows[e.RowIndex];
                }                
            }
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (pro.DeleteProduct(dr.Cells["Pro_ID"].Value.ToString()))
                {
                    MessageBox.Show("삭제 되었습니다.");
                    this.OnLoad(null);
                }
                else
                {
                    MessageBox.Show("삭제 실패");
                }
            }            
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            this.OnLoad(null);
        }

        private void btnManagePro_Click(object sender, EventArgs e)
        {
            FrmSellAndTransport frm = new FrmSellAndTransport();
            frm.Show();
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
