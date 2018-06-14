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
    string guid = Guid.NewGuid().ToString();
    int sinistreId;
    Sinistre sinis = new Sinistre();
    UserDbContext usr = new UserDbContext();
    BonDeSortie bon;
    Facture fact;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["target"] = "/Pages/Garagiste/PriseCharge";
        if (Request.QueryString["param1"] != null)
        {
            sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
            sinis = usr.Sinistres.Find(sinistreId);
            PopulateSinistreFields(sinis);
            LoadDevis();
            LoadImagesApresReparation();
            LoadFactures();
            if (sinis.BonsDeSortie != null)
            {
                divUploadBonDeSortie.Visible = true;
            }
            else
            {
                divUploadBonDeSortie.Visible = false;
            }
            //loadBonDeSortie();
            PopulateTableBonDeSortie();
        }
        else
        {
            Response.Redirect("ListeSinistre.aspx");
        }
        //populateSinistreFields();
        Javascript.ConsoleLog(sinistreId.ToString());


    }
    private List<Devis> listeDevis()
    {

        return sinis.Devis.ToList();
    }
    private void LoadDevis()
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
                    TableDevis.Rows.Add(tr);
                

            }
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
    public void LoadImageIntoPopup(object sender, EventArgs e)
    {
        //Chargement de l'image dans le popup
        LinkButton source = (LinkButton)sender;
        ImageSinistre result = usr.Images.Where(s => s.ImageLink == source.ID).FirstOrDefault();

        Msg.Text = result.DateImage;
        ImageAvantReparationPreview.ImageUrl = "../../UploadedFiles/Images/" + source.ID;
        ModalPopupExtender1.Show();
    }
    public void LoadImagesApresReparation()
    {
        Table_PhotoApresReparation.Rows.Clear();
        TableCell cellID, cellPhotoName, cellPhotoDate, cellConsult,cellDelete;
        TableRow tr = new TableRow();
        cellID = new TableCell() { Text = "N°" };
        cellPhotoName = new TableCell() { Text = "Name" };
        cellPhotoDate = new TableCell() { Text = "Date" };
        cellConsult = new TableCell() { Text = "Consulter" };
        cellDelete = new TableCell() { Text = "Supprimer" };

        tr.Cells.Add(cellID);
        tr.Cells.Add(cellPhotoName);
        tr.Cells.Add(cellPhotoDate);
        tr.Cells.Add(cellConsult);
        tr.Cells.Add(cellDelete);

        Table_PhotoApresReparation.Rows.Add(tr);
        tr = new TableRow();
        LinkButton link, delLink;
        //Liste des images
        List<ImageSinistre> listeImage = listeImageApresReparation();
        if (listeImage != null)
        {
            int i = 1;
            foreach (ImageSinistre img in listeImage)
            {
                tr = new TableRow();
                link = new LinkButton();
                delLink = new LinkButton()
                {
                    ID = "deleteImage"+img.Id,
                    Text = "Supprimer"
                };
                delLink.Click += new EventHandler(deleteImage);

                link.ID = img.ImageLink;
                link.Text = "Consulter";
                link.Click += new EventHandler(LoadImageIntoPopup);

                cellDelete = new TableCell();
                cellDelete.Controls.Add(delLink);
                cellConsult = new TableCell();
                cellConsult.Controls.Add(link);
                cellID = new TableCell() { Text = i.ToString() };
                i++;
                cellPhotoName = new TableCell() { Text = img.ImageName };
                cellPhotoDate = new TableCell() { Text = img.DateImage };

                tr.Cells.Add(cellID);
                tr.Cells.Add(cellPhotoName);
                tr.Cells.Add(cellPhotoDate);
                tr.Cells.Add(cellConsult);
                tr.Cells.Add(cellDelete);

                Table_PhotoApresReparation.Rows.Add(tr);
            }
        }
        


    }
    private void PopulateSinistreFields(Sinistre sinis)
    {
        LabelConducteur.Text = sinis.Conducteur;
        LabelMatricule.Text = sinis.Contrat.Vehicule.Matricule;
        LabelNature.Text = sinis.Nature;

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

        LabelCompagnieAdverse.Text = sinis.CompagnieAdverse;
        LabelDateSinistre.Text = sinis.DateSinistre;

        LabelVehiculeAdverse.Text = sinis.VehiculeAdverse;

    }

    public void LoadFactures()
    {
        favt_table.Rows.Clear();
        TableHeaderCell hDate, hRapport, hDel;
        TableCell date,rapport, del;
        TableHeaderRow th = new TableHeaderRow();
        TableRow tr;
        hDate = new TableHeaderCell() { Text = "Date" };
        
        hRapport = new TableHeaderCell() { Text = "Facture" };
        hDel = new TableHeaderCell() { Text = "Supprimer" };
        th.Cells.Add(hDate);
        
        th.Cells.Add(hRapport);
        th.Cells.Add(hDel);
        favt_table.Rows.Add(th);
        foreach (Facture fact in sinis.Factures.ToList())
        {
            tr = new TableRow();
            date = new TableCell() { Text = fact.DateFacture };
            rapport = new TableCell() { Text = fact.LinkFacture };
            LinkButton delLinkFact = new LinkButton()
            {
                Text = "Supprimer",
                ID = "delete"+fact.FactureId
            };
            delLinkFact.Click += new EventHandler(deleteFact);

            del = new TableCell() {};
            del.Controls.Add(delLinkFact);

            tr.Cells.Add(date);
            
            tr.Cells.Add(rapport);
            tr.Cells.Add(del);
            favt_table.Rows.Add(tr);

        }


    }
    public void deleteFact(object sender, EventArgs e)
    {
        LinkButton source = (LinkButton)sender;
        int FactId = Int32.Parse(source.ID.Remove(0, 6));
        Facture FoundFacture = usr.Factures.Find(FactId);
        usr.Factures.Remove(FoundFacture);
        usr.SaveChanges();
        Response.Write("<script>alert('Facture supprimée');</script>");
        Page_Load(sender, e);
    }
    public void deleteImage(object sender, EventArgs e)
    {
        LinkButton source = (LinkButton)sender;
        int ImageId = Int32.Parse(source.ID.Remove(0, 11));
        ImageSinistre FoundImage = usr.Images.Find(ImageId);
        usr.Images.Remove(FoundImage);
        usr.SaveChanges();
        Response.Write("<script>alert('Image supprimée');</script>");
        Page_Load(sender, e);
    }

    public void Button_RechercheSinistre_Click(object sender, EventArgs e)
    {
        int Id;
        if (Int32.TryParse(TextBox1_Sinistre.Text, out Id))
        {
            Response.Redirect("../../Pages/Garagiste/Prisecharge.aspx?param1=" + Id);
        }

    }

    public void ButtonUploadDevis_Click(object sender, EventArgs e)
    {
        if (FileUpload_Devis.HasFile)
        {
            string path = Server.MapPath("../../UploadedFiles/Devis/");
            Devis dev = new Devis();
            string extension = System.IO.Path.GetExtension(FileUpload_Devis.FileName);
            if (true)
            {
                dev.Sinistre = sinis;
                dev.DevisUrl = guid + FileUpload_Devis.FileName;
                dev.Conformite = null;
                dev.Sinistre = sinis;
                dev.DateDevis = DateTime.Now.ToString("dd-MM-yyyy");
                usr.Devis.Add(dev);
                FileUpload_Devis.SaveAs(path + dev.DevisUrl);
                sinis.Phase = "Confirmation de devis";
                usr.SaveChanges();
                Page_Load(sender, e);
            }
        }
    }

    //protected void Button_UploadBonDeSortie_Click(object sender, EventArgs e)
    //{

    //    bon = new BonDeSortie();
    //    if (sinis.BonsDeSortie != null)
    //    {
    //        if (FileUpload_BonDeSortieSigne.HasFile)
    //        {
    //            string path = Server.MapPath("../../UploadedFiles/BonDeSortie");
    //            sinis.BonsDeSortie.BonDeSortieSigne = guid + FileUpload_BonDeSortieSigne.FileName;
    //            sinis.Phase = "cloturé";
    //            FileUpload_BonDeSortieSigne.SaveAs(path + sinis.BonsDeSortie.BonDeSortieSigne);
    //            usr.SaveChanges();
    //        }
    //    }



    //}

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
    protected void Button_UploadPhotoAfterReparation_Click(object sender, EventArgs e)
    {
        ImageSinistre img = new ImageSinistre();
        if (FileUpload_PhotoAfterReparation.HasFile)
        {
            string path = Server.MapPath("../../UploadedFiles/Images/");
            img.ImageName = FileUpload_PhotoAfterReparation.FileName;
            img.ImageLink = guid+ FileUpload_PhotoAfterReparation.FileName;
            img.Status = "Apres";
            img.Extension =System.IO.Path.GetExtension(FileUpload_PhotoAfterReparation.FileName);
            img.DateImage = DateTime.Now.ToString("dd-MM-yyyy");
            
            sinis.Images.Add(img);
            
            FileUpload_PhotoAfterReparation.SaveAs(path + img.ImageLink);

            try
            {
                usr.SaveChanges();
                Page_Load(sender, e);
            }
            catch (Exception ex)
            {
                var rootCause = ex.GetBaseException();
                Javascript.ConsoleLog(rootCause.Message);
            }
            usr.SaveChanges();

        }
    }

    protected void Button_UploadFactures_Click(object sender, EventArgs e)
    {
        //fact = sinis.Factures.ToList();
        if (FileUpload_Factures.HasFile)
        {
            fact = new Facture();
            string path = Server.MapPath("../../UploadedFiles/Factures/");
            fact.LinkFacture = guid + FileUpload_Factures.FileName;
            fact.DateFacture = DateTime.Now.ToString("dd-MM-yyyy");
            sinis.Phase = "Confirmation Réparation";
            FileUpload_Factures.SaveAs(path + fact.LinkFacture);
            sinis.Factures.Add(fact);
            usr.SaveChanges();
            Page_Load(sender, e);
        }
    }

    public void ButtonAjouterBonDeSortie_Click(object sender, EventArgs e)
    {
        if (FileUploadBonDeSortie.HasFile)
        {
            string path = Server.MapPath("../../UploadedFiles/BonDeSortie/");

            BonDeSortie Rap = sinis.BonsDeSortie;
            string extension = System.IO.Path.GetExtension(FileUploadBonDeSortie.FileName);
            if (true)
            {
                Rap.BonDeSortieSigne = guid + FileUploadBonDeSortie.FileName;
                FileUploadBonDeSortie.SaveAs(path + Rap.BonDeSortieSigne);
                sinis.Phase = "Cloturé";
                usr.SaveChanges();
                Page_Load(sender, e);
            }
        }
    }
}