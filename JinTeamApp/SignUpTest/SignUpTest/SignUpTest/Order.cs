using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpTest
{
    class Order
    {
        private string order_ID;

        public string Order_Id
        {
            get { return order_ID; }
            set { order_ID = value; }
        }

        private int cus_no;

        public int Cus_No
        {
            get { return cus_no; }
            set { cus_no = value; }
        }

        private string stock_ID;

        public string Stock_Id
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }

        private int order_count;

        public int Order_Count
        {
            get { return order_count; }
            set { order_count = value; }
        }

        private int order_price;

        public int Order_Price
        {
            get { return order_price; }
            set { order_price = value; }
        }

        private string order_require;

        public string Order_Require
        {
            get { return order_require; }
            set { order_require = value; }
        }
    }
}
