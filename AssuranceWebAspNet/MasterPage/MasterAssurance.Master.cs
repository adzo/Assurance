using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.MasterPage
{
    public partial class MasterAssurance1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Role"] == null || Session["Role"].ToString() != "Assurance")
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
        }
    }
}