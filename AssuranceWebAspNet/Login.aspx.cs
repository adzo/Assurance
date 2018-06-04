using AssuranceWebAspNet.Utilities;
using Exam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                Javascript.ConsoleLog("Connected User" + Session["userId"] + ":  " + Session["FirstName"] + " " + Session["LastName"] + " has role " + Session["Role"]);
            }
            
        }

        protected void btn_connexion_Click(object sender, EventArgs e)
        {
            var UserName = "";
            var UserPassword = "";

            if (text_mail.Text != null)
            {
                UserName = text_mail.Text;
            }
            else
            {
               // Label_mailValidator.Text = "Champs Obligatoir";
            }
            if (text_mail.Text != null)
            {
                UserPassword = text_password.Text;
            }
            else
            {
               // Label_passwordValidator.Text = "Champs Obligatoir";
            }
            using (UserDbContext context = new UserDbContext())
            {
                var usr = context.Users.FirstOrDefault(
                    u => u.Email == UserName &&
                    u.Password == UserPassword
                    );
                if (usr != null)
                {
                    Session["userId"] = usr.UserId;
                    Session["FirstName"] = usr.FirstName;
                    Session["LastName"] = usr.LastName;
                    Session["Role"] = usr.Role;

                    Javascript.ConsoleLog("Connected User" + Session["userId"] + ":  " + Session["FirstName"] + " " + Session["LastName"] + " has role " + Session["Role"]);
                    Response.Redirect("/Logged.aspx");
                }
                else
                {
                    Label_connexionValidator.Text = "Connexion impossible!!";
                }


            }
        }
    }
}