using AssuranceWebAspNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages
{
    public partial class Logged : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //VerifyIdentity.Verify.verifyConnected();
            if (Session["Role"] != null)
            {
                //Session["target"] = null;
                if (Session["Role"].ToString() == "Assurance")
                {
                    if (Session["target"] != null){
                        Response.Redirect(Session["target"].ToString());
                    }
                    Javascript.ConsoleLog("Assurance connected");
                    Response.Redirect("/Pages/Assurance/Accueil.aspx");
                }
                else if (Session["Role"].ToString() == "Centre")
                {
                    if (Session["target"] != null){
                        Response.Redirect(Session["target"].ToString());
                    }
                    Javascript.ConsoleLog("Centre d'expertise connected");
                    Response.Redirect("/Pages/Centre/Accueil");
                }
                else if (Session["Role"].ToString() == "Expert")
                {
                    if (Session["target"] != null){
                        Response.Redirect(Session["target"].ToString());
                    }
                    Javascript.ConsoleLog("Exert connected");
                    Response.Redirect("/Pages/Expert/Accueil");
                }
                else if (Session["Role"].ToString().Equals("Garage") )
                {
                    if (Session["target"] != null)
                    {
                        Response.Redirect(Session["target"].ToString());
                    }
                    Javascript.ConsoleLog("Garagiste connected");
                    Response.Redirect("/Pages/Garagiste/Accueil");
                }
                else if(Session["Role"].ToString() == "Assure")
                {
                    Response.Redirect("/Pages/Assure/Home");
                }
            }
            
            else
            {
                Response.Redirect("~/Login.aspx");
            }

        }
    }
}