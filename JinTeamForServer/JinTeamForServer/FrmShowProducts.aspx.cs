using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmShowProducts : System.Web.UI.Page
    {
        ProductsDAO prod = new ProductsDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            string cat_ID = null;  // 카테고리명 으로 검색 ( 조인해서 kind 명으로 바꾸어야함 )
            string json = null;

            if (String.IsNullOrEmpty(Request.Params["cat_ID"]))
            {
                json = prod.ProductsReadTable();
            }
            else
            {
                cat_ID = Request.Params["cat_ID"].ToString();
                json = prod.ProductsReadTable(cat_ID);
            }

            Response.Clear();   
            Response.ContentType = "application/json, charset=utf-8";   
            Response.Write(json);  
            Response.Flush();
            Response.End();
        }
    }
}