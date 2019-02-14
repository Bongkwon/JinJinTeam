using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class Payment_InfoVO
    {
        private int pay_ID;

        public int Pay_ID
        {
            get { return pay_ID; }
            set { pay_ID = value; }
        }
        private string order_ID;

        public string Order_ID
        {
            get { return order_ID; }
            set { order_ID = value; }
        }
        private string user_Ship_ID;

        public string User_Ship_ID
        {
            get { return user_Ship_ID; }
            set { user_Ship_ID = value; }
        }
        private string stock_ID;

        public string Stock_ID
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }
        private int seller_No;

        public int Seller_No
        {
            get { return seller_No; }
            set { seller_No = value; }
        }
        private int pay_count;

        public int Pay_count
        {
            get { return pay_count; }
            set { pay_count = value; }
        }

        private int pay_Price;

        public int Pay_Price
        {
            get { return pay_Price; }
            set { pay_Price = value; }
        }
        private string waybill_ID;

        public string Waybill_ID
        {
            get { return waybill_ID; }
            set { waybill_ID = value; }
        }
        private string cus_name;

        public string Cus_name
        {
            get { return cus_name; }
            set { cus_name = value; }
        }
        private string user_addr;

        public string User_addr
        {
            get { return user_addr; }
            set { user_addr = value; }
        }
        private string user_name;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }

        private string order_require;

        
        private string transport_state;

        public string Transport_state
        {
            get { return transport_state; }
            set { transport_state = value; }
        }
        public string Order_require
        {
            get { return order_require; }
            set { order_require = value; }
        }
        private string ship_require;

        public string Ship_require
        {
            get { return ship_require; }
            set { ship_require = value; }
        }

        public Payment_InfoVO(int pay_ID, string order_ID, string user_Ship_ID, int seller_No, int pay_count, int pay_Price, string waybill_ID)
        {
            this.pay_ID = pay_ID;
            this.order_ID = order_ID;
            this.user_Ship_ID = user_Ship_ID;
            this.seller_No = seller_No;
            this.pay_count = pay_count;
            this.pay_Price = pay_Price;
            this.waybill_ID = waybill_ID;
        }

        public Payment_InfoVO()
        {

        }

        public Payment_InfoVO(int pay_ID, string order_ID, string user_Ship_ID, int seller_No, int pay_count, int pay_Price, string waybill_ID, string cus_name, string user_addr, string stock_ID, string order_require, string ship_require, string transport_state, string user_name) : this(pay_ID, order_ID, user_Ship_ID, seller_No, pay_count, pay_Price, waybill_ID)
        {
            this.cus_name = cus_name;
            this.user_addr = user_addr;
            this.stock_ID = stock_ID;
            this.order_require = order_require;
            this.ship_require = ship_require;
            this.transport_state = transport_state;
            this.user_name = user_name;
        }
    }
}
