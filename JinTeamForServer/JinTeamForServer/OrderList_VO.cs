﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class OrderList_VO
    {
        private string order_ID;
        private int cus_No;
        private string stock_ID;
        private int order_Count;
        private int order_Price;
        private string order_Require;

        public string Order_ID { get => order_ID; set => order_ID = value; }
        public int Cus_No { get => cus_No; set => cus_No = value; }
        public string Stock_ID { get => stock_ID; set => stock_ID = value; }
        public int Order_Count { get => order_Count; set => order_Count = value; }
        public int Order_Price { get => order_Price; set => order_Price = value; }
        public string Order_Require { get => order_Require; set => order_Require = value; }
    }
}