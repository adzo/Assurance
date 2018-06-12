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
    public partial class Garages : System.Web.UI.Page
    {
        UserAccount user = new UserAccount();
        UserDbContext u = new UserDbContext();
        LinkButton UpdateUserlink;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["target"] = "/Pages/Assurance/Garages";
            loadUsers();
        }

        public void loadUsers()
        {
            List<UserAccount> liste = u.Users.Where(u => u.Role == "Garage").ToList();
            TableRow th, tr;
            TableHeaderCell HId, HFirstName, HLastName, HEmail, HPhoneNumber, HPassword, HUpdate;
            TableCell IdCell, FirstName, LastName, Email, PhoneNumber, Password, UpdateCell;
            TableGarages.Rows.Clear();
            HId = new TableHeaderCell() { Text = "Id" };
            HFirstName = new TableHeaderCell() { Text = "Prenom" };
            HLastName = new TableHeaderCell() { Text = "Nom" };
            HEmail = new TableHeaderCell() { Text = "Email" };
            HPhoneNumber = new TableHeaderCell() { Text = "Téléphone" };
            HPassword = new TableHeaderCell() { Text = "Mot de Passe" };
            HUpdate = new TableHeaderCell() { Text = "Modifier" };
            th = new TableHeaderRow()
            {
                Cells =
                {
                    HId, HFirstName, HLastName, HEmail, HPhoneNumber,HUpdate, HPassword
                }
            };
            TableGarages.Rows.Add(th);
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
                    UpdateCell = new TableCell();

                    UpdateUserlink = new LinkButton
                    {
                        Text = "Modifier",
                        ID = "updateLink" + us.UserId
                    };
                    UpdateUserlink.Click += new EventHandler(popupUpdatePanel);
                    UpdateCell.Controls.Add(UpdateUserlink);

                    LinkButton ViewPass = new LinkButton
                    {
                        Text = "View",
                        ID = "View" + us.UserId
                    };
                    ViewPass.Click += new EventHandler(ViewPassword);
                    Password.Controls.Add(ViewPass);

                    tr = new TableRow()
                    {
                        Cells =
                        {
                            IdCell, FirstName, LastName, Email, PhoneNumber,UpdateCell, Password
                        }
                    };
                    TableGarages.Rows.Add(tr);
                }
            }
        }
        public void button_ModifierExpert_Click(object sender, EventArgs e)
        {

            int idUserFound = Int32.Parse(TextBox_UserIdUpdate.Text);
            user = u.Users.Find(idUserFound);
            user.ConfirmPassword = user.Password;
            user.FirstName = TextBox_FirstNameUpdate.Text;
            user.LastName = TextBox_LastNameUpdate.Text;
            user.Email = TextBox_MailUpdate.Text;
            int i = 0;
            Int32.TryParse(TextBox_PhoneNumberUpdate.Text, out i);
            user.PhoneNumber = i;

            u.SaveChanges();
            Page_Load(sender, e);
        }
        public void popupUpdatePanel(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            int idUserFound = Int32.Parse(source.ID.Remove(0, 10));
            user = u.Users.Find(idUserFound);
            TextBox_FirstNameUpdate.Text = user.FirstName;
            TextBox_LastNameUpdate.Text = user.LastName;
            TextBox_MailUpdate.Text = user.Email;
            TextBox_PhoneNumberUpdate.Text = user.PhoneNumber.ToString();
            TextBox_UserIdUpdate.Text = user.UserId.ToString();
            popupUpdate.Show();
        }
        public void ViewPassword(object sender, EventArgs e)
        {
            LinkButton source = (LinkButton)sender;
            int userId = Int32.Parse(source.ID.Remove(0, 4));
            UserAccount FoundUser = u.Users.Find(userId);
            Response.Write("<script>alert('" + FoundUser.Password + "');</script>");
        }
        public void button_AjoutGarage_Click(object sender, EventArgs e)
        {
            user.FirstName = TextBox_FirstName.Text;
            user.LastName = TextBox_LastName.Text;
            user.Email = TextBox_Mail.Text;
            int i = 0;
            Int32.TryParse(TextBox_PhoneNumber.Text, out i);
            user.PhoneNumber = i;
            user.Role = "Garage";
            user.Password = "1234";
            user.ConfirmPassword = "1234";
            u.Users.Add(user);
            u.SaveChanges();
            Page_Load(sender, e);
        }

    }
}