using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class WishList_VO
    {
        private string wish_ID;

        public string Wish_ID
        {
            get { return wish_ID; }
            set { wish_ID = value; }
        }
        private int cus_ID;

        public int Cus_ID
        {
            get { return cus_ID; }
            set { cus_ID = value; }
        }
        private string stock_ID;

        public string StockID
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }
        private int wish_count;

        public int Wish_count
        {
            get { return wish_count; }
            set { wish_count = value; }
        }
        private int wish_price;

        public int Wish_price
        {
            get { return wish_price; }
            set { wish_price = value; }
        }
    }
}