using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class Inquire_VO
    {
        string inquire_type;
        int inquire_Id;
        string cus_or_sell;
        string inquire_title;
        string inquire_body;

        public Inquire_VO(string inquire_type, int inquire_Id, string cus_or_sell, string inquire_title, string inquire_body)
        {
            this.inquire_type = inquire_type;
            this.inquire_Id = inquire_Id;
            this.cus_or_sell = cus_or_sell;
            this.inquire_title = inquire_title;
            this.inquire_body = inquire_body;
        }

        public string Inquire_type { get => inquire_type; set => inquire_type = value; }
        public int Inquire_Id { get => inquire_Id; set => inquire_Id = value; }
        public string Cus_or_sell { get => cus_or_sell; set => cus_or_sell = value; }
        public string Inquire_title { get => inquire_title; set => inquire_title = value; }
        public string Inquire_body { get => inquire_body; set => inquire_body = value; }
    }
}