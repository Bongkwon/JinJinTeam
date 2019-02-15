using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin.Vo
{
    public class Products_Vo
    {
        private string pro_Id;
        public string Pro_ID
        {
            get { return pro_Id; }
            set { pro_Id = value; }
        }
        private string cat_ID;

        public string Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private int seller_No;
        public int Seller_NO
        {
            get { return seller_No; }
            set { seller_No = value; }
        }
        private string pro_name;
        public string Pro_Name
        {
            get { return pro_name; }
            set { pro_name = value; }
        }
        private string pro_Price;
        public string Pro_Price
        {
            get { return pro_Price; }
            set { pro_Price = value; }
        }
        private string main_Comment;
        public string Main_Comment
        {
            get { return main_Comment; }
            set { main_Comment = value; }
        }
        private string sub_Comment;
        public string Sub_Comment
        {
            get { return sub_Comment; }
            set { sub_Comment = value; }
        }
        private string main_Image;
        public string Main_Image
        {
            get { return main_Image; }
            set { main_Image = value; }
        }
        private int pro_Hits;
        public int Pro_Hits
        {
            get { return pro_Hits; }
            set { pro_Hits = value; }
        }
        private int pro_Like;

        public int Pro_Like
        {
            get { return pro_Like; }
            set { pro_Like = value; }
        }

        private int pro_Discount;
        public int Pro_Discount
        {
            get { return pro_Discount; }
            set { pro_Discount = value; }
        }
        private string pro_Gender;
        public string Pro_Gender
        {
            get { return pro_Gender; }
            set { pro_Gender = value; }
        }
        private bool pro_State;
        public bool Pro_State
        {
            get { return pro_State; }
            set { pro_State = value; }
        }

        public Products_Vo(string pro_Id, string cat_ID, int seller_No, string pro_name, string pro_Price, string main_Comment, string sub_Comment, string main_Image, int pro_Hits, int pro_Like, int pro_Discount, string pro_Gender, bool pro_State)
        {
            this.pro_Id = pro_Id;
            this.cat_ID = cat_ID;
            this.seller_No = seller_No;
            this.pro_name = pro_name;
            this.pro_Price = pro_Price;
            this.main_Comment = main_Comment;
            this.sub_Comment = sub_Comment;
            this.main_Image = main_Image;
            this.pro_Hits = pro_Hits;
            this.pro_Like = pro_Like;
            this.pro_Discount = pro_Discount;
            this.pro_Gender = pro_Gender;
            this.pro_State = pro_State;
        }

        public Products_Vo()
        {
        }

        public Products_Vo(string pro_Id, string pro_name, string pro_Price, string main_Image)
        {
            this.pro_Id = pro_Id;
            this.pro_name = pro_name;
            this.pro_Price = pro_Price;
            this.main_Image = main_Image;
        }

        public Products_Vo(string pro_Id, string cat_ID, int seller_No, string pro_name, string pro_Price, string main_Comment, string main_Image, string pro_Gender, bool pro_State)
        {
            this.pro_Id = pro_Id;
            this.cat_ID = cat_ID;
            this.seller_No = seller_No;
            this.pro_name = pro_name;
            this.pro_Price = pro_Price;
            this.main_Comment = main_Comment;
            this.main_Image = main_Image;
            this.pro_Gender = pro_Gender;
            this.pro_State = pro_State;
        }

        public override bool Equals(object obj)
        {
            var products = obj as Products_Vo;
            return products != null &&
                pro_Id == products.Pro_ID &&
                pro_State == products.pro_State;
        }

    }
}
