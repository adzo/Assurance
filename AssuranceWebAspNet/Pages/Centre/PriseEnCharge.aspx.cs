using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Centre
{
    public partial class PriseEnCharge : System.Web.UI.Page
    {
        Sinistre sinis = new Sinistre();
        Assure asur = new Assure();
        Contrat cont = new Contrat();
        Souscripteur sous = new Souscripteur();
        UserDbContext usr = new UserDbContext();
        ListItem i;
        int sinistreId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["param1"] != null)
            {
                sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
                sinis = usr.Sinistres.Find(sinistreId);
                //Remplissage des champs:
                //Contrat view
                populateContratFields();
                //Souscripteur view
                populateSouscripteurFields();
                //Assuré view
                populateAssureFields();
                //Garantie Views
                List<ContratGarantie> listeGaranties = sinis.Contrat.Garanties.ToList();
                if (listeGaranties != null)
                {
                    foreach(ContratGarantie c in listeGaranties)
                    {
                        switch (c.GarantieId)
                        {
                            case 1:
                                LabelCapital1.Text = c.Capital.ToString();
                                LabelFrancise1.Text = c.Franchise.ToString();
                                break;
                            case 2:
                                LabelCapital2.Text = c.Capital.ToString();
                                LabelFrancise2.Text = c.Franchise.ToString();
                                break;
                            case 3:
                                LabelCapital3.Text = c.Capital.ToString();
                                LabelFrancise3.Text = c.Franchise.ToString();
                                break;
                            case 4:
                                LabelCapital4.Text = c.Capital.ToString();
                                LabelFrancise4.Text = c.Franchise.ToString();
                                break;
                            case 5:
                                LabelCapital5.Text = c.Capital.ToString();
                                LabelFrancise5.Text = c.Franchise.ToString();
                                break;
                            case 6:
                                LabelCapital6.Text = c.Capital.ToString();
                                LabelFrancise6.Text = c.Franchise.ToString();
                                break;

                        }
                    }
                    
                }
                //Sinistre View
                populateSinistreFields();
            }
            else
            {
                Response.Redirect("~/Pages/Centre/ListeSinistre.aspx");
            }


        }

        private void populateSinistreFields()
        {
            
        }

        private void populateContratFields()
        {
            cont = sinis.Contrat;
            _CCompagnie.Text = cont.Compagnie;
            _CContrat.Text = cont.ContratName;
            _CSouscripteur.Text = cont.Souscripteur.Nom;
            _CDateSous.Text = cont.DateSouscription;
            _CPeriode.Text = cont.Periodicite;
            switch (cont.Fractionnement)
            {
                case 1:
                    _CFractionnement2.Text = "Annuel";
                    break;
                case 2:
                    _CFractionnement2.Text = "Semestriel";
                    break;
                case 4:
                    _CFractionnement2.Text = "Trimestriel";
                    break;
                case 12:
                    _CFractionnement2.Text = "Mensuel";
                    break;
            }
            _CPrime.Text = cont.PrimeAnnuelle.ToString();
            _CAgence.Text = cont.Agence;
            _CCategorie.Text = cont.Categorie;
            _CAssure.Text = cont.Assure.Nom + ", " + cont.Assure.Prenom;
            _CDateEffet.Text = cont.DateEffet;
            _CDateEchenace.Text = cont.DateEcheance;
            _CPrimeComptant.Text = cont.PrimeComptant.ToString();
        }

        private void populateSouscripteurFields()
        {
            sous = sinis.Contrat.Souscripteur;
            _TypeId.Text = sous.TypeIdentifiant;
            _Numero.Text = sous.Numero;
            _RaisonSoc.Text = sous.RaisonSocial;
            _DateCreation.Text = sous.DateCreation;
            _FormeJuridrique.Text = sous.FormeJuridique;
            _Activite.Text = sous.Activite;
            _DelivreLe.Text = sous.DateDelivre;
            LabelSouscripteurAddresse.Text = sous.Addresse.Adresse;
            LabelSouscripteurVille.Text = sous.Addresse.Ville;
            LabelSouscripteurCode.Text = sous.Addresse.CodePostal.ToString();
            LabelSouscripteurTelephone.Text = sous.Contact.Telephone.ToString();
            LabelSouscripteurMobile.Text = sous.Contact.Mobile.ToString();
            LabelSouscripteurFax.Text = sous.Contact.Fax.ToString();
            LabelSouscripteurMail.Text = sous.Contact.Email;
        }

        public void populateAssureFields()
        {
            asur = sinis.Contrat.Assure;
            LabelAssureAdresse.Text = asur.Addresse.Adresse;
            LabelAssureCodePostal.Text = asur.Addresse.CodePostal.ToString();
            LabelAssureVille.Text = asur.Addresse.Ville;
            LabelAssureTelephone.Text = asur.Contact.Telephone.ToString();
            LabelAssureFax.Text = asur.Contact.Fax.ToString();
            LabelAssureMail.Text = asur.Contact.Email;
            LabelAssureMobile.Text = asur.Contact.Mobile.ToString();
            _A_TypeIdentifiant.Text = asur.TypeIdentifiant;
            _A_Numero.Text = asur.NumeroIdentifiant.ToString();
            _A_DelivreeLe.Text = asur.DateDelivreIdentifiant;
            _A_NomAssure.Text = asur.Nom;
            _A_Prenom.Text = asur.Prenom;
            _A_DateNaissance.Text = asur.DateDeNaissance;
            _A_LieuNaissance.Text = asur.LieuDeNaissance;
            _A_SituationFamiliale.Text = asur.SituationFamiliale;
            _A_Profession.Text = asur.Profession;
            _A_NumPermis.Text = asur.NumeroPermis;
            _A_Sexe.Text = asur.Sexe;
        }

        
    }
}