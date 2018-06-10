using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class AssurancePriseCharge : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        string guid = Guid.NewGuid().ToString();
        int sinistreId;
        Sinistre sinis = new Sinistre();
        UserDbContext usr = new UserDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["param1"] != null)
            {
                sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
                sinis = usr.Sinistres.Find(sinistreId);
                
                //Populate all Fields
            }
            else
            {
                Response.Redirect("listeSinistre.aspx");
            }
        }
        public void btnChercher_Click(object sender, EventArgs e)
        {
            int Id;
            if (Int32.TryParse(_TxtNumSinistre.Text, out Id))
            {
                Response.Redirect("../../Pages/Assurance/PriseEncharge.aspx?param1=" + Id);
            }
        }
    }
}