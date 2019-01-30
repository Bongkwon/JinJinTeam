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

        public Payment_InfoVO(int pay_ID, string order_ID, string user_Ship_ID, int seller_No, int pay_count ,int pay_Price, string waybill_ID)
        {
            this.pay_ID = pay_ID;
            this.order_ID = order_ID;
            this.user_Ship_ID = user_Ship_ID;
            this.seller_No = seller_No;
            this.pay_Price = pay_Price;
            this.waybill_ID = waybill_ID;
        }
        public Payment_InfoVO()
        {

        }
    }
}
