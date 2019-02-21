using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class Stock
    {
        private string stock_id;

        public string Stock_id
        {
            get { return stock_id; }
            set { stock_id = value; }
        }
        private string pro_id;

        public string Pro_id
        {
            get { return pro_id; }
            set { pro_id = value; }
        }
        private int seller_no;

        public int Seller_no
        {
            get { return seller_no; }
            set { seller_no = value; }
        }
        private string stock_size;

        public string Stock_size
        {
            get { return stock_size; }
            set { stock_size = value; }
        }
        private int stock_count;

        public int Stock_count
        {
            get { return stock_count; }
            set { stock_count = value; }
        }
    }
}