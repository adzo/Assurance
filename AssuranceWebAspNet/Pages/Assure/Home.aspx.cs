using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssuranceWebAspNet.Pages.Assure
{
    public partial class Home : System.Web.UI.Page
    {
        UserDbContext usr = new UserDbContext();
        UserAccount user = new UserAccount();
        //private EventArgs GlobalE;
        //private object Globalsender;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assure/Home";
            //Globalsender = sender;
            //GlobalE = e;
            int userId = Int32.Parse(Session["userId"].ToString());
            user = usr.Users.FirstOrDefault(u => u.UserId == userId);
            loadReclamations();
        }

        protected void button_AjoutReclamation_Click(object sender, EventArgs e)
        {
            //Ajout de la reclamation
            Reclamation R = new Reclamation()
            {
                Titre = TextBox_TitreReclamation.Text,
                Description = TextBoxDescription.Text,
                status = false,
                Assure = usr.Assures.Find(1),
                Date = DateTime.Now.ToString("dd/MM/yyyy")
            };

            R.Assure = usr.Assures.FirstOrDefault(u => u.AssureId == user.UserId);
            usr.Reclamations.Add(R);
            usr.SaveChanges();
            Page_Load(sender, e);
        }

        public void loadReclamations()
        {
            
            List <Reclamation> liste = usr.Assures.FirstOrDefault(u => u.AssureId == user.UserId).Reclamations.OrderByDescending(u=>u.Id).ToList();
            if (liste != null)
            {
                TableRow th, tr;
                TableHeaderCell HNum, HDate, HTitre, HDesc, HStat, HAct;
                TableCell Num, Date, Titre, Desc, Stat, Act;
                TableReclamations.Rows.Clear();
                HNum = new TableHeaderCell() { Text = "N°" };
                HDate = new TableHeaderCell() { Text = "Date" };
                HTitre = new TableHeaderCell() { Text = "Titre" };
                HDesc = new TableHeaderCell() { Text = "Description" };
                HStat = new TableHeaderCell() { Text = "Status" };
                HAct = new TableHeaderCell() { Text = "Action" };
                th = new TableHeaderRow()
                {
                    Cells =
                    {
                        HNum,HDate,HTitre,HDesc,HStat,HAct
                    }
                };
                TableReclamations.Rows.Add(th);
                int i = 1;
                foreach (Reclamation rec in liste)
                {
                    Num = new TableCell() { Text = i.ToString() };
                    i++;
                    Date = new TableCell() { Text = rec.Date };
                    Titre = new TableCell() { Text = rec.Titre };
                    Desc = new TableCell() { Text = rec.Description };
                    Stat = new TableCell();
                    if (rec.status) { Stat.Text = "Traitée"; } else { Stat.Text = "Non traitée encore"; }

                    LinkButton delLink = new LinkButton();
                    delLink.Text = "Supprimer";
                    delLink.ID = "del" + rec.Id;
                    delLink.Click += new EventHandler(DeleteReclamation);


                    Act = new TableCell();
                    Act.Controls.Add(delLink);

                    tr = new TableRow()
                    {
                        Cells =
                        {
                            Num,Date,Titre,Desc,Stat,Act
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
            int reclId = Int32.Parse( source.ID.Remove(0, 3));
            Reclamation reclam = usr.Reclamations.Find(reclId);
            usr.Reclamations.Remove(reclam);
            usr.SaveChanges();
            Page_Load(sender, e);
        }
    }
}