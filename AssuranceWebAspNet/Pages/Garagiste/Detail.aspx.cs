using AssuranceWebAspNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Garagiste
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Garagiste/Detail";
            if (Session["sinistreId"] != null)
            {
                //Load the page
                PlaceHolder1.Controls.Add(new Literal { Text = "Sinistre passé est :" + Session["sinistreId"].ToString() });
                Javascript.ConsoleLog("Sinistre passé est: " + Session["sinistreId"].ToString() );
            }
            else
            {
                //Redirect to Prise en charge
                Response.Redirect("PriseCharge.aspx");
            }
            
        }
    }
}