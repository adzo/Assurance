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
        Vehicule car = new Vehicule();
        Contrat cont = new Contrat();
        Souscripteur sous = new Souscripteur();
        Exam.Domain.Entities.Assure asur = new Exam.Domain.Entities.Assure();
        string guid = Guid.NewGuid().ToString();
        int sinistreId;
        Sinistre sinis = new Sinistre();
        UserDbContext usr = new UserDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assurance/PriseEnCharge";
            if (Request.QueryString["param1"] != null)
            {
                sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
                sinis = usr.Sinistres.Find(sinistreId);
                if(sinis == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect","alert('Sinistre inexistant!'); window.location='listeSinistre.aspx';", true);
                }
                else
                {
                    //Populate all Fields
                    PopulateGarantieView();
                    PopulateTableBonDeSortie();
                    PopulateVehiculeView();
                    PopulateContratFields();
                    PopulateAssureFields();
                    PopulateSouscripteurFields();
                    PopulateSinistreFields();
                    LoadRapportFinaux();
                    LoadRapportInitiaux();
                    LoadPhotoAvantReparation();
                    LoadPhotoApresReparation();
                    loadFactures();
                    LoadDevis();

                    //Hide the upload bon de sortie field
                    if (sinis.BonsDeSortie != null)
                    {
                        divUploadBonDeSortie.Visible = false;
                    }
                }

            }
            else
            {
                Response.Redirect("listeSinistre.aspx");
            }
        }

        private void LoadDevis()
        {
            table_DevisReparationView.Rows.Clear();
            TableHeaderRow th = new TableHeaderRow();
            TableHeaderCell cellDateH, cellConformiteH, cellDevisH;
            TableRow tr;
            TableCell cellDate, cellConformite, cellDevis;
            cellDateH = new TableHeaderCell() { Text = "Date" };
            cellConformiteH = new TableHeaderCell() { Text = "Conformité" };
            cellDevisH = new TableHeaderCell() { Text = "Devis" };
            th.Cells.Add(cellDateH);
            th.Cells.Add(cellConformiteH);
            th.Cells.Add(cellDevisH);
            table_DevisReparationView.Rows.Add(th);
            
            if (listeDevis() != null)
            {
                foreach (Devis dev in listeDevis())
                {
                    
                        tr = new TableRow();
                        
                        cellDate = new TableCell() { Text = dev.DateDevis };
                        cellConformite = new TableCell() { Text = dev.Conformite };
                        

                        
                        cellDevis = new TableCell() { Text = "Devis" };
                        tr.Cells.Add(cellDate);
                        tr.Cells.Add(cellConformite);
                        tr.Cells.Add(cellDevis);
                        table_DevisReparationView.Rows.Add(tr);
                    

                }
            }
        }

        private void loadFactures()
        {
            UserAccount garage = sinis.GarageExperts.Where(u => u.Role == "Garage").First();
            Label_GarageReparationView.Text = garage.FirstName + ", " + garage.LastName;
            tableFactureReparationView.Rows.Clear();
            TableHeaderCell hDate, hRapport;
            TableCell date, rapport;
            TableHeaderRow th = new TableHeaderRow();
            TableRow tr;
            hDate = new TableHeaderCell() { Text = "Date" };

            hRapport = new TableHeaderCell() { Text = "Facture" };
            
            th.Cells.Add(hDate);

            th.Cells.Add(hRapport);
            tableFactureReparationView.Rows.Add(th);
            foreach (Facture fact in sinis.Factures.ToList())
            {
                tr = new TableRow();
                date = new TableCell() { Text = fact.DateFacture };
                rapport = new TableCell() { Text = fact.LinkFacture };


                tr.Cells.Add(date);

                tr.Cells.Add(rapport);
                tableFactureReparationView.Rows.Add(tr);

            }
        }
            private void LoadPhotoAvantReparation()
        {
            //tablePhotoAvantReparation

            tablePhotoAvantReparation.Rows.Clear();
                TableCell cellID, cellPhotoName, cellPhotoDate, cellConsult;
                TableRow tr = new TableRow();
                cellID = new TableCell() { Text = "N°" };
                cellPhotoName = new TableCell() { Text = "Name" };
                cellPhotoDate = new TableCell() { Text = "Date" };
                cellConsult = new TableCell() { Text = "Consulter" };

                tr.Cells.Add(cellID);
                tr.Cells.Add(cellPhotoName);
                tr.Cells.Add(cellPhotoDate);
                tr.Cells.Add(cellConsult);

            tablePhotoAvantReparation.Rows.Add(tr);
                tr = new TableRow();
                LinkButton link, delLink;
                //Liste des images
                List<ImageSinistre> listeImage = listeImageAvantReparation();
                foreach (ImageSinistre img in listeImage)
                {
                    tr = new TableRow();
                    link = new LinkButton();
                    delLink = new LinkButton();

                    link.ID = img.ImageLink;
                    link.Text = "Consulter";
                    link.Click += new EventHandler(LoadImageIntoPopup);
                    cellConsult = new TableCell();
                    cellConsult.Controls.Add(link);
                    cellID = new TableCell() { Text = "N°" };
                    cellPhotoName = new TableCell() { Text = img.ImageName };
                    cellPhotoDate = new TableCell() { Text = img.DateImage };

                    tr.Cells.Add(cellID);
                    tr.Cells.Add(cellPhotoName);
                    tr.Cells.Add(cellPhotoDate);
                    tr.Cells.Add(cellConsult);

                tablePhotoAvantReparation.Rows.Add(tr);
                }


            
        }
        private List<Devis> listeDevis()
        {

            return sinis.Devis.ToList();
        }
        private void LoadPhotoApresReparation()
        {
           
            tablePhotoApresReparation.Rows.Clear();
            TableCell cellID, cellPhotoName, cellPhotoDate, cellConsult;
            TableRow tr = new TableRow();
            cellID = new TableCell() { Text = "N°" };
            cellPhotoName = new TableCell() { Text = "Name" };
            cellPhotoDate = new TableCell() { Text = "Date" };
            cellConsult = new TableCell() { Text = "Consulter" };

            tr.Cells.Add(cellID);
            tr.Cells.Add(cellPhotoName);
            tr.Cells.Add(cellPhotoDate);
            tr.Cells.Add(cellConsult);

            tablePhotoApresReparation.Rows.Add(tr);
            tr = new TableRow();
            LinkButton link;
            //Liste des images
            List<ImageSinistre> listeImage = listeImageApresReparation();
            foreach (ImageSinistre img in listeImage)
            {
                tr = new TableRow();
                link = new LinkButton();
                


                link.ID = img.ImageLink;
                link.Text = "Consulter";
                link.Click += new EventHandler(LoadImageIntoPopup);
                cellConsult = new TableCell();
                cellConsult.Controls.Add(link);
                cellID = new TableCell() { Text = "N°" };
                cellPhotoName = new TableCell() { Text = img.ImageName };
                cellPhotoDate = new TableCell() { Text = img.DateImage };

                tr.Cells.Add(cellID);
                tr.Cells.Add(cellPhotoName);
                tr.Cells.Add(cellPhotoDate);
                tr.Cells.Add(cellConsult);

                tablePhotoApresReparation.Rows.Add(tr);
            }



        }

        private void LoadImageIntoPopup(object sender, EventArgs e)
        {
            //Chargement de l'image dans le popup
            LinkButton source = (LinkButton)sender;
            ImageSinistre result = usr.Images.Where(s => s.ImageLink == source.ID).FirstOrDefault();

            Msg.Text = result.DateImage;
            ImageAvantReparationPreview.ImageUrl = "../../UploadedFiles/Images/" + source.ID;
            ModalPopupExtender1.Show();
        }

        private List<ImageSinistre> listeImageAvantReparation()
        {
            List<ImageSinistre> list = sinis.Images.ToList();
            List<ImageSinistre> ResultList = new List<ImageSinistre>();
            foreach (ImageSinistre img in list)
            {
                if (img.Status == "Avant" && img.SinistreId == sinistreId)
                {
                    ResultList.Add(img);
                }
            }
            return ResultList;
        }
        private List<ImageSinistre> listeImageApresReparation()
        {
            List<ImageSinistre> list = sinis.Images.ToList();
            List<ImageSinistre> ResultList = new List<ImageSinistre>();
            foreach (ImageSinistre img in list)
            {
                if (img.Status == "Apres" && img.SinistreId == sinistreId)
                {
                    ResultList.Add(img);
                }
            }
            return ResultList;
        }

        private void LoadRapportInitiaux()
        {
            UserAccount expert = sinis.GarageExperts.Where(u => u.Role == "Expert").First();
            Label_ExpertExpertiseView.Text = expert.FirstName + ", " + expert.LastName;

            tableRapportInitiaux.Rows.Clear();
            TableHeaderCell hDate, hVersion, hRapport;
            TableCell date, version, rapport;
            TableHeaderRow th = new TableHeaderRow();
            TableRow tr;
            hDate = new TableHeaderCell() { Text = "Date" };
            hVersion = new TableHeaderCell() { Text = "Version" };
            hRapport = new TableHeaderCell() { Text = "Rapport" };

            th.Cells.Add(hDate);
            th.Cells.Add(hVersion);
            th.Cells.Add(hRapport);

            tableRapportInitiaux.Rows.Add(th);
            foreach (Rapport rap in ListeRapport("Primaire"))
            {
                tr = new TableRow();
                date = new TableCell() { Text = rap.DateRapport };
                version = new TableCell() { Text = rap.Version.ToString() };
                rapport = new TableCell() { Text = rap.RapportName };


                tr.Cells.Add(date);
                tr.Cells.Add(version);
                tr.Cells.Add(rapport);

                tableRapportInitiaux.Rows.Add(tr);

            }

        }

        //Vue Vehicule populate fields
        private void PopulateVehiculeView()
        {
            car = sinis.Contrat.Vehicule;
            if (car != null)
            {
                _Immatriculation.Text = car.Matricule;
                _Constructeur.Text = car.Constructeur;
                _TypeConstructeur.Text = car.TypeConstructeur;
                _Carroserie.Text = car.Carrosserie;
                _Energie.Text = car.Energie;
                _Poidvide.Text = car.PoidVide.ToString();
                _Remorque.Text = car.NumeroRemorque.ToString();
                _TypeRemorque.Text = car.TypeRemorque;
                if (car.Delegation)
                {
                    _Delegation.Text = "Oui";
                }
                else
                {
                    _Delegation.Text = "Non";
                }
                _ValeuràNeuf.Text = car.ValeurANeuf.ToString();
                _Classe.Text = car.Classe.ToString();
                _Genre.Text = car.Genre;
                _Marque.Text = car.Marque;
                _NumSerie.Text = car.NumeroDeSerie;
                _NbPlace.Text = car.NombreDePlace.ToString();
                _Puissane.Text = car.PuissanceFiscale.ToString() + " ch";
                _ChargeUtile.Text = car.CHargeUtile.ToString();
                _PoidVd.Text = car.PoidVideRemorque.ToString();
                _Organisme.Text = car.Organisme;
                _Valeurvénal.Text = car.ValeurVenale.ToString();
                _Contrat.Text = car.Contrat.ContratName;
                _Compagnie.Text = car.Companie;
                _Usage.Text = car.Usage;
                _Couleur.Text = car.Couleur;
                _DPMC.Text = car.DPMC;
                _NbrDebout.Text = car.NombreDebout.ToString();
                _Cylindree.Text = car.Cylindree.ToString();
                _PTAC.Text = car.PTAC.ToString();
                _ChargeUtil.Text = car.ChargeUtileRemorque.ToString();
                _Duree.Text = car.Duree.ToString();
                _DateReleve.Text = car.DateReleve;

            }
        }

        private void PopulateSinistreFields()
        {
            UserAccount expert = new UserAccount();
            if (sinis != null)
            {
                foreach (UserAccount user in sinis.GarageExperts)
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
                _S_PartResp.Text = sinis.PartDeResponsabilite.ToString();
                _S_MontantInd.Text = sinis.MontantIndemnisation.ToString();
                _S_CompagnieAdv.Text = sinis.CompagnieAdverse;
                _S_DateIndm.Text = sinis.DateIndemnisation;
                _S_VehiculeAdverse.Text = sinis.VehiculeAdverse;
                UserAccount garage;
                garage = sinis.GarageExperts.Where(e => e.Role == "Garage").FirstOrDefault();
                if (garage != null)
                {
                    _SGarage.Text = garage.FirstName + " ," + garage.LastName;
                }
                else
                {
                    _SGarage.Text = "En cours d'affectation";
                }
                if (sinis.Indemnise)
                {
                    _SIndemnise.Text = "Oui";
                }
                else
                {
                    _SIndemnise.Text = "Non";
                }
                if (sinis.IDA)
                {
                    _SIDA.Text = "Oui";
                }
                else
                {
                    _SIDA.Text = "Non";
                }

                _S_Garantie.Text = sinis.GarantieSinistre;
            }
            }
        
        private void PopulateContratFields()
        {
            cont = sinis.Contrat;
            if (cont != null)
            {

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

        }

        private void PopulateSouscripteurFields()
        {

            sous = sinis.Contrat.Souscripteur;
            if (sous != null)
            {
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

        }

        public void PopulateAssureFields()
        {
            asur = sinis.Contrat.Assure;
            if (asur != null)
            {
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

        public void LoadRapportFinaux()
        {
            TableRapportFinaux.Rows.Clear();
            TableHeaderCell hDate, hVersion, hRapport;
            TableCell date, version, rapport;
            TableHeaderRow th = new TableHeaderRow();
            TableRow tr;
            hDate = new TableHeaderCell() { Text = "Date" };
            hVersion = new TableHeaderCell() { Text = "Version" };
            hRapport = new TableHeaderCell() { Text = "Rapport" };
            
            th.Cells.Add(hDate);
            th.Cells.Add(hVersion);
            th.Cells.Add(hRapport);
            
            TableRapportFinaux.Rows.Add(th);
            foreach (Rapport rap in ListeRapport("Final"))
            {
                tr = new TableRow();
                date = new TableCell() { Text = rap.DateRapport };
                version = new TableCell() { Text = rap.Version.ToString() };
                rapport = new TableCell() { Text = rap.RapportName };
                

                tr.Cells.Add(date);
                tr.Cells.Add(version);
                tr.Cells.Add(rapport);
                
                TableRapportFinaux.Rows.Add(tr);

            }


        }


        public List<Rapport> ListeRapport(string type)
        {
            List<Rapport> All = usr.Rapports.OrderByDescending(s => s.Version).ToList();
            List<Rapport> resultList = new List<Rapport>();
            foreach (Rapport r in All)
            {
                if (r.SinistreId == sinistreId && r.RapportExtension.Equals(type))
                {
                    resultList.Add(r);
                }
            }

            return resultList;

        }





        public void btnChercher_Click(object sender, EventArgs e)
        {
            int Id;
            if (Int32.TryParse(_TxtNumSinistre.Text, out Id))
            {
                Response.Redirect("../../Pages/Assurance/PriseEncharge.aspx?param1=" + Id);
            }
        }

        //Bouton d'Ajout de bon de sortie
        public void ButtonAjouterBonDeSortie_Click(object sender, EventArgs e)
        {
            if (FileUploadBonDeSortie.HasFile)
            {
                string path = Server.MapPath("../../UploadedFiles/BonDeSortie/");
                BonDeSortie Rap = new BonDeSortie();
                string extension = System.IO.Path.GetExtension(FileUploadBonDeSortie.FileName);
                if (true)
                {
                    Rap.BonDeSortieNonSigne = guid + FileUploadBonDeSortie.FileName;
                    Rap.DateCreation = DateTime.Now.ToString("dd-MM-yyyy");
                    Rap.Sinistre = sinis;
                    
                    usr.BonDeSorties.Add(Rap);
                    FileUploadBonDeSortie.SaveAs(path + Rap.BonDeSortieNonSigne);
                    sinis.Phase = "Edition Bon De Sortie";
                    usr.SaveChanges();
                    Page_Load(sender, e);
                }
            }
        }

        //Contract view:
        public void PopulateGarantieView()
        {
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
            LabelVehiculeNumero.Text = sinis.Contrat.Vehicule.Id.ToString();
            LabelVehiculeMatricule.Text = sinis.Contrat.Vehicule.Matricule;
            LabelVehiculeDPMC.Text = sinis.Contrat.Vehicule.DPMC;
            LabelVehiculeConstructeur.Text = sinis.Contrat.Vehicule.Constructeur;
            LabelTableVehiculeMarque.Text = sinis.Contrat.Vehicule.Marque;
            LabelTableVehiculeEnergie.Text = sinis.Contrat.Vehicule.Energie;
            LabelTableVehiculePuissance.Text = sinis.Contrat.Vehicule.PuissanceFiscale.ToString() + " ch";
            LabelTableVehiculeNombrePlace.Text = sinis.Contrat.Vehicule.NombreDePlace.ToString();
            LabelTableVehiculeClasse.Text = sinis.Contrat.Vehicule.Classe.ToString();
            LabelVehiculeUsage.Text = sinis.Contrat.Vehicule.Usage;
        }

        //Chargement Bon de Sortie si existant:
        public void PopulateTableBonDeSortie()
        {
            BonDeSortie bon = sinis.BonsDeSortie;
            if (bon != null)
            {
                    LabelBonDeSortieNumero.Text = bon.BonDeSortieId.ToString();
                    LabelBonDeSortieDate.Text = bon.DateCreation;
                    ViewNonSigne.Text = bon.BonDeSortieNonSigne;
                    ViewSigne.Text = bon.BonDeSortieSigne;
            }
            //BonDeSortie bon = usr.BonDeSorties.FirstOrDefault(s => s.SinistreId == sinis.SinistreId);
            //if(bon != null)
            //{
            //    LabelBonDeSortieNumero.Text = bon.BonDeSortieId.ToString();
            //    LabelBonDeSortieDate.Text = bon.DateCreation;

            //}
        }
    }
}