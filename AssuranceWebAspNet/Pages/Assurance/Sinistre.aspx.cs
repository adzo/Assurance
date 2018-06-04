using AssuranceWebAspNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class Sinistre : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_RechercheSinistre_Click(object sender, EventArgs e)
        {
            var txt = TextBox1_Sinistre.Text;
            int idSinistre = Int32.Parse(txt);
            Javascript.ConsoleLog(idSinistre.ToString());
            table.Append(" <table class=\"table\"><tr><th>Numéro Sinistre</th><th>Date Sinistre</th><th>Nom Conducteur</th><th>numéro Permis</th><th>Date</th><th>Nature</th><th>Garage</th><th>Phase</th><th>Etat</th><th>Consulter</th></tr>");
            //Fetching all sinistres

            table.Append("</table>");
            PlaceHolder_TableSinistres.Controls.Add(new Literal { Text = table.ToString() });

        }
    }
}