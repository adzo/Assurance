using AssuranceWebAspNet.Utilities;
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
        ListItem i;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Centre/ListeSinistre";
            if (!IsPostBack)
            {
                this.loadPopupModalSelectLists();
            }
            

            if (Session["SinistreId"] != null)
            {
                
                listeSinistreAfficher = new List<Sinistre>();
                listeSinistreAfficher.Add(usr.Sinistres.Find(Session["SinistreId"]));
                if(listeSinistreAfficher.Count != 0)
                {
                    this.loadTableSinistre(listeSinistreAfficher);
                }
                else
                {
                    Response.Write("<script>alert('Aucun sinistre trouvé')</script>");
                }
                
            }
            else
            {
                listeSinistreAfficher = new List<Sinistre>();
                listeSinistreAfficher = usr.Sinistres.ToList();
                this.loadTableSinistre(listeSinistreAfficher);
            }
            Session["SinistreId"] = null;

        }

        public void Button_RechercheSinistre_Click(object sender, EventArgs e)
        {
            int i = 5;
            if (TextBox_SinistreIdToSearch.Text != null)
            {
                if (Int32.TryParse(TextBox_SinistreIdToSearch.Text, out i))
                {
                    Session["SinistreId"] = i;
                    this.Page_Load(sender, e);
                }
            }
            
            

        }

        public void Button_EnregistrerSinistre_Click(object sender, EventArgs e)
        {
            Javascript.ConsoleLog("clicked Ajout sinistre");
            Exam.Domain.Entities.Sinistre s = new Exam.Domain.Entities.Sinistre();
            s.Conducteur = _S_Conducteur.Text;
            s.DateSinistre = _S_DateSinistre.Text;
            s.NumeroPermis = _S_NumPermis.Text;
            s.DateDePermis = _S_DatePermis.Text;
            int  idExpert, idContrat;
            idExpert = Int32.Parse(DropDownList_SinistreListeExpert.SelectedItem.Value);
            idContrat = Int32.Parse(DropDownList_Immatriculation.SelectedItem.Value);
            Javascript.ConsoleLog(idExpert.ToString());
            Javascript.ConsoleLog(idContrat.ToString());
            UserAccount Expert = usr.Users.Find(idExpert);
            s.GarageExperts.Add(Expert);
            s.Contrat = usr.Contrats.Find(idContrat);
            s.Phase = "Affectation Garage";
            s.Etat = "En cours";
            Javascript.ConsoleLog(s.Contrat.Souscripteur.Nom);
            usr.Sinistres.Add(s);
            usr.SaveChanges();
            this.Page_Load(sender,e);
        }


        public void loadPopupModalSelectLists()
        {
            ICollection<Contrat> listeContrats = usr.Contrats.ToList();
            if (listeContrats != null)
            {
                DropDownList_Immatriculation.Items.Clear();

                foreach (Contrat C in listeContrats)
                {
                    i = new ListItem(C.Vehicule.Matricule, C.ContratId.ToString());
                    DropDownList_Immatriculation.Items.Add(i);
                }
            }

            //load dropDownList Garage et Experts
            List<UserAccount> listeExpertGaragiste = usr.Users.ToList();
            if (listeExpertGaragiste != null)
                DropDownList_SinistreListeExpert.Items.Clear();
            DropDownList_SinistreListeExpert.Items.Clear();
            {
                foreach (UserAccount u in listeExpertGaragiste)
                {
                    i = new ListItem(u.FirstName + ", " + u.LastName, u.UserId.ToString());
                    switch (u.Role)
                    {
                        case "Expert":
                            DropDownList_SinistreListeExpert.Items.Add(i);
                            break;
                        
                        default:
                            break;
                    }
                }
            }
        }


        public void loadTableSinistre(List<Sinistre> listeSinistreAfficher)
        {
            TableCell cellID, cellDateSinistre, cellConducteur, cellPermis, cellDatePermis, cellNature, cellExpert, cellGarage, cellPhase, cellEtat, cellFichier, cellEditer;
            TableRow tr = new TableRow();
            //Entête du tableau:
            TableListeSinistre.Rows.Clear();
            cellID = new TableCell() { Text = "N° sinistre" };
            cellDateSinistre = new TableCell() { Text = "Date" };
            cellConducteur = new TableCell() { Text = "Conducteur" };
            cellPermis = new TableCell() { Text = "N° Permis" };
            cellDatePermis = new TableCell() { Text = "Date Permis" };
            cellNature = new TableCell() { Text = "Nature" };
            cellExpert = new TableCell() { Text = "Expert" };
            cellGarage = new TableCell() { Text = "Garage" };
            cellPhase = new TableCell() { Text = "Phase" };
            cellEtat = new TableCell() { Text = "Etat" };
            cellFichier = new TableCell() { Text = "File" };
            cellEditer = new TableCell() { Text = "Editer" };

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
            

            foreach (Sinistre s in listeSinistreAfficher)
            {
                if(s == null)
                {
                    break;
                }
                tr = new TableRow();

                cellID = new TableCell() { Text = s.SinistreId.ToString() };
                string DateSinistre;
                try
                {
                    DateSinistre = s.DateSinistre.ToString();
                }
                catch
                {
                    DateSinistre = "";
                }
                
                cellDateSinistre = new TableCell() { Text = s.DateSinistre };

                cellConducteur = new TableCell() { Text = s.Conducteur };
                cellPermis = new TableCell() { Text = s.NumeroPermis };
                cellDatePermis = new TableCell() { Text = s.DateDePermis };
                cellNature = new TableCell() { Text = s.Nature };
                UserAccount expert = s.GarageExperts.FirstOrDefault(f => f.Role == "Expert");
                cellExpert = new TableCell() { Text = expert.FirstName + ", " + expert.LastName };
                UserAccount garage = s.GarageExperts.FirstOrDefault(f => f.Role == "Garage");
                if(garage != null)
                {
                    cellGarage = new TableCell() { Text = garage.FirstName + ", " + garage.LastName };
                }
                else
                {
                    cellGarage = new TableCell() { Text = "" };
                }
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