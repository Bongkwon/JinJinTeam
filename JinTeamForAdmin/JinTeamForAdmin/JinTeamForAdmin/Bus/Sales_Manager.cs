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

namespace JinTeamForAdmin.Bus
{
    public partial class Sales_Manager : Form
    {
        List<Sales_manager_Vo> sales_lst;
        List<object> ob_lst;

        public Sales_Manager()
        {
            InitializeComponent();
            sales_lst = new List<Sales_manager_Vo>();
            ob_lst = new List<object>();
        }


        private void Sales_Manager_Load(object sender, EventArgs e)
        {
            sales_lst.Clear();
            string type_s = "sal";
            string sp = "Select_sales";
            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            foreach (var item in ob_lst)
            {
                sales_lst.Add((Sales_manager_Vo)item);
            }

            int a = 0;

            //for (int i = 0; i < sales_lst.Count; i++)
            //{
            //    for (int j = 0; j < sales_lst.Count; j++)
            //    {
            //        if (sales_lst[i].Pay_date == sales_lst[j].Pay_date)
            //        {
            //            a += 1;
            //        }
            //    }
            //}

            label1.Text = a + "";

            chart1.Series[0].Points.DataBind(sales_lst, "pay_date", "pay_count", null);
            dataGridView1.DataSource = sales_lst;
        }
    }
}
