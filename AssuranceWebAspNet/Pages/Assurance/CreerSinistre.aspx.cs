using AssuranceWebAspNet.Utilities;
using Exam.Data;
using Exam.Domain.Entities;
using Exam.Service;
using Exam.Service.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class CreerSinistre : System.Web.UI.Page
    {
        UserDbContext u = new UserDbContext();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadDropDawnListContractView();
            this.LoadDropDownListGarantieView();
            this.LoadDropDownListSinistreView();
           
               
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)(c)).Text = string.Empty;
                    }
                }
            
        }

        //Populating dropdownList for assure et Souscripteur in Contract view
        protected void LoadDropDawnListContractView()
        {
            ICollection<Assure> listeAssures = u.Assures.ToList();
            if (listeAssures != null)
            {
                DropDownList_ListAssures.Items.Clear();
                ListItem I;
                foreach (Assure A in listeAssures)
                {
                    I = new ListItem(A.Id.ToString()+" : "+A.Nom + ", " + A.Prenom, A.Id.ToString());
                    Javascript.ConsoleLog(A.Nom + ", " + A.Prenom + " :" + A.Id.ToString());
                    DropDownList_ListAssures.Items.Add(I);
                }
            }
            ICollection<Souscripteur> listeSouscripteur = u.Souscripteurs.ToList();
            if (listeSouscripteur != null)
            {
                DropDownList_ListeSouscripteur.Items.Clear();
                ListItem I;
                foreach (Souscripteur A in listeSouscripteur)
                {
                    
                    if (A.Nom is null)
                    {
                        A.Nom = "Not Defined";
                    }
                    I = new ListItem( A.Id.ToString() + " : " + A.Nom, A.Id.ToString());
                    DropDownList_ListeSouscripteur.Items.Add(I);
                }
            }
            ICollection<Vehicule> listeVehicules = u.Vehicules.ToList();
            ICollection<Contrat> listeContrats = u.Contrats.ToList();
            if (listeAssures != null)
            {
                DropDownList_ListeVehicules.Items.Clear();
                ListItem I;
                foreach (Vehicule A in listeVehicules)
                {
                    //Verifier si vehicule id existe dans contrat:
                    Contrat c = u.Contrats.Find(A.Id);
                    if (c == null)
                    {
                        I = new ListItem(A.Id.ToString() + " : " + A.Matricule, A.Id.ToString());

                        DropDownList_ListeVehicules.Items.Add(I);
                    }

                   
                }
            }
        }

        protected void LoadDropDownListGarantieView()
        {
            ICollection<Contrat> listeContrats = u.Contrats.ToList();
            if(listeContrats != null)
            {
                DropDownList_ListeContrat.Items.Clear();
                ListItem i;
                foreach(Contrat C in listeContrats)
                {
                    i = new ListItem(C.Vehicule.Matricule,C.ContratId.ToString());
                    DropDownList_ListeContrat.Items.Add(i);
                }
            }
            ICollection<Garantie> listeGarantie = u.Garanties.ToList();
            if (listeGarantie != null)
            {
                DropDownList_ListeGarantie.Items.Clear();
                ListItem i;
                foreach(Garantie g in listeGarantie)
                {
                    i = new ListItem(g.GarantieName, g.Id.ToString());
                    DropDownList_ListeGarantie.Items.Add(i);
                }
            }
        }

        protected void LoadDropDownListSinistreView()
        {
            ListItem i;
            //load dropDownList Garage et Expert
            List<UserAccount> listeExpertGaragiste = u.Users.ToList();
            if (listeExpertGaragiste != null)
                DropDownList_SinistreListeExpert.Items.Clear();
            DropDownList_SinistreGaragiste.Items.Clear();
            {
                foreach(UserAccount u in listeExpertGaragiste)
                {
                    i = new ListItem(u.FirstName + ", " + u.LastName, u.UserId.ToString());
                    switch (u.Role)
                    {
                        case "Expert":
                            DropDownList_SinistreListeExpert.Items.Add(i);
                            break;
                        case "Garage":
                            DropDownList_SinistreGaragiste.Items.Add(i);
                            break;
                        default:
                            break;
                    }
                }
            }
            //Load dropDownListe Matricule
            ICollection<Contrat> listeContrats = u.Contrats.ToList();
            if (listeContrats != null)
            {
                DropDownList_Immatriculation.Items.Clear();
                
                foreach (Contrat C in listeContrats)
                {
                    i = new ListItem(C.Vehicule.Matricule, C.ContratId.ToString());
                    DropDownList_Immatriculation.Items.Add(i);
                }
            }


            
            //List<Vehicule> listeVehicule = u.Vehicules.ToList();
            //if (listeVehicule!=null)
            //{
            //    foreach(Vehicule v in listeVehicule)
            //    {
            //        i = new ListItem(v.Matricule, v.Id.ToString());
            //        DropDownList_Immatriculation.Items.Add(i);
            //    }
            //}
            //Load dropDownList Garantie SInistree
            ICollection<Garantie> listeGarantie = u.Garanties.ToList();
            if (listeGarantie != null)
            {
                DropDownList_SinistreGarantieSinistre.Items.Clear();
                
                foreach (Garantie g in listeGarantie)
                {
                    i = new ListItem(g.GarantieName, g.Id.ToString());
                    DropDownList_SinistreGarantieSinistre.Items.Add(i);
                }
            }

        }

        protected void Button_EnregistrerSinistre_Click(object sender, EventArgs e)
        {
            Javascript.ConsoleLog("ajout sinistre clicked");
            Exam.Domain.Entities.Sinistre s = new Exam.Domain.Entities.Sinistre();
            s.Conducteur = _S_Conducteur.Text;
            s.Nature = _S_Nature.Text;
            int i = 0;
            Int32.TryParse(RadioButtonList_Indemnite.SelectedValue, out i);
            s.Indemnise = Convert.ToBoolean(i);
            s.IDA = Convert.ToBoolean(Int32.Parse(RadioButtonList_IDA.SelectedValue));
            s.GarantieSinistre = DropDownList_SinistreGarantieSinistre.SelectedItem.Text;
            s.NumeroPermis = _S_NumPermis.Text;
            s.DateDePermis = _S_DatePermis.Text;
            i = 0;
            Int32.TryParse(_S_PartResp.Text, out i);
            s.PartDeResponsabilite = i;
            i = 0;
            Int32.TryParse(_S_MontantInd.Text, out i);
            s.MontantIndemnisation = i;
            s.CompagnieAdverse = _S_CompagnieAdv.Text;
            s.DateSinistre = _S_DateSinistre.Text;
            s.DateIndemnisation = _S_DateIndm.Text;
            s.VehiculeAdverse = _S_VehiculeAdverse.Text;
            
            int idGarage, idExpert, idContrat;
            idGarage = Int32.Parse(DropDownList_SinistreGaragiste.SelectedItem.Value);
            idExpert = Int32.Parse(DropDownList_SinistreListeExpert.SelectedItem.Value);
            idContrat = Int32.Parse(DropDownList_Immatriculation.SelectedItem.Value);
            Javascript.ConsoleLog(idGarage.ToString());
            Javascript.ConsoleLog(idExpert.ToString());
            Javascript.ConsoleLog(idContrat.ToString());
            
            
            
            UserAccount Garagiste = u.Users.Find(idGarage);
            Javascript.ConsoleLog("Garagiste : "+Garagiste.FirstName+Garagiste.LastName+Garagiste.Role);
            UserAccount Expert = u.Users.Find(idExpert);
            Javascript.ConsoleLog("Expert : " + Expert.FirstName + Expert.LastName + Expert.Role);
            s.GarageExperts.Add(Garagiste);
            s.GarageExperts.Add(Expert);
            s.Contrat = u.Contrats.Find(idContrat);

            Javascript.ConsoleLog(s.Contrat.Souscripteur.Nom);

            u.Sinistres.Add(s);
            u.SaveChanges();





        }

        protected void Button_AjouterGarantie_Click(object sender,EventArgs e)
        {
            Javascript.ConsoleLog("ajout garantie");
            ContratGarantie cg = new ContratGarantie();

            cg.ContratId = Int32.Parse(DropDownList_ListeContrat.SelectedItem.Value);
            cg.GarantieId = Int32.Parse(DropDownList_ListeGarantie.SelectedItem.Value);
            Javascript.ConsoleLog("Contrat Id: " + cg.ContratId + " | Garantie Id: " + cg.GarantieId);
            int i = 0;
            Int32.TryParse(TextBox_Capital.Text, out i);
            cg.Capital = i;
            Int32.TryParse(TextBox_Franchise.Text, out i);
            cg.Franchise = i;

            //Checking if contratGarantie already exist
            try
            {
                u.ContratsGarantie.Add(cg);
                u.SaveChanges();
            }
            catch
            {
                Response.Write("<script>alert('Garantie existe deja pour ce contrat');</script>");
            }


            
        }

        protected void Button_EnregistrerContrat_Click(object sender, EventArgs e)
        {
            //Enregistrement du contrat
            Contrat c = new Contrat();
            c.Compagnie = _CCompagnie.Text;
            c.Agence = _CAgence.Text;
            c.Categorie = _CCategorie.Text;
            int i = 0;
            Int32.TryParse(DropDownList_ListeSouscripteur.SelectedItem.Value.ToString(), out i);
            c.SouscripteurId = i;
            Int32.TryParse(DropDownList_ListAssures.SelectedItem.Value.ToString(), out i);
            c.AssureId = i;
            Int32.TryParse(DropDownList_ListeVehicules.SelectedValue, out i);
            c.ContratId = i;
            c.DateSouscription = _CDateSouscription.Text;
            c.DateEffet = _CDateEffet.Text;
            c.Periodicite = _CPeriode.Text;
            Int32.TryParse(dropDownListFractionnement.SelectedValue,out i);
            c.Fractionnement = i;
            Int32.TryParse(_CPrime.Text, out i);
            c.PrimeAnnuelle = i;
            Int32.TryParse(_CPrimeComptant.Text, out i);
            c.PrimeComptant = i;
            c.DateEcheance = _CDateEchenace.Text;
            


            u.Contrats.Add(c);
            Javascript.ConsoleLog("avant");
            Javascript.ConsoleLog("assuré: " + c.AssureId.ToString() + " / Souscripteur :" + c.SouscripteurId.ToString());
            Javascript.ConsoleLog("apres");
            
            u.SaveChanges();
        }

        protected void Button_EnregistrerAssure_Click(object sender, EventArgs e)
        {
            Assure a = new Assure();
            Addresse A = new Addresse();
            Contact C = new Contact();
            int i = 0;
            a.TypeAssure = Radio_TypeAssure.SelectedItem.Value.ToString();
            a.TypeIdentifiant = _A_TypeIdentifiant.Text;
            Int32.TryParse(_A_Numero.Text, out i);
            a.NumeroIdentifiant = i;
            a.DateDelivreIdentifiant = _A_DelivreeLe.Text;
            a.Nom = _A_NomAssure.Text;
            a.Prenom = _A_Prenom.Text;
            a.DateDeNaissance = _A_DateNaissance.Text;
            a.LieuDeNaissance = _A_LieuNaissance.Text;
            a.Sexe = DropDownList_SexAssure.SelectedItem.Value.ToString();
            a.SituationFamiliale = _A_SituationFamiliale.Text;
            a.Profession = _A_Profession.Text;
            a.NumeroPermis = _A_NumPermis.Text;
            a.DateDelivrePermis = _A_DatePermis.Text;
            A.Adresse = TextBox_AddresseAssure.Text;
            A.Ville = TextBox_VilleAssure.Text;
            i = 0;
            Int32.TryParse(TextBox_CodePostalAssure.Text, out i);
            A.CodePostal = i;
            Int32.TryParse(TextBox_TelephoneAssure.Text, out i);
            C.Telephone = i;
            i = 0;
            Int32.TryParse(TextBox_MobileAssure.Text, out i);
            C.Mobile = i;
            i = 0;
            Int32.TryParse(TextBox_FaxAssure.Text, out i);
            C.Fax = i;
            i = 0;
            a.Addresse = A;
            a.Contact = C;
            u.Assures.Add(a);
            u.SaveChanges();
            Javascript.ConsoleLog("clicked Assuré add");

        }

        protected void Button_EnregistrerSouscripteur_Click(object sender, EventArgs e)
        {
            Souscripteur s = new Souscripteur();
            s.Nom = TextBox_SouscripteurNom.Text;
            s.RaisonSocial = TextBox_RaisonSociale.Text;
            s.FormeJuridique = TextBox_FormeJuridrique.Text;
            s.TypeIdentifiant = TextBox_TypeId.Text;
            s.TypeSouscripteur = Radio_TypeSouscripteur.SelectedItem.Value.ToString();
            s.RaisonSocial = TextBox_RaisonSociale.Text;
            s.Activite = TextBox_Activite.Text;
            int i = 0;
            Int32.TryParse(TextBox_CodePostal.Text, out i);
            Addresse a = new Addresse
            {
                Adresse = TextBox_Adresse_Souscripteur.Text,
                Ville = TextBox_VilleSouscripteur.Text,
                CodePostal = i 
            };

            s.Addresse = a;
            int j=0,k=0;
            Int32.TryParse(TextBox_SouscripteurTelephone.Text, out i);
            Int32.TryParse(TextBox_SouscripteurMobile.Text, out j);
            Int32.TryParse(TextBox_SouscripteurFax.Text, out k);
            Contact c = new Contact
            {
                Email = TextBox_SouscripteurEmail.Text,
                
                Telephone = i,
                
                Mobile = j,
                
                Fax = k
        };

            s.Contact = c;
            s.Numero = TextBox_Numero.Text;
            s.DateCreation = TextBox_DateCreation.Text;
            s.DateDelivre = TextBox_Delivre.Text;
            u.Souscripteurs.Add(s);
            u.SaveChanges();

            Javascript.ConsoleLog("clicked Souscriteur add");
            
            Javascript.ConsoleLog(Radio_TypeSouscripteur.SelectedItem.Value.ToString());
        }

        protected void Button_EnregistrerVehicule_Click(object sender, EventArgs e)
        {
            Vehicule V = new Vehicule();
            V.Matricule = TextBox_Immatriculation.Text;
            V.Genre = TextBox_Genre.Text;
            V.Usage = TextBox_Usage.Text;
            V.Constructeur = TextBox_Constructeur.Text;
            V.Marque = TextBox_Marque.Text;
            V.Couleur = TextBox_Couleur.Text;
            V.Constructeur = TextBox_Constructeur.Text;
            V.NumeroDeSerie = TextBox_NumSerie.Text;
            V.DPMC = TextBox_DPMC.Text;
            V.Carrosserie = TextBox_Carroserie.Text;
            int i=0;
            Int32.TryParse( TextBox_NbPlace.Text,out i);
            V.NombreDePlace = i;
            Int32.TryParse(TextBox_NbrDebout.Text,out i);
            V.NombreDebout = i;
            V.Energie = TextBox_Energie.Text;
            Int32.TryParse(TextBox_Puissane.Text,out i);
            V.PuissanceFiscale = i ;
            Int32.TryParse(TextBox_Cylindree.Text, out i);
            V.Cylindree = i;
            Int32.TryParse(TextBox_Poidvide.Text,out i);
            V.PoidVide = i;
            Int32.TryParse(TextBox_ChargeUtile.Text, out i);
            V.CHargeUtile = i;
            Int32.TryParse(TextBox_PTAC.Text, out i);
            V.PTAC = i;
            Int32.TryParse(TextBox_Remorque.Text, out i);
            V.NumeroRemorque = i;
            V.TypeRemorque = TextBox_TypeRemorque.Text;
            Int32.TryParse(TextBox_PoidVideRemorque.Text, out i);
            V.PoidVideRemorque = i;
            Int32.TryParse(TextBox_ChargeUtileRemorque.Text, out i);
            V.ChargeUtileRemorque = i;
            V.Organisme = TextBox_Organisme.Text;
            Int32.TryParse(TextBox_Duree.Text, out i);
            V.Duree = i;
            Int32.TryParse(TextBox_Valeurvénal.Text, out i);
            V.ValeurVenale = i;
            Int32.TryParse(TextBox_ValeuràNeuf.Text, out i);
            V.ValeurANeuf = i;
            Int32.TryParse(TextBox_Classe.Text,out i);
            V.Classe = i;
            V.Companie = TextBox_Compagnie.Text;
            V.DateReleve = TextBox_DateReleve.Text;
            V.Delegation = true;
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(V);
            Javascript.ConsoleLog(json);

            
            u.Vehicules.Add(V);
            u.SaveChanges();
        }
    }
}