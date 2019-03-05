using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class UserShipInfo_VO
    {
        private string user_Ship_Id;
        private int cus_No;
        private string user_name;
        private string user_addr;
        private string postal_Code;
        private string ship_Require;

        public string User_Ship_Id { get => user_Ship_Id; set => user_Ship_Id = value; }
        public int Cus_No { get => cus_No; set => cus_No = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_addr { get => user_addr; set => user_addr = value; }
        public string Postal_Code { get => postal_Code; set => postal_Code = value; }
        public string Ship_Require { get => ship_Require; set => ship_Require = value; }

        public UserShipInfo_VO(int cus_No, string user_name, string user_addr, string postal_Code, string ship_Require)
        {
            this.cus_No = cus_No;
            this.user_name = user_name;
            this.user_addr = user_addr;
            this.postal_Code = postal_Code;
            this.ship_Require = ship_Require;
        }
    }
}