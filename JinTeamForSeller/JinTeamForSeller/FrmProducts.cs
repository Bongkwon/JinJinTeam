using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForSeller
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void gViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gViewProducts[e.ColumnIndex, e.RowIndex] != null)
            {
                FrmDetailPro detail = new FrmDetailPro();
                detail.Show();
            }
        }
    }
}
