<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master" AutoEventWireup="true" CodeBehind="CreerSinistre.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.CreerSinistre" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <!-- Navigation Bar -->
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Création Sinistre</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a> </li>
                        <li><a href="#">Créer Sinistre</a></li>
                    </ol>
                </div>
            </div>

            <!-- Main Menu -->
            <div class="container">



                <hr />

                <!-- Tabs navigation Bar -->
                <ul class="nav nav-tabs">

                    <li class="active"><a data-toggle="tab" href="#menu1">Contrat</a></li>
                    <li><a data-toggle="tab" href="#menu2">Souscripteur</a></li>
                    <li><a data-toggle="tab" href="#menu3">Assuré</a></li>
                    <li><a data-toggle="tab" href="#menu4">Véhicule</a></li>
                    <li><a data-toggle="tab" href="#menu5">Garanties</a></li>
                    <li><a data-toggle="tab" href="#menu6">Sinistre</a></li>

                </ul>

                <!-- Tab content -->
                <div class="tab-content" style="background-color: white">

                    <!--  Menu Contrat -->
                    <div id="menu1" class="tab-pane fade in active">
                        <br />
                        <div class="row">
                            <div class="col-md-5 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Compagnie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CCompagnie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Contrat:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CContrat" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Souscripteur:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_ListeSouscripteur" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date de souscription:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CDateSouscription" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Périodicité:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CPeriode" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prime annuelle:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CPrime" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prime comptant:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CPrimeComptant" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-5 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Agence:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CAgence" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Catégorie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CCategorie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Assuré:</label>
                                    <div class="col-sm-6">

                                        <asp:DropDownList ID="DropDownList_ListAssures" class="form-control" runat="server">
                                        </asp:DropDownList>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date effet:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CDateEffet" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Fractionnement:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="dropDownListFractionnement" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="12">Mensuel</asp:ListItem>
                                            <asp:ListItem Value="4">Trimestriel</asp:ListItem>
                                            <asp:ListItem Value="2">Semestriel</asp:ListItem>
                                            <asp:ListItem Value="1" Selected="True">Annuel</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date écheance:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CDateEchenace" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Vehicule:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_ListeVehicules" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="Button_EnregistrerContrat" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerContrat_Click" Text="Enregistrer" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>

                    <!-- Menu souscripteur -->
                    <div id="menu2" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <asp:RadioButtonList ID="Radio_TypeSouscripteur" runat="server" RepeatDirection="Horizontal" Width="300px">
                                    <asp:ListItem id="option1" runat="server" Value="Physique" Text="Personne Physique" />
                                    <asp:ListItem id="option2" runat="server" Value="Morale" Text="Personne Morale" />
                                </asp:RadioButtonList>
                            </div>
                            <br />
                        </div>
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_SouscripteurNom" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type identifiant:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_TypeId" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Raison sociale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_RaisonSociale" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date création:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_DateCreation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Numéro:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Numero" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Forme juridique:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_FormeJuridrique" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Activité:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Activite" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Delivre" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-7">
                                <fieldset>
                                    <legend>Coordonnés</legend>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Adresse</th>
                                                <th>Ville</th>
                                                <th>Code Postal</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox_Adresse_Souscripteur" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_VilleSouscripteur" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_CodePostal" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td>
                                                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_CodePostal" ErrorMessage="Number required" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </fieldset>

                            </div>
                            <div class="col-md-5">
                                <fieldset>
                                    <legend>Contact</legend>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Communication</th>
                                                <th>Valeur</th>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Telephone</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_SouscripteurTelephone" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_SouscripteurMobile" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>Fax</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_SouscripteurFax" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>E-Mail</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_SouscripteurEmail" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>

                                        </tbody>
                                    </table>
                                </fieldset>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">

                            <div class="col-sm-6">
                                <asp:Button ID="Button_EnregistrerSouscripteur" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerSouscripteur_Click" Text="Enregistrer" />
                            </div>
                        </div>

                    </div>
                    <!-- Menu Assuré -->
                    <div id="menu3" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <asp:RadioButtonList ID="Radio_TypeAssure" runat="server" RepeatDirection="Horizontal" Width="300px">
                                    <asp:ListItem id="Listitem1" runat="server" Value="Physique" Text="Personne Physique" />
                                    <asp:ListItem id="Listitem2" runat="server" Value="Morale" Text="Personne Morale" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type identifiant:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_TypeIdentifiant" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_NomAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date de naissance:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_DateNaissance" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Situation familiale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_SituationFamiliale" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Permis:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_NumPermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Numéro:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_Numero" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prenom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_Prenom" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Lieu Naissance:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_LieuNaissance" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Profession:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_Profession" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Sexe:</label>
                                    <div class="col-sm-6">

                                        <asp:DropDownList ID="DropDownList_SexAssure" class="form-control" runat="server">
                                            <asp:ListItem Value="Male" Selected="True">
                                                 Male
                                            </asp:ListItem>
                                            <asp:ListItem Value="Femele">
                                                 Femele
                                            </asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_DatePermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>


                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_A_DelivreeLe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-7">
                                <fieldset>
                                    <legend>Coordonnés</legend>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Adresse</th>
                                                <th>Ville</th>
                                                <th>Code Postal</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox_AddresseAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_VilleAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_CodePostalAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td>
                                                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_CodePostalAssure" ErrorMessage="Number required" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </fieldset>

                            </div>
                            <div class="col-md-5">
                                <fieldset>
                                    <legend>Contact</legend>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Communication</th>
                                                <th>Valeur</th>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Telephone</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_TelephoneAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_MobileAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>Fax</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_FaxAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td>E-Mail</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox_MailAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                                </td>

                                            </tr>

                                        </tbody>
                                    </table>
                                </fieldset>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <div class="col-sm-6">
                                        <asp:Button ID="Button_EnregistrerAssure" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerAssure_Click" Text="Enregistrer" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />

                    </div>


                    <!-- Menu vehicule -->
                    <div id="menu4" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Immatriculation:</label>
                                    <div class="col-sm-6">

                                        <asp:TextBox ID="TextBox_Immatriculation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Constructeur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Constructeur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type const:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_TypeConstructeur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Carroserie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Carroserie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <br />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Energie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Energie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <br />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Poid vide:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Poidvide" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_PoidVide" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Remorque:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Remorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_Remorque" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_TypeRemorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Avec délégation:</label>
                                    <div class="col-sm-6">
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Oui</label>
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Non</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Valeur à neuf:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_ValeuràNeuf" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_ValeuràNeuf" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Classe:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Classe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Genre:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Genre" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Marque:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Marque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Série:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_NumSerie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nombre Place:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_NbPlace" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_NbPlace" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Puissance fiscale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Puissane" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_Puissane" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Charge Utile:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_ChargeUtile" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_ChargeUtile" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Poid vide:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_PoidVideRemorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_PoidVideRemorque" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Organisme:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Organisme" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <br />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Valeur vénale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Valeurvénal" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_Valeurvénal" ErrorMessage="Number required" />
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Compagnie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Compagnie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Usage:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Usage" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Couleur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Couleur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">D.P.M.C:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_DPMC" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nombre debout:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_NbrDebout" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_NbrDebout" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Cylindrée:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Cylindree" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_Cylindree" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">PTAC/PTRA:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_PTAC" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_PTAC" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Charge Utile:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_ChargeUtileRemorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_ChargeUtileRemorque" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Durée:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Duree" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_Duree" ErrorMessage="Number required" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date relevé:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_DateReleve" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">

                                    <div class="col-sm-6">
                                        <br />
                                        <br />
                                        <asp:Button ID="Button_EnregistrerVehicule" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerVehicule_Click" Text="Enregistrer" />
                                    </div>
                                </div>
                            </div>





                        </div>
                        <br />
                    </div>

                    <!-- Menu garantie -->
                    <div id="menu5" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col">
                            </div>
                            <div class="col-6 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Contrat:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_ListeContrat" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garantie:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_ListeGarantie" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Capital:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Capital" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Franchise:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Franchise" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>


                            <div class="col">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="Button_AjouterGarantie" runat="server" CssClass="btn btn-info" OnClick="Button_AjouterGarantie_Click" Text="Enregistrer" />
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>


                    <!-- Menu Sinistre -->
                    <div id="menu6" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Experts:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_SinistreListeExpert" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Immatriculation:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_Immatriculation" class="form-control" runat="server">
                                        </asp:DropDownList>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Conducteur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_Conducteur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nature:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_Nature" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Indemnisé:</label>
                                    <div class="col-sm-6">
                                        <asp:RadioButtonList ID="RadioButtonList_Indemnite" runat="server" RepeatDirection="Horizontal" Width="300px">
                                            <asp:ListItem id="Listitem3" runat="server" Value="1" Text="Oui" selected="true"/>
                                            <asp:ListItem id="Listitem4" runat="server" Value="0" Text="Non" />
                                        </asp:RadioButtonList>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">IDA:</label>
                                    <div class="col-sm-6">
                                        <asp:RadioButtonList ID="RadioButtonList_IDA" runat="server" RepeatDirection="Horizontal" Width="300px">
                                            <asp:ListItem id="Listitem5" runat="server" Value="1" Text="Oui" selected="true"/>
                                            <asp:ListItem id="Listitem6" runat="server" Value="0" Text="Non" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>


                            </div>

                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garage:</label>
                                    <div class="col-sm-6">
                                         <asp:RadioButtonList ID="RadioButtonList_Garage" runat="server" RepeatDirection="Horizontal" Width="300px">
                                            <asp:ListItem id="Listitem7" runat="server" Value="1" Text="Oui" selected="true"/>
                                            <asp:ListItem id="Listitem8" runat="server" Value="0" Text="Non" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garantie sinistré:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_SinistreGarantieSinistre" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Permis:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_NumPermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Part de responsabilite:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_PartResp" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Montant indemnisation:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_MontantInd" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Compagnie adverse:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_CompagnieAdv" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>


                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garagiste:</label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="DropDownList_SinistreGaragiste" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date Sinistre:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_DateSinistre" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date Permis:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_DatePermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date indemnisation:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_DateIndm" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Vehicule adverse :</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_VehiculeAdverse" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="Button_EnregistrerSinistre" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerSinistre_Click" Text="Enregistrer" />
                                    </div>
                                </div>

                            </div>
                        </div>
                        <br />
                    </div>



                </div>
            </div>


        </section>
    </section>


</asp:Content>
