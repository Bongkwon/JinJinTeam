﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin.Vo
{
    public class Sales_manager_Vo
    {
        private string seller_ID;

        public string Seller_ID
        {
            get { return seller_ID; }
            set { seller_ID = value; }
        }
        private string pay_date;

        public string Pay_date
        {
            get { return pay_date; }
            set { pay_date = value; }
        }
        private string pay_date_m;

        public string Pay_date_m
        {
            get { return pay_date_m; }
            set { pay_date_m = value; }
        }


        private int pay_count;

        public int Pay_count
        {
            get { return pay_count; }
            set { pay_count = value; }
        }
        private int pay_price;

        public int Pay_price
        {
            get { return pay_price; }
            set { pay_price = value; }
        }

    }
}
