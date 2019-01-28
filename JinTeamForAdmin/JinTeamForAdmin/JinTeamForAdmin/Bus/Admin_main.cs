using JinTeamForAdmin.Bus;
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
        //List<Customers_Vo> cus_lst;
        List<object> ob_lst;
        //List<Seller_Vo> sell_lst;
        
        string sp = "";
        string type_p = "";
        public Admin_main()
        {
            InitializeComponent();
            //cus_lst = new List<Customers_Vo>();
            ob_lst = new List<object>();
            //sell_lst = new List<Seller_Vo>();
        }


        private void seller목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_seller.Checked = true;
            seller_changed(null, null);
        }

        private void products목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_pro.Checked = true;
            pro_changed(null, null);
        }

        private void customer목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_cus.Checked = true;
            cus_Changed(null, null);
        }

        private void cus_Changed(object sender, EventArgs e)
        {
            //dataGridView1.Columns["Cus_no"].HeaderText = "번호";
            //dataGridView1.Columns["cus_phone"].Visible = false;
            //MessageBox.Show(DateTime.Now.ToString());
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = true;


            ob_lst.Clear();
            dataGridView1.DataSource = null;
            type_p = "cus";
            if (rdo_all_cus.Checked)
            {
                sp = "select_cus";
            }
            else
            {
                sp = "select_cus_withdrawal";
            }
            ob_lst = new Admin_Dao().Select_ob(sp, type_p);
            dataGridView1.DataSource = ob_lst;
        }

        private void pro_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;


            ob_lst.Clear();
            dataGridView1.DataSource = null;
            type_p = "pro";
            if (rdo_all_pro.Checked)
            {
                sp = "select_pro";
            }
            else
            {
                sp = "select_pro_state_0";
            }

            ob_lst = new Admin_Dao().Select_ob(sp, type_p);
            dataGridView1.DataSource = ob_lst;
        }

        private void seller_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = true;
            gb_pro.Visible = false;
            gb_cus.Visible = false;


            dataGridView1.DataSource = null;
            ob_lst.Clear();
            type_p = "sel";
            if (rdo_all_seller.Checked)
            {
                sp = "select_seller";
            }
            else
            {
                sp = "select_seller_join_0";
            }

            ob_lst = new Admin_Dao().Select_ob(sp, type_p);
            dataGridView1.DataSource = ob_lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = "delete_cus";
            if (new Admin_Dao().Delete_Gv(sp))
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

        private void Admin_main_Load(object sender, EventArgs e)
        {
            rdo_all_seller.Checked = true;
            seller_changed(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gb_seller.Visible)
            {
                seller_Detail sd = new seller_Detail(ob_lst[e.RowIndex]);
                sd.ShowDialog();
                rdo_all_seller.Checked = true;
                seller_changed(null, null);
            }
            else if(gb_pro.Visible)
            {
                pro_Detail pd = new pro_Detail(ob_lst[e.RowIndex]);
                pd.ShowDialog();
            }
            else         // gb_cus.visible
            {
                cus_Detail cd = new cus_Detail();
                cd.ShowDialog();
            }

            
        }
    }
}
