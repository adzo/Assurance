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

    protected void Page_Load(object sender, EventArgs e)
    {
        
            if (Request.QueryString["param1"] != null)
            {
                sinistreId = Int32.Parse(Request.QueryString["param1"].ToString());
                sinis = usr.Sinistres.Find(sinistreId);
                PopulateSinistreFields(sinis);
                //LoadImages();
                //LoadRapport();
                //LoadImagesApresReparation();
                //LoadRapportFinaux();
            }
            else
            {
                Response.Redirect("ListeSinistre.aspx");
            }
            //populateSinistreFields();
            Javascript.ConsoleLog(sinistreId.ToString());
        
        
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

    public void Button_RechercheSinistre_Click(object sender, EventArgs e)
    {
        int Id;
        if(Int32.TryParse(TextBox1_Sinistre.Text,out Id))
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
            }
        }
    }

}