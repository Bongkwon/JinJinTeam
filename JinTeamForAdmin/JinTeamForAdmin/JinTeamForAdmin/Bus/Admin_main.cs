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
        
        string sp = "";
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

            cuslst.Clear();
            dataGridView1.DataSource = null;
            if (rdo_all_cus.Checked)
            {               
                sp = "select_cus";                 
            }
            else
            {
                sp = "select_cus_withdrawal";
            }
            cuslst = new Admin_Dao().Select_cus(sp);
            dataGridView1.DataSource = cuslst;
        }

        private void products목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;

            
        }

        private void cus_Changed(object sender, EventArgs e)
        {
            
            cuslst.Clear();
            dataGridView1.DataSource = null;
            if (rdo_all_cus.Checked)
            {
                sp = "select_cus";
            }
            else
            {
                sp = "select_cus_withdrawal";
            }
            cuslst = new Admin_Dao().Select_cus(sp);
            dataGridView1.DataSource = cuslst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = "delete_cus";
            if (new Admin_Dao().Delete_cus(sp))
            {
                MessageBox.Show("정리 되었습니다");
                //Admin_main();
                cus_Changed(null, null);
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }
    }
}
