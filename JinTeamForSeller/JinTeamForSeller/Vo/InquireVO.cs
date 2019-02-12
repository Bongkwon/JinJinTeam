using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class InquireVO
    {
        private int inquireNo;

        public int InquireNo
        {
            get { return inquireNo; }
            set { inquireNo = value; }
        }
        private string inquire_type;

        public string Inquire_type
        {
            get { return inquire_type; }
            set { inquire_type = value; }
        }
        private int cusNo;
        public int InquireID
        {
            get { return inquireID; }
            set { inquireID = value; }
        }
        public int CusNo
        {
            get { return cusNo; }
            set { cusNo = value; }
        }
        private string cusName;

        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }
        private string stockId;

        public string StockId
        {
            get { return stockId; }
            set { stockId = value; }
        }
        private string inquireTitle;

        public string InquireTitle
        {
            get { return inquireTitle; }
            set { inquireTitle = value; }
        }
        private string inquireBody;

        public string InquireBody
        {
            get { return inquireBody; }
            set { inquireBody = value; }
        }

        private string inquireDate;

        public string InquireDate
        {
            get { return inquireDate; }
            set { inquireDate = value; }
        }
        private string inquireImage;

        public string InquireImage
        {
            get { return inquireImage; }
            set { inquireImage = value; }
        }
        private string reDate;
        public string ReBody
        {
            get { return reBody; }
            set { reBody = value; }
        }
        public string ReDate
        {
            get { return reDate; }
            set { reDate = value; }
        }
        private string reBody;

        
        private string mainImage;

        public string MainImage
        {
            get { return mainImage; }
            set { mainImage = value; }
        }
        private int inquireID;

        public InquireVO(int inquireNo, string inquire_type, int inquireID, string inquireTitle, 
            string inquireBody, string inquireDate, string inquireImage, string reDate, string reBody)
        {
            this.inquireNo = inquireNo;
            this.inquire_type = inquire_type;
            this.inquireTitle = inquireTitle;
            this.inquireBody = inquireBody;
            this.inquireDate = inquireDate;
            this.inquireImage = inquireImage;
            this.reDate = reDate;
            this.reBody = reBody;
            this.inquireID = inquireID;
        }

        public InquireVO(int inquireNo, string inquire_type, int cusNo, string cusName, string stockId, 
            string inquireTitle, string inquireBody, string inquireDate, string inquireImage, string reDate, string reBody, string mainImage)
        {
            this.inquireNo = inquireNo;
            this.inquire_type = inquire_type;
            this.cusNo = cusNo;
            this.cusName = cusName;
            this.stockId = stockId;
            this.inquireTitle = inquireTitle;
            this.inquireBody = inquireBody;
            this.inquireDate = inquireDate;
            this.inquireImage = inquireImage;
            this.reDate = reDate;
            this.reBody = reBody;
            this.mainImage = mainImage;
        }
    }
}
