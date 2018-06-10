﻿using Exam.Data;
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
                if (!IsPostBack)
                {
                    //Contrat view
                    populateContratFields();
                    //Sinistre View
                    populateSinistreFields();
                    //Souscripteur view
                    populateSouscripteurFields();
                    //Assuré view
                    populateAssureFields();
                    //Garantie Views
                    List<ContratGarantie> listeGaranties = sinis.Contrat.Garanties.ToList();
                    if (listeGaranties != null)
                    {
                        foreach (ContratGarantie c in listeGaranties)
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
                    
                }
                    
            }
            
                
            
            


        }

        private void populateSinistreFields()
        {
            UserAccount expert = new UserAccount();
            foreach(UserAccount user in sinis.GarageExperts)
            {
                if (user != null)
                {
                    if (user.Role.Equals("Expert"))
                    {
                        expert = user;
                    }
                }
            }
            if (expert != null)
            {
                _S_Experts.Text = expert.FirstName + ", " + expert.LastName;
            }
            else
            {
                _S_Experts.Text = "Not Defined";
            }
            _S_Immatriculation.Text = sinis.Contrat.Vehicule.Matricule;
            _S_Conducteur.Text = sinis.Conducteur;
            _S_NumPermis.Text = sinis.NumeroPermis;
            _S_DateSinistre.Text = sinis.DateSinistre;
            _S_DatePermis.Text = sinis.DateDePermis;
            affectationGaragiste();

            ICollection<ContratGarantie> listeGarantie;
            listeGarantie = sinis.Contrat.Garanties.ToList();
            if (listeGarantie != null)
            {
                DropDownList_SinistreGarantieSinistre.Items.Clear();
                if (listeGarantie != null)
                {
                    foreach (ContratGarantie g in listeGarantie)
                    {

                        i = new ListItem(g.Garantie.GarantieName, g.Garantie.Id.ToString());
                        DropDownList_SinistreGarantieSinistre.Items.Add(i);
                    }
                }
                else
                {
                    i = new ListItem("Aucune Garantie", "1");
                    DropDownList_SinistreGarantieSinistre.Items.Add(i);
                }
                    
            }

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

        public void affectationGaragiste()
        {
            List<UserAccount> listeExpertGaragiste = usr.Users.ToList();
            if (listeExpertGaragiste != null)
               
            DropDownList_SinistreGaragiste.Items.Clear();
            {
                foreach (UserAccount u in listeExpertGaragiste)
                {
                    i = new ListItem(u.FirstName + ", " + u.LastName, u.UserId.ToString());
                    switch (u.Role)
                    {
                        
                        case "Garage":
                            DropDownList_SinistreGaragiste.Items.Add(i);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void Button_UpdateSinistre_Click(object sender, EventArgs e)
        {
            //Update Sinistre
            Sinistre s = new Sinistre();
            s=usr.Sinistres.Find(sinistreId);
            s.Conducteur = _S_Conducteur.Text;
            s.Nature = _S_Nature.Text;
            int i = 0;
            Int32.TryParse(RadioButtonList_Indemnite.SelectedValue, out i);
            s.Indemnise = Convert.ToBoolean(i);
            s.IDA = Convert.ToBoolean(Int32.Parse(RadioButtonList_IDA.SelectedValue));
            s.GarantieSinistre = "";
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
            s.Phase = "Expertise";

            sinis = s;
            int idGarage;
            idGarage = Int32.Parse(DropDownList_SinistreGaragiste.SelectedItem.Value);
            UserAccount Garagiste = usr.Users.Find(idGarage);
            s.GarageExperts.Add(Garagiste);

            usr.SaveChanges();

        }
    }
}