using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin.Vo
{
    public class TaxBill_Vo
    {
        private int pay_ID;

        public int Pay_ID
        {
            get { return pay_ID; }
            set { pay_ID = value; }
        }
        private string stock_ID;

        public string Stock_ID
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }
        private string seller_ID;

        public string Seller_ID
        {
            get { return seller_ID; }
            set { seller_ID = value; }
        }
        private string seller_boss;

        public string Seller_boss
        {
            get { return seller_boss; }
            set { seller_boss = value; }
        }
        private string corporate_registration_no;

        public string Corporate_registration_no
        {
            get { return corporate_registration_no; }
            set { corporate_registration_no = value; }
        }
        private int pay_price;

        public int Pay_price
        {
            get { return pay_price; }
            set { pay_price = value; }
        }
        private int pay_count;

        public int Pay_count
        {
            get { return pay_count; }
            set { pay_count = value; }
        }
        private string pay_date;

        public string Pay_date
        {
            get { return pay_date; }
            set { pay_date = value; }
        }


        private string  seller_addr;

        public string  Seller_addr
        {
            get { return seller_addr; }
            set { seller_addr = value; }
        }

        private string output_date_tax;

        public string Output_date_tax
        {
            get { return output_date_tax; }
            set { output_date_tax = value; }
        }

    }
}
