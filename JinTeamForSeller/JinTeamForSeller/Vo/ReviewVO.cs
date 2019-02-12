using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class ReviewVO
    {
        private int re_ID;

        public int Re_ID
        {
            get { return re_ID; }
            set { re_ID = value; }
        }
        private int cus_NO;

        public int Cus_NO
        {
            get { return cus_NO; }
            set { cus_NO = value; }
        }
        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }
        private string pro_ID;

        public string Pro_ID
        {
            get { return pro_ID; }
            set { pro_ID = value; }
        }
        private bool re_Like;

        public bool Re_Like
        {
            get { return re_Like; }
            set { re_Like = value; }
        }
        private string re_Image;

        public string Re_Image
        {
            get { return re_Image; }
            set { re_Image = value; }
        }
        private string re_Txt;

        public string Re_Txt
        {
            get { return re_Txt; }
            set { re_Txt = value; }
        }

        private DateTime re_Date;

        public DateTime Re_Date
        {
            get { return re_Date; }
            set { re_Date = value; }
        }
        private string re_Comment;

        public string Re_Comment
        {
            get { return re_Comment; }
            set { re_Comment = value; }
        }
        private string re_Comment_Date;

        public string Re_Commnet_Date
        {
            get { return re_Comment_Date; }
            set { re_Comment_Date = value; }
        }
        private string cusName;
        private string mainImage;

        public string MainImage
        {
            get { return mainImage; }
            set { mainImage = value; }
        }


        public ReviewVO(int re_ID, int cus_NO, string pro_ID, bool re_Like, string re_Image, string re_Txt, 
            DateTime re_Date, string re_Comment, string re_Comment_Date, string cusName, string mainImage)
        {
            this.re_ID = re_ID;
            this.cus_NO = cus_NO;
            this.pro_ID = pro_ID;
            this.re_Like = re_Like;
            this.re_Image = re_Image;
            this.re_Txt = re_Txt;
            this.re_Date = re_Date;
            this.re_Comment = re_Comment;
            this.re_Comment_Date = re_Comment_Date;
            this.cusName = cusName;
            this.mainImage = mainImage;
        }

        public ReviewVO()
        {
        }
    }
}
