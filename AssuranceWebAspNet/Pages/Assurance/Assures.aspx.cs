using AssuranceWebAspNet.Utilities;
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
    public partial class Assures : System.Web.UI.Page
    {
        UserDbContext u = new UserDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assurance/Assures";
            loadUsers();
        }

        public void loadUsers()
        {
            List<UserAccount> liste = u.Users.Where(u => u.Role == "Assure").ToList();
            TableRow th, tr;
            TableHeaderCell HId, HFirstName, HLastName, HEmail, HPhoneNumber, HPassword;
            TableCell IdCell, FirstName, LastName, Email, PhoneNumber, Password;
            HId = new TableHeaderCell() { Text = "Id" };
            HFirstName = new TableHeaderCell() { Text = "Prenom" };
            HLastName = new TableHeaderCell() { Text = "Nom" };
            HEmail = new TableHeaderCell() { Text = "Email" };
            HPhoneNumber = new TableHeaderCell() { Text = "Téléphone" };
            HPassword = new TableHeaderCell() { Text = "Mot de Passe" };
            th = new TableHeaderRow()
            {
                Cells =
                {
                    HId, HFirstName, HLastName, HEmail, HPhoneNumber, HPassword
                }
            };
            TableAssures.Rows.Add(th);
            if (liste != null)
            {
                foreach (UserAccount us in liste)
                {
                    IdCell = new TableCell() { Text = us.UserId.ToString() };
                    FirstName = new TableCell() { Text = us.FirstName };
                    LastName = new TableCell() { Text = us.LastName };
                    Email = new TableCell() { Text = us.Email };
                    PhoneNumber = new TableCell() { Text = us.PhoneNumber.ToString() };
                    Password = new TableCell();
                    LinkButton ViewPass = new LinkButton();
                    ViewPass.Text = "View";
                    ViewPass.ID = "View" + us.UserId;
                    ViewPass.Click += new EventHandler(ViewPassword);
                    Password.Controls.Add(ViewPass);
                    tr = new TableRow()
                    {
                        Cells =
                        {
                            IdCell, FirstName, LastName, Email, PhoneNumber, Password
                        }
                    };
                    TableAssures.Rows.Add(tr);
                }
            }
        }
        public void ViewPassword(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            int userId = Int32.Parse(source.ID.Remove(0, 4));
            UserAccount FoundUser = u.Users.Find(userId);
            Response.Write("<script>alert('" + FoundUser.Password + "');</script>");
        }
        public void Button_EnregistrerAssure_Click(object sender, EventArgs e)
        {


            Exam.Domain.Entities.Assure a = new Exam.Domain.Entities.Assure();
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
            C.Email = TextBox_MailAssure.Text;
            i = 0;
            a.Addresse = A;
            a.Contact = C;

            UserAccount assu = new UserAccount()
            {
                Email = a.Contact.Email,
                FirstName = a.Prenom,
                LastName = a.Nom,
                PhoneNumber = (int)a.Contact.Mobile,
                Role = "Assure",
                Password = "1234",
                ConfirmPassword = "1234"
            };
            u.Users.Add(assu);
            u.SaveChanges();
            a.UserAccount = assu;
            u.Assures.Add(a);
            u.SaveChanges();
            Javascript.ConsoleLog("clicked Assuré add");

        }

    }
}