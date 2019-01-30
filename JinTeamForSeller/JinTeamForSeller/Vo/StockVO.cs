using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class StockVO
    {
        private string stock_ID;

        public string Stock_ID
        {
            get { return stock_ID; }
            set { stock_ID = value; }
        }
        private string pro_ID;

        public string Pro_Id
        {
            get { return pro_ID; }
            set { pro_ID = value; }
        }
        private int seller_no;

        public int Seller_no
        {
            get { return seller_no; }
            set { seller_no = value; }
        }
        private string stock_Size;

        public string Stock_Size
        {
            get { return stock_Size; }
            set { stock_Size = value; }
        }
        private int stock_Count;

        public int Stock_Count
        {
            get { return stock_Count; }
            set { stock_Count = value; }
        }

        public StockVO(string stock_ID, string pro_ID, int seller_no, string stock_Size, int stock_Count)
        {
            this.stock_ID = stock_ID;
            this.pro_ID = pro_ID;
            this.seller_no = seller_no;
            this.stock_Size = stock_Size;
            this.stock_Count = stock_Count;
        }
    }
}
