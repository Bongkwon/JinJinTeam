using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class SalesManagementVO
    {
        private string pro_Name;

        public string Pro_Name
        {
            get { return pro_Name; }
            set { pro_Name = value; }
        }
        private string stock_ID;

        public string Stock_ID
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }
        private int pay_Count;

        public int Pay_Count
        {
            get { return pay_Count; }
            set { pay_Count = value; }
        }
        private int pay_Price;

        public int Pay_Price
        {
            get { return pay_Price; }
            set { pay_Price = value; }
        }
        private DateTime pay_Date;

        public DateTime Pay_Date
        {
            get { return pay_Date; }
            set { pay_Date = new DateTime(value.Year, value.Month, value.Day); }
        }

        public SalesManagementVO(string pro_Name, string stock_ID, int pay_Count, int pay_Price, DateTime pay_Date)
        {
            this.pro_Name = pro_Name;
            this.stock_ID = stock_ID;
            this.pay_Count = pay_Count;
            this.pay_Price = pay_Price;
            this.pay_Date = new DateTime(pay_Date.Year, pay_Date.Month, pay_Date.Day);
        }
    }
}
