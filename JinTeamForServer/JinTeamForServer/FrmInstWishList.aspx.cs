using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInstWishList : System.Web.UI.Page
    {
        WishList_VO wl;
        WishListDAO wish = new WishListDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Params["wish_ID"] != null && Request.Params["cus_No"] != null &&
                Request.Params["stock_ID"] != null && Request.Params["wish_count"] != null && Request.Params["wish_price"] != null)
            {
                wl = new WishList_VO()
                {
                    Wish_ID = Request.Params["wish_ID"],
                    Cus_ID = int.Parse(Request.Params["cus_No"]),
                    StockID = Request.Params["stock_ID"],
                    Wish_count = int.Parse(Request.Params["wish_count"]),
                    Wish_price = int.Parse(Request.Params["wish_price"])
                };
            }
            else
            {
                // 에러코드보내기?
            }

            wish.InsertWishList(wl);
        }
    }
}