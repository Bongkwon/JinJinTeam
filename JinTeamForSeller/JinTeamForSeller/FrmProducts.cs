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
        ProductDao pro = new ProductDao();
        public FrmProducts()
        {
            InitializeComponent();
        }
        

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            List<Product> lstPro = pro.select_proEachSeller(Form1.CompanyNo);
            gViewProducts.DataSource = lstPro;
        }

        private void gViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gViewProducts[e.ColumnIndex, e.RowIndex] != null)
                {                    
                    FrmDetailPro detail = new FrmDetailPro(gViewProducts.Rows[e.RowIndex]);
                    detail.Show();
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
            if (gViewProducts[e.ColumnIndex, e.RowIndex] != null)
            {
                dr = gViewProducts.Rows[e.RowIndex];                
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
    }
}
