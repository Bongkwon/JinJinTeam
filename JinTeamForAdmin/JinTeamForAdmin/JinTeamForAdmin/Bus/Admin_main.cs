using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForSeller.Bus
{
    public partial class Admin_main : Form
    {
        List<Customers_Vo> cuslst;
        public Admin_main()
        {
            InitializeComponent();
            cuslst = new List<Customers_Vo>();
        }


        private void seller목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_seller.Visible = true;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
        }

        private void customer목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
            //dataGridView1.Columns["Cus_no"].HeaderText = "번호";
            //dataGridView1.Columns["cus_phone"].Visible = false;
            //MessageBox.Show(DateTime.Now.ToString());
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = true;

            if (rdo_all_cus.Checked)
            {
                cuslst.Clear();
                dataGridView1.DataSource = null;
                cuslst = new Admin_Dao().Select_cus_all();
                dataGridView1.DataSource = cuslst;
            }
            else
            {

            }
        }

        private void products목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;
        }
    }
}
