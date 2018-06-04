using AssuranceWebAspNet.Utilities;
using Exam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Utilities
{
    public  class VerifyIdentity : Page
    {
        public static VerifyIdentity Verify = new VerifyIdentity();
        public void verifyConnected()
        {
            if (Session["userId"] is null)
            {
                HttpContext.Current.Response.Redirect("~/Login.aspx");
                //Response.Redirect("~/Login.aspx");
            }
        }
    }
}