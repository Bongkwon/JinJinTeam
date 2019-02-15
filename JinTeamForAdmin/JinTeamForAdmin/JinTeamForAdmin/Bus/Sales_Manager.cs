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
using System.Windows.Forms.DataVisualization.Charting;

namespace JinTeamForAdmin.Bus
{
    public partial class Sales_Manager : Form
    {
        List<Sales_manager_Vo> sales_lst;
        List<Sales_manager_Vo> sales_sub_lst;
        List<object> ob_lst;

        public Sales_Manager()
        {
            InitializeComponent();
            sales_lst = new List<Sales_manager_Vo>();
            sales_sub_lst = new List<Sales_manager_Vo>();
            ob_lst = new List<object>();
        }


        private void Sales_Manager_Load(object sender, EventArgs e)
        {
            sales_lst.Clear();
            sales_sub_lst.Clear();

            string type_s = "sal";
            string sp = "Select_sales";
            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            foreach (var item in ob_lst)
            {
                sales_lst.Add((Sales_manager_Vo)item);
            }

            dataGridView1.DataSource = sales_lst;


            //textBox1.Text += sales_sub_lst[0].Pay_date + sales_sub_lst[0].Pay_price;

            rd_Price.Checked = true;
            rd_dd.Checked = true;
        }


        private void rd_CheckedChanged(object sender, EventArgs e)
        {

            if (rd_Price.Checked && rd_dd.Checked)
            {
                Sales_day("Pay_price");
            }
            else if (rd_Count.Checked && rd_dd.Checked)
            {
                Sales_day("Pay_count");
            }
            else if (rd_Price.Checked && rd_mm.Checked)
            {
                Sales_month("Pay_price");
            }
            else if (rd_Count.Checked && rd_mm.Checked)
            {
                Sales_month("Pay_count");
            }
        }

        private void Sales_month(string pay_type)
        {
            sales_sub_lst.Clear();
            textBox1.Clear();
            var result = from sales in sales_lst
                             //orderby sales.Pay_date descending
                         group sales by sales.Pay_date_m;

            foreach (var itemG in result)
            {
                int price = 0;
                int count = 0;
                string name = "";
                int mm = 0;
                textBox1.Text += itemG.Key;
                textBox1.Text += Environment.NewLine;
                foreach (var itemK in itemG)
                {
                    price += (itemK.Pay_price * itemK.Pay_count);
                    count += 1;
                    name = itemK.Seller_ID;
                    mm = Int32.Parse(itemK.Pay_date_m);
                    textBox1.Text += " : " + itemK.Pay_date + " " + itemK.Pay_price + " " + price + " " + count;
                    textBox1.Text += Environment.NewLine;
                }
                if (sales_sub_lst.Count < 3)
                {
                    sales_sub_lst.Add(new Sales_manager_Vo
                    {
                        Seller_ID = name,
                        Pay_date_m = mm.ToString(),
                        Pay_count = count,
                        Pay_price = price
                    });
                }
            }

            chart1.Series[0].Points.DataBind(sales_sub_lst, "pay_date_m", pay_type, null);
        }
        private void Sales_day(string pay_type)
        {
            sales_sub_lst.Clear();
            textBox1.Clear();
            var result = from sales in sales_lst
                         orderby sales.Pay_date descending
                         group sales by sales.Pay_date;

            //group sales by sales.Pay_date.Substring(sales.Pay_date.IndexOf("-") + 1, 2);

            foreach (var itemG in result)
            {
                int price = 0;
                int count = 0;
                string name = "";
                int mm = 0;
                textBox1.Text += itemG.Key + " 금액 : ";

                foreach (var itemK in itemG)
                {
                    price += (itemK.Pay_price * itemK.Pay_count);
                    //count += itemK.Pay_count;
                    count += 1;
                    name = itemK.Seller_ID;
                    mm = Int32.Parse(itemK.Pay_date_m);
                }
                textBox1.Text += price.ToString() + " 주문 건수 : " + count.ToString() + " " + name + Environment.NewLine;
                if (sales_sub_lst.Count < 3)
                {
                    sales_sub_lst.Add(new Sales_manager_Vo
                    {
                        Seller_ID = name,
                        Pay_price = price,
                        Pay_count = count,
                        Pay_date = itemG.Key.Substring(5),
                        Pay_date_m = mm.ToString()
                    });
                }
            }
            //textBox1.Text += sales_sub_lst[0].Pay_date + sales_sub_lst[0].Pay_price;
            sales_sub_lst.Reverse();

            // chart1.Series[0].Points.DataBind(sales_sub_lst, "pay_date", "Pay_price", null);
            chart1.Series[0].Points.DataBind(sales_sub_lst, "pay_date", pay_type, null);
        }


        Point? previous = null;
        ToolTip myToolTip = new ToolTip();

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chart1.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var name = sales_sub_lst[hit.PointIndex].Seller_ID;
                var price = sales_sub_lst[hit.PointIndex].Pay_price;
                var count = sales_sub_lst[hit.PointIndex].Pay_count;
                string date = "";

                if (rd_dd.Checked)
                {
                    date = sales_sub_lst[hit.PointIndex].Pay_date;
                }
                else if (rd_mm.Checked)
                {
                    date = sales_sub_lst[hit.PointIndex].Pay_date_m + "월";                  
                }
                myToolTip.Show("회사 : " + name + Environment.NewLine
                                       + "매출 : " + price + Environment.NewLine +
                                       "건수 : " + count + Environment.NewLine +
                                       "날짜 : " + date
                                       , chart1, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }
    }
}
