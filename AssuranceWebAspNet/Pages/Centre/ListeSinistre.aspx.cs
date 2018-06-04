using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Centre
{
    public partial class ListeSinistre : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected List<Sinistre> listeSinistreAfficher;
        UserDbContext usr = new UserDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["SinistreId"] = null;
            }

            
            if (Session["SinistreId"] != null)
            {
                
                listeSinistreAfficher = new List<Sinistre>();
                listeSinistreAfficher.Add(usr.Sinistres.Find(Session["SinistreId"]));
                if(listeSinistreAfficher.Count != 0)
                {
                    this.loadTableSinistre(listeSinistreAfficher);
                }
                
            }
            else
            {
                listeSinistreAfficher = new List<Sinistre>();
                listeSinistreAfficher = usr.Sinistres.ToList();
                this.loadTableSinistre(listeSinistreAfficher);
            }       
        }

        public void Button_RechercheSinistre_Click(object sender, EventArgs e)
        {
            int i = 5;
            if(Int32.TryParse(TextBox_SinistreIdToSearch.Text, out i)){
                Session["SinistreId"] = i;
                this.Page_Load( sender,  e);
            }
            else
            {
                Response.Write("<script>alert('Saisie incorrecte, veuillez saisir un numéro');</script>");
            }

        }


        public void loadTableSinistre(List<Sinistre> listeSinistreAfficher)
        {

            foreach (Sinistre s in listeSinistreAfficher)
            {
                if(s == null)
                {
                    break;
                }

                TableCell cellID, cellDateSinistre, cellConducteur, cellPermis, cellDatePermis, cellNature, cellExpert, cellGarage, cellPhase, cellEtat, cellFichier, cellEditer;
                TableRow tr = new TableRow();
                cellID = new TableCell() { Text = s.SinistreId.ToString() };
                cellDateSinistre = new TableCell() { Text = s.DateSinistre.ToString() };
                cellConducteur = new TableCell() { Text = s.Conducteur };
                cellPermis = new TableCell() { Text = s.NumeroPermis };
                cellDatePermis = new TableCell() { Text = s.DateDePermis };
                cellNature = new TableCell() { Text = s.Nature };
                UserAccount expert = s.GarageExperts.FirstOrDefault(f => f.Role == "Expert");
                cellExpert = new TableCell() { Text = expert.FirstName + ", " + expert.LastName };
                UserAccount garage = s.GarageExperts.FirstOrDefault(f => f.Role == "Garage");
                cellGarage = new TableCell() { Text = garage.FirstName + ", " + garage.LastName };
                cellPhase = new TableCell() { Text = s.Phase };
                cellEtat = new TableCell() { Text = s.Etat };
                cellFichier = new TableCell() { Text = "File" };
                cellEditer = new TableCell() { Text = "<a href=\"../../Pages/Centre/PriseEncharge.aspx?param1=" + s.SinistreId + "\">edit</a>" };


                tr.Cells.Add(cellID);
                tr.Cells.Add(cellDateSinistre);
                tr.Cells.Add(cellConducteur);
                tr.Cells.Add(cellPermis);
                tr.Cells.Add(cellDatePermis);
                tr.Cells.Add(cellNature);
                tr.Cells.Add(cellExpert);
                tr.Cells.Add(cellGarage);
                tr.Cells.Add(cellPhase);
                tr.Cells.Add(cellEtat);
                tr.Cells.Add(cellFichier);
                tr.Cells.Add(cellEditer);
                TableListeSinistre.Rows.Add(tr);

            }
        }
        public void loadTableSinistreFound()
        {

        }

    }
}