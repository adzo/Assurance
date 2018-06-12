using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class Historique : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assurance/Historique";
        }
    }
}