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
        List<Product_VO> lstprod = new List<Product_VO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            lstprod = prod.ShoAllData("ViewProducts");
            Label1.Text = lstprod[0].Pro_Name;
        }
    }
}