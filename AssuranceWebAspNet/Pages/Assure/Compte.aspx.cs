using AssuranceWebAspNet.Utilities;
using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assure
{
    public partial class Compte : System.Web.UI.Page
    {
        UserDbContext usr = new UserDbContext();
        UserAccount user = new UserAccount();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assure/Compte";
            int userId = Int32.Parse(Session["userId"].ToString());
            user = usr.Users.FirstOrDefault(u => u.UserId == userId);
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string oldPass, NewPass, ConfirmPass;
            oldPass = TextBoxOldPassword.Text;
            NewPass = TextBoxNewPassword.Text;
            ConfirmPass = TextBoxConfirmPassword.Text;
            if (oldPass.Equals(user.Password))
            {
                if(NewPass == ConfirmPass)
                {
                    int userId = Int32.Parse(Session["userId"].ToString());
                    user = usr.Users.FirstOrDefault(u => u.UserId == userId);
                    user.Password = NewPass;
                    user.ConfirmPassword = ConfirmPass;
                    usr.SaveChanges();
                }
            }
            else
            {
                Response.Write("<script>alert('Mot de pass ancien incorrect!');</script>");
            }
        }
    }
}