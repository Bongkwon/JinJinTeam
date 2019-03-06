using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpTest
{
    class WishLists
    {
        private string wish_ID;
        private int cus_No;
        private string stock_ID;
        private int wish_count;
        private int wish_price;
        private string pro_name;
        private string main_image;
        private string stock_size;
        private string pro_url;

        public WishLists() { }

        public WishLists(string pro_name, string main_image, int wish_count, int wish_price, string stock_size, string pro_url)
        {
            this.Pro_name = pro_name;
            this.Main_image = main_image;
            this.Wish_count = wish_count;
            this.Wish_price = wish_price;
            this.Stock_size = stock_size;
            this.Pro_url = pro_url;
        }

        public string Wish_ID { get => wish_ID; set => wish_ID = value; }
        public int Cus_No { get => cus_No; set => cus_No = value; }
        public string Stock_ID { get => stock_ID; set => stock_ID = value; }
        public int Wish_count { get => wish_count; set => wish_count = value; }
        public int Wish_price { get => wish_price; set => wish_price = value; }
        public string Pro_name { get => pro_name; set => pro_name = value; }
        public string Main_image { get => main_image; set => main_image = value; }
        public string Stock_size { get => stock_size; set => stock_size = value; }
        public string Pro_url { get => pro_url; set => pro_url = value; }
    }
}
