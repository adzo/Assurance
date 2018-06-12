using AssuranceWebAspNet.Utilities;
using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Expert
{

    public partial class PriseEnCharge : System.Web.UI.Page
    {
        string guid = Guid.NewGuid().ToString();

        int sinistreId;
        Sinistre sinis = new Sinistre();
        UserDbContext usr = new UserDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Expert/PriseEnCharge";
            if (Request.QueryString["param1"] != null)
            {
                sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
                sinis = usr.Sinistres.Find(sinistreId);
                PopulateSinistreFields(sinis);
                LoadImages();
                LoadRapport();
                LoadImagesApresReparation();
                LoadRapportFinaux();
                populateDevisTables();
            }
            else
            {
                Response.Redirect("ListeSinistre.aspx");
            }
            //populateSinistreFields();
            Javascript.ConsoleLog(sinistreId.ToString());
        }
        public void PopulateSinistreFields(Sinistre sinis)
        {
            LabelConducteur.Text = sinis.Conducteur;
            LabelMatricule.Text = sinis.Contrat.Vehicule.Matricule;
            LabelNature.Text = sinis.Nature;
            if (sinis.Indemnise)
            {
                LabelIndemnisation.Text = "Oui";
            }
            else
            {
                LabelIndemnisation.Text = "Non";
            }
            if (sinis.IDA)
            {
                LabelIDA.Text = "Oui";
            }
            else
            {
                LabelIDA.Text = "Non";
            }
            if (sinis.GarantieSinistre != null)
            {
                LabelGarantie.Text = sinis.GarantieSinistre;
            }
            else
            {
                LabelGarantie.Text = "Non définie";
            }
            LabelNumPermis.Text = sinis.NumeroPermis;
            LabelResponsabilite.Text = sinis.PartDeResponsabilite.ToString() + "%";
            LabelMontant.Text = sinis.MontantIndemnisation.ToString();
            LabelCompagnieAdverse.Text = sinis.CompagnieAdverse;
            LabelDateSinistre.Text = sinis.DateSinistre;
            LabelDatePermis.Text = sinis.DateDePermis;
            LabelDateIndemnisation.Text = sinis.DateIndemnisation;
            LabelVehiculeAdverse.Text = sinis.VehiculeAdverse;



        }
        public void Button_UploadImage_Click(object sender, EventArgs e)
        {
            if (FileUpload_ImageAvantReparation.HasFile)
            {
                string extension = System.IO.Path.GetExtension(FileUpload_ImageAvantReparation.FileName);
                if (1 == 1)
                {
                    string path = Server.MapPath("../../UploadedFiles/Images/");
                    ImageSinistre img = new Exam.Domain.Entities.ImageSinistre();
                    img.Extension = extension;
                    img.ImageLink = guid + FileUpload_ImageAvantReparation.FileName;
                    img.ImageName = FileUpload_ImageAvantReparation.FileName;
                    img.Sinistre = sinis;
                    img.Status = "Avant";
                    img.DateImage = DateTime.Now.ToString("dd-MM-yyyy");
                    usr.Images.Add(img);
                    FileUpload_ImageAvantReparation.SaveAs(path + img.ImageLink);
                    sinis.Phase = "Envoie des devis de réparation";
                    usr.SaveChanges();
                    Page_Load(sender, e);
                }
            }
            else
            {
                //file not uploaded
            }
        }
        public List<ImageSinistre> listeImageAvantReparation()
        {
            List<ImageSinistre> list = sinis.Images.ToList();
            List<ImageSinistre> ResultList = new List<ImageSinistre>();
            foreach (ImageSinistre img in list)
            {
                if (img.Status == "Avant" && img.Sinistre.SinistreId == sinistreId)
                {
                    ResultList.Add(img);
                }
            }
            return ResultList;
        }
        public void LoadImages()
        {
            TableImageAvantReparation.Rows.Clear();
            TableCell cellID, cellPhotoName, cellPhotoDate, cellConsult, cellSup;
            TableRow tr = new TableRow();
            cellID = new TableCell() { Text = "N°" };
            cellPhotoName = new TableCell() { Text = "Name" };
            cellPhotoDate = new TableCell() { Text = "Date" };
            cellConsult = new TableCell() { Text = "Consulter" };
            cellSup = new TableCell() { Text = "Supprimer" };
            tr.Cells.Add(cellID);
            tr.Cells.Add(cellPhotoName);
            tr.Cells.Add(cellPhotoDate);
            tr.Cells.Add(cellConsult);
            tr.Cells.Add(cellSup);
            TableImageAvantReparation.Rows.Add(tr);
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
                link.Text = "click image";
                link.Click += new EventHandler(LoadImageIntoPopup);
                cellConsult = new TableCell();
                cellConsult.Controls.Add(link);
                cellID = new TableCell() { Text = "N°" };
                cellPhotoName = new TableCell() { Text = img.ImageName };
                cellPhotoDate = new TableCell() { Text = img.DateImage };
                cellSup = new TableCell();
                delLink.Text = "Delete";
                delLink.ID = "del" + img.ImageLink;
                delLink.Click += new EventHandler(DeleteImage);
                cellSup.Controls.Add(delLink);

                tr.Cells.Add(cellID);
                tr.Cells.Add(cellPhotoName);
                tr.Cells.Add(cellPhotoDate);
                tr.Cells.Add(cellConsult);
                tr.Cells.Add(cellSup);
                TableImageAvantReparation.Rows.Add(tr);
            }


        }
        public void DeleteImage(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            string url = source.ID.Remove(0, 3);
            ImageSinistre result = usr.Images.Where(s => s.ImageLink == url).FirstOrDefault();
            if (result != null)
            {
                string path = Server.MapPath("../../UploadedFiles/Images/");
                if ((System.IO.File.Exists(path + url)))
                {
                    System.IO.File.Delete(path + url);
                }
                usr.Images.Remove(result);
                usr.SaveChanges();
            }
            LoadImages();
        }
        public void LoadImageIntoPopup(object sender, EventArgs e)
        {
            //Chargement de l'image dans le popup
            LinkButton source = (LinkButton)sender;
            ImageSinistre result = usr.Images.Where(s => s.ImageLink == source.ID).FirstOrDefault();

            Msg.Text = result.DateImage;
            ImageAvantReparationPreview.ImageUrl = "../../UploadedFiles/Images/" + source.ID;
            ModalPopupExtender1.Show();
        }
        public void ValiderDevis(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            Devis dev = usr.Devis.Where(s => s.DevisUrl == source.ID).FirstOrDefault();
            dev.Sinistre.Phase = "Réparation";
            dev.Conformite = "Conforme";
            usr.SaveChanges();
        }
        public void Button_UploadRapport_Click(object sender, EventArgs e)
        {
            if (FileUpload_RapportExpertise.HasFile)
            {
                string path = Server.MapPath("../../UploadedFiles/RapportExpertise/");
                Rapport Rap = new Rapport();
                string extension = System.IO.Path.GetExtension(FileUpload_RapportExpertise.FileName);
                if (true)
                {
                    Rap.RapportExtension = "Primaire";
                    Rap.Version = sinis.Rapports.Count();
                    Rap.RapportUrl = guid + FileUpload_RapportExpertise.FileName;
                    Rap.RapportName = FileUpload_RapportExpertise.FileName;
                    Rap.Sinistre = sinis;
                    Rap.DateRapport = DateTime.Now.ToString("dd-MM-yyyy");
                    usr.Rapports.Add(Rap);
                    FileUpload_RapportExpertise.SaveAs(path + Rap.RapportUrl);
                    sinis.Phase = "Envoie des devis de réparation";
                    usr.SaveChanges();
                    Page_Load(sender, e);
                }
            }
        }
        public void Button_UploadRapportFinal_Click(object sender, EventArgs e)
        {
            if (FileUpload_RapportExpertiseFinal.HasFile)
            {
                string path = Server.MapPath("../../UploadedFiles/RapportExpertise/");
                Rapport Rap = new Rapport();
                string extension = System.IO.Path.GetExtension(FileUpload_RapportExpertiseFinal.FileName);
                if (true)
                {
                    Rap.RapportExtension = "Final";
                    Rap.Version = sinis.Rapports.Count();
                    Rap.RapportUrl = guid + FileUpload_RapportExpertiseFinal.FileName;
                    Rap.RapportName = FileUpload_RapportExpertiseFinal.FileName;
                    Rap.Sinistre = sinis;
                    Rap.DateRapport = DateTime.Now.ToString("dd-MM-yyyy");
                    usr.Rapports.Add(Rap);
                    FileUpload_RapportExpertiseFinal.SaveAs(path + Rap.RapportUrl);
                    sinis.Phase = "Edition Bon De Sortie";
                    usr.SaveChanges();
                    Page_Load(sender, e);
                }
            }
        }
        public void LoadRapport()
        {
            TableRapportExpertise.Rows.Clear();
            TableHeaderCell hDate, hVersion, hRapport, hDel;
            TableCell date, version, rapport, del;
            TableHeaderRow th = new TableHeaderRow();
            TableRow tr;
            hDate = new TableHeaderCell() { Text = "Date" };
            hVersion = new TableHeaderCell() { Text = "Version" };
            hRapport = new TableHeaderCell() { Text = "Rapport" };
            hDel = new TableHeaderCell() { Text = "Supprimer" };
            th.Cells.Add(hDate);
            th.Cells.Add(hVersion);
            th.Cells.Add(hRapport);
            th.Cells.Add(hDel);
            TableRapportExpertise.Rows.Add(th);
            foreach (Rapport rap in ListeRapport("Primaire"))
            {
                tr = new TableRow();
                date = new TableCell() { Text = rap.DateRapport };
                version = new TableCell() { Text = rap.Version.ToString() };
                rapport = new TableCell() { Text = rap.RapportName };
                del = new TableCell() { Text = "Supprimer" };

                tr.Cells.Add(date);
                tr.Cells.Add(version);
                tr.Cells.Add(rapport);
                tr.Cells.Add(del);
                TableRapportExpertise.Rows.Add(tr);

            }


        }
        public void LoadRapportFinaux()
        {
            TableRapportExpertiseFinal.Rows.Clear();
            TableHeaderCell hDate, hVersion, hRapport, hDel;
            TableCell date, version, rapport, del;
            TableHeaderRow th = new TableHeaderRow();
            TableRow tr;
            hDate = new TableHeaderCell() { Text = "Date" };
            hVersion = new TableHeaderCell() { Text = "Version" };
            hRapport = new TableHeaderCell() { Text = "Rapport" };
            hDel = new TableHeaderCell() { Text = "Supprimer" };
            th.Cells.Add(hDate);
            th.Cells.Add(hVersion);
            th.Cells.Add(hRapport);
            th.Cells.Add(hDel);
            TableRapportExpertiseFinal.Rows.Add(th);
            foreach (Rapport rap in ListeRapport("Final"))
            {
                tr = new TableRow();
                date = new TableCell() { Text = rap.DateRapport };
                version = new TableCell() { Text = rap.Version.ToString() };
                rapport = new TableCell() { Text = rap.RapportName };
                del = new TableCell() { Text = "Supprimer" };

                tr.Cells.Add(date);
                tr.Cells.Add(version);
                tr.Cells.Add(rapport);
                tr.Cells.Add(del);
                TableRapportExpertiseFinal.Rows.Add(tr);

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
        public void LoadImagesApresReparation()
        {
            TableImageApresReparation.Rows.Clear();
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

            TableImageApresReparation.Rows.Add(tr);
            tr = new TableRow();
            LinkButton link, delLink;
            //Liste des images
            List<ImageSinistre> listeImage = listeImageApresReparation();
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

                TableImageApresReparation.Rows.Add(tr);
            }


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

        //public void Button_ConfirmationDevis_Click(object sender, EventArgs e)
        //{
        //    Javascript.ConsoleLog("clicked confirmer Devis");
        //    foreach(Control c in Page.Controls)
        //    {
        //        foreach(Control childc in c.Controls)
        //        {
        //            if (childc is DropDownList)
        //            {
        //                Devis dev = usr.Devis.Find(((DropDownList)c).SelectedValue);
        //                dev.Conformite = ((DropDownList)c).SelectedItem.Text;
        //                usr.SaveChanges();
        //            }
        //        } 
        //    }
        //}
        public void populateDevisTables()
        {
            TableDevis.Rows.Clear();
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
            TableDevis.Rows.Add(th);
            LinkButton link;
            if (listeDevis() != null)
            {
                foreach(Devis dev in listeDevis())
                {
                    if(dev.Conformite == null || dev.Conformite == "Non conforme")
                    {
                        tr = new TableRow();
                        link = new LinkButton();
                        link.ID = dev.DevisUrl;
                        link.Text = "Valider";
                        link.Click += new EventHandler(ValiderDevis);
                        cellDate = new TableCell() { Text = dev.DateDevis };
                        cellConformite = new TableCell();

                        cellConformite.Controls.Add(link);
                        cellDevis = new TableCell() { Text = "Devis" };
                        tr.Cells.Add(cellDate);
                        tr.Cells.Add(cellConformite);
                        tr.Cells.Add(cellDevis);
                        TableDevis.Rows.Add(tr);
                    }
                    
                }
            }

        }
        private List<Devis> listeDevis()
        {
            
            return sinis.Devis.ToList();
        }
    }
}