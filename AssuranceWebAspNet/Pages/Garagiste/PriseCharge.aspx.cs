using AssuranceWebAspNet.Utilities;
using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GaragistePriseCharge : System.Web.UI.Page
{
    StringBuilder table = new StringBuilder();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack)
        {
            int idSinistre=0;
            if(Int32.TryParse(TextBox1_Sinistre.Text,out idSinistre))
            {
                Javascript.ConsoleLog("Conversion succeeded, your number is :"+idSinistre);
                Session["sinistreId"] = idSinistre;
                //Response.Redirect("Detail.aspx");
                Javascript.ConsoleLog("Sinistre passé est: " + Session["sinistreId"].ToString());
            }
            else
            {
                Javascript.ConsoleLog("Conversion impossible, veuillez saisir un numero");

            }
            
        }
    }

    protected void Button_RechercheSinistre_Click(object sender, EventArgs e)
    {
        using (UserDbContext context = new UserDbContext())
        {
            var Assures = context.Assures.ToList();
            Session["assurees"] = Assures;
            if (Assures != null)
            {
                table.Append(" <table class=\"table\"><tr><th>Type</th><th>Nom</th><th>Preom</th><th>Date de Naissance</th></tr>");
                foreach(var assure in Assures)
                {
                    table.Append("<tr>");
                    table.Append("<th>");
                    table.Append(assure.TypeAssure);
                    table.Append("</th>");
                    table.Append("<th>");
                    table.Append(assure.Nom);
                    table.Append("</th>");
                    table.Append("<th>");
                    table.Append(assure.Prenom);
                    table.Append("</th>");
                    table.Append("<th>");
                    table.Append(assure.DateDeNaissance);
                    table.Append("</th>");
                    table.Append("</tr>");
                }
                table.Append("</table>");
                var listAssures = (List<Assure>)Session["assurees"];
                int i = 1;
                foreach (Assure assure in listAssures)
                {
                    table.Append("<br/><p>" + i + ":  " + assure.Nom + " " + assure.Prenom + "</p>");
                    i++;
                }
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            }
            else
            {
                PlaceHolder1.Controls.Add(new Literal { Text = "Table assurés vide" });
            }

        }
    }
}