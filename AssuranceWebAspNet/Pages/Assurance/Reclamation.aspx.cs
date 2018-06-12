using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assurance
{
    public partial class ReclamationView : System.Web.UI.Page
    {
        UserDbContext usr = new UserDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assurance/Reclamations";
            loadReclamations();
        }

        public void loadReclamations()
        {

            List<Reclamation> liste = usr.Reclamations.OrderByDescending(u => u.Id).ToList();
            if (liste != null)
            {
                TableRow th, tr;
                TableHeaderCell HNum,HProp, HDate, HTitre, HDesc, HStat,Hdet, HAct;
                TableCell Num,Prop, Date, Titre, Desc, Stat,det, Act;
                TableReclamations.Rows.Clear();
                HNum = new TableHeaderCell() { Text = "N°" };
                HProp = new TableHeaderCell() { Text = "Assuré" };
                HDate = new TableHeaderCell() { Text = "Date" };
                HTitre = new TableHeaderCell() { Text = "Titre" };
                HDesc = new TableHeaderCell() { Text = "Description" };
                HStat = new TableHeaderCell() { Text = "Status" };
                Hdet = new TableHeaderCell() { Text = "Détail" };
                HAct = new TableHeaderCell() { Text = "Supprimer" };
                th = new TableHeaderRow()
                {
                    Cells =
                    {
                        HNum,HProp,HDate,HTitre,HStat,Hdet,HAct
                    }
                };
                TableReclamations.Rows.Add(th);
                int i = 1;
                foreach (Reclamation rec in liste)
                {
                    Num = new TableCell() { Text = i.ToString() };
                    Prop = new TableCell() { Text = rec.Assure.Prenom+", "+rec.Assure.Nom };
                    i++;
                    Date = new TableCell() { Text = rec.Date };
                    Titre = new TableCell() { Text = rec.Titre };
                    Desc = new TableCell() { Text = rec.Description };
                    Stat = new TableCell();
                    if (rec.status) { Stat.Text = "Traitée"; } else { Stat.Text = "Non traitée encore"; }

                    LinkButton delLink = new LinkButton();
                    LinkButton ViewLink = new LinkButton();
                    ViewLink.Text = "Detail";
                    ViewLink.ID = "detail" + rec.Id;
                    ViewLink.Click += new EventHandler(DetailReclamation);

                    delLink.Text = "Supprimer";
                    delLink.ID = "del" + rec.Id;
                    delLink.Click += new EventHandler(DeleteReclamation);

                    det = new TableCell();
                    Act = new TableCell();
                    det.Controls.Add(ViewLink);
                    Act.Controls.Add(delLink);


                    tr = new TableRow()
                    {
                        Cells =
                        {
                            Num,Prop,Date,Titre,Stat,det,Act
                        }
                    };
                    TableReclamations.Rows.Add(tr);
                }
                //Page_Load( Globalsender ,  GlobalE);

            }
            

        }
        public void DeleteReclamation(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            int reclId = Int32.Parse(source.ID.Remove(0, 3));
            Reclamation reclam = usr.Reclamations.Find(reclId);
            usr.Reclamations.Remove(reclam);
            usr.SaveChanges();
            Page_Load(sender, e);
        }
        public void DetailReclamation(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            int reclId = Int32.Parse(source.ID.Remove(0, 6));
            Reclamation reclam = usr.Reclamations.Find(reclId);
            reclam.status = true;
            
            usr.SaveChanges();
            LabelAssure.Text = reclam.Assure.Prenom + ", " + reclam.Assure.Nom;
            LabelTitre.Text = reclam.Titre;
            LabelDescription.Text = reclam.Description;
            ModalPopupExtender1.Show();
        }
    }
}