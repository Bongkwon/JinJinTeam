using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace JinTeamForSeller.Vo
{
    class SellerInfo
    {
        private int seller_No;

        public int Seller_No
        {
            get { return seller_No; }
            set { seller_No = value; }
        }
        private string seller_name;

        public string Seller_Name
        {
            get { return seller_name; }
            set { seller_name = value; }
        }

        public SellerInfo(int seller_No, string seller_name)
        {
            this.seller_No = seller_No;
            this.seller_name = seller_name;
        }

        public SellerInfo()
        {
        }
    }
}