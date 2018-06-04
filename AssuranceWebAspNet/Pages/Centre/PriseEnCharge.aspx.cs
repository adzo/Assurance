using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Centre
{
    public partial class PriseEnCharge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["param1"] != null)
                
            Response.Write("<script>alert('Garantie existe deja pour ce contrat"+ Request.QueryString["param1"] + "');</script>");
        }
    }
}