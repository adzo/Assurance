using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class AssuranceAceuil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != "Assurance")
            {
                Session["target"] = "/Pages/Assurance/Accueil";
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}