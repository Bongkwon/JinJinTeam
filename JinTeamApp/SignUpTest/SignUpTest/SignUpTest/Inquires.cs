using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpTest
{
    class Inquires
    {
        int inquire_no;
        string inquire_type;
        int inquire_Id;
        string cus_or_sell;
        string inquire_title;
        string inquire_body;
        string inquire_date;
        string inquire_image;
        string re_date;
        string re_body;

        public Inquires(int inquire_no, string inquire_type, int inquire_Id, string cus_or_sell, string inquire_title, string inquire_body, string inquire_date, string inquire_image, string re_date, string re_body)
        {
            this.Inquire_no = inquire_no;
            this.Inquire_type = inquire_type;
            this.Inquire_Id = inquire_Id;
            this.Cus_or_sell = cus_or_sell;
            this.Inquire_title = inquire_title;
            this.Inquire_body = inquire_body;
            this.Inquire_date = inquire_date;
            this.Inquire_image = inquire_image;
            this.Re_date = re_date;
            this.Re_body = re_body;
        }

        public int Inquire_no { get => inquire_no; set => inquire_no = value; }
        public string Inquire_type { get => inquire_type; set => inquire_type = value; }
        public int Inquire_Id { get => inquire_Id; set => inquire_Id = value; }
        public string Cus_or_sell { get => cus_or_sell; set => cus_or_sell = value; }
        public string Inquire_title { get => inquire_title; set => inquire_title = value; }
        public string Inquire_body { get => inquire_body; set => inquire_body = value; }
        public string Inquire_date { get => inquire_date; set => inquire_date = value; }
        public string Inquire_image { get => inquire_image; set => inquire_image = value; }
        public string Re_date { get => re_date; set => re_date = value; }
        public string Re_body { get => re_body; set => re_body = value; }
    }
}
