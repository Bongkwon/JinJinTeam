using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmShowProStock : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();
        CategoryDAO categoryDAO = new CategoryDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            string json = string.Empty;
            string pro_id = string.Empty;
            string cat_id = string.Empty;

            if (Request.Params["pro_id"] != null)
            {
                pro_id = Request.Params["pro_id"].ToString();
                //stocks = stockDao.ShowStock(pro_id);
                json = JsonConvert.SerializeObject(stockDao.ShowStock(pro_id));
            }
            else if (Request.Params["cat_id"] != null)
            {
                cat_id = Request.Params["cat_id"].ToString();

                json = JsonConvert.SerializeObject(categoryDAO.Showcategory(cat_id));
            }
            else
            {
                json = "111";
            }

            Response.Clear();
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}