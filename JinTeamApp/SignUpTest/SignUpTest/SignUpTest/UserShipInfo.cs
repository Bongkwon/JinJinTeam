using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpTest
{
    class UserShipInfo
    {
        private string user_Ship_Id;
        private int cus_No;
        private string user_name;
        private string user_addr;
        private string postal_Code;
        private string ship_Require;
        private string waybill_ID;

        public string User_Ship_Id { get => user_Ship_Id; set => user_Ship_Id = value; }
        public int Cus_No { get => cus_No; set => cus_No = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_addr { get => user_addr; set => user_addr = value; }
        public string Postal_Code { get => postal_Code; set => postal_Code = value; }
        public string Ship_Require { get => ship_Require; set => ship_Require = value; }
        public string Waybill_ID { get => waybill_ID; set => waybill_ID = value; }


    }
}
