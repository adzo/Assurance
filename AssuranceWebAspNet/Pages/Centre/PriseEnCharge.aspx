﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterCentre.Master" AutoEventWireup="true" CodeBehind="PriseEnCharge.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Centre.PriseEnCharge" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Prise en charge</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                        <li><a href="PriseCharge.aspx">Prise en charge</a></li>


                    </ol>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="form-inline">
                        <div class="form-horizontal form-group">

                            <asp:TextBox ID="_TxtNumSinistre" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>


                        </div>
                        <div class="form-horizontal form-group">

                            <asp:TextBox ID="_TxtNumContrat" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de contrat"></asp:TextBox>

                        </div>
                        <asp:Button ID="btnChercher" CssClass="btn btn-info" runat="server" Text="Recherche" />
                    </div>
                </div>
                <div class="row" visible="false" id="res" runat="server">
                    Pas de données
                </div>
                <hr />

                <ul class="nav nav-tabs">

                    <li class="active"><a data-toggle="tab" href="#menu1">Contrat</a></li>
                    <li><a data-toggle="tab" href="#menu2">Souscripteur</a></li>
                    <li><a data-toggle="tab" href="#menu3">Assuré</a></li>
                    <li><a data-toggle="tab" href="#menu4">Véhicule</a></li>
                    <li><a data-toggle="tab" href="#menu5">Garanties</a></li>
                    <li><a data-toggle="tab" href="#menu6">Sinistre</a></li>

                </ul>


                <div class="tab-content" style="background-color: white">
                    <!-- Menu COntrat -->
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
                                       <asp:TextBox ID="_CSouscripteur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date de souscription:</label>
                                    <div class="col-sm-6">
                                       <asp:TextBox ID="_CDateSous" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                       <asp:TextBox ID="_CAssure" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                        <asp:TextBox ID="_CFractionnement2" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>

                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date écheance:</label>
                                    <div class="col-sm-6">
                                   <asp:TextBox ID="_CDateEchenace" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prime comptant:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_CPrimeComptant" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                    


                    <!-- Menu Souscripteur -->
                    <div id="menu2" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <label class="radio-inline">
                                    <asp:RadioButton ID="_pp" Text="Personne physique" GroupName="TypeSouscripteur" runat="server" />

                                </label>
                                <label class="radio-inline">

                                    <asp:RadioButton ID="_pm" Text="Personne morale" GroupName="TypeSouscripteur" runat="server" />
                                </label>


                            </div>


                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type identifiant:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_TypeId" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Raison sociale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_RaisonSoc" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date création:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_DateCreation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Numéro:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Numero" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Forme juridique:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_FormeJuridrique" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Activité:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Activite" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_DelivreLe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                                    <asp:Label ID="LabelSouscripteurAddresse" runat="server" Text="Label"></asp:Label></td>
                                                <td><asp:Label ID="LabelSouscripteurVille" runat="server" Text="Label"></asp:Label></td></td>
                                                <td><asp:Label ID="LabelSouscripteurCode" runat="server" Text="Label"></asp:Label></td></td>
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
                                                <td>Téléphone</td>
                                                <td><asp:Label ID="LabelSouscripteurTelephone" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td><asp:Label ID="LabelSouscripteurMobile" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>Fax</td>
                                                <td><asp:Label ID="LabelSouscripteurFax" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>E-Mail</td>
                                                <td><asp:Label ID="LabelSouscripteurMail" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                        </tbody>
                                    </table>
                                </fieldset>
                            </div>
                        </div>
                        <br />
                    </div>

                    <!-- Menu Assuré -->
                    <div id="menu3" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton1" Text="Personne physique" GroupName="TypeSouscripteur" runat="server" />

                                </label>
                                <label class="radio-inline">

                                    <asp:RadioButton ID="RadioButton2" Text="Personne morale" GroupName="TypeSouscripteur" runat="server" />
                                </label>


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
                                    <label class="control-label col-sm-4" for="email">Date naissance:</label>
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
                                        <asp:TextBox ID="_A_Sexe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                                    <asp:Label ID="LabelAssureAdresse" runat="server" Text="Label"></asp:Label></td>
                                                <td><asp:Label ID="LabelAssureVille" runat="server" Text="Label"></asp:Label></td></td>
                                                <td><asp:Label ID="LabelAssureCodePostal" runat="server" Text="Label"></asp:Label></td></td>
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
                                                <td>Téléphone</td>
                                                <td><asp:Label ID="LabelAssureTelephone" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td><asp:Label ID="LabelAssureMobile" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>Fax</td>
                                                <td><asp:Label ID="LabelAssureFax" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td>E-Mail</td>
                                                <td><asp:Label ID="LabelAssureMail" runat="server" Text="Label"></asp:Label></td>

                                            </tr>
                                        </tbody>
                                    </table>
                                </fieldset>
                            </div>
                        </div>
                        <br />
                    </div>


                    <!-- Menu Vehicule -->
                    <div id="menu4" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Immatriculation:</label>
                                    <div class="col-sm-6">

                                        <asp:TextBox ID="_Immatriculation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Constructeur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Constructeur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type constructeur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_TypeConstructeur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Carroserie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Carroserie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Energie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Energie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Poid vide:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Poidvide" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Remorque:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Remorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Type:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_TypeRemorque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                        <asp:TextBox ID="_ValeuràNeuf" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Classe:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Classe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Genre:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Genre" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Marque:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Marque" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Série:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_NumSerie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nombre Place:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_NbPlace" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Puissance fiscale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Puissane" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Charge Utile:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_ChargeUtile" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Poid vide:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_PoidVd" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Organisme:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Organisme" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Valeur vénale:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Valeurvénal" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Contrat:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Contrat" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Compagnie:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Compagnie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Usage:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Usage" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Couleur:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Couleur" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">D.P.M.C:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_DPMC" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nombre debout:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_NbrDebout" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Cylindrée:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Cylindree" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">PTAC/PTRA:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_PTAC" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Charge Utile:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_ChargeUtil" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Durée:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_Duree" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date relevé:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_DateReleve" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <br />
                    </div>

                    <!-- Menu Garanties -->
                    <div id="menu5" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-7">
                                <fieldset>
                                    <legend>Garanties</legend>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>N°</th>
                                                <th>Garantie</th>
                                                <th>Capital</th>
                                                <th>Franchise</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>Responsabilité Civile</td>
                                                <td><asp:Label ID="LabelCapital1" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise1" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>2</td>
                                                <td>Défenses et Recours</td>
                                                <td><asp:Label ID="LabelCapital2" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise2" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>3</td>
                                                <td>Vol</td>
                                                <td><asp:Label ID="LabelCapital3" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise3" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>4</td>
                                                <td>Incendie</td>
                                                <td><asp:Label ID="LabelCapital4" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise4" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>5</td>
                                                <td>Personnes Transportées</td>
                                                <td><asp:Label ID="LabelCapital5" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise5" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>6</td>
                                                <td>Dommages aux Véhicules</td>
                                                <td><asp:Label ID="LabelCapital6" runat="server" Text=""></asp:Label></td>
                                                <td><asp:Label ID="LabelFrancise6" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </fieldset>

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

                                        <asp:TextBox ID="_S_Experts" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Immatriculation:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_Immatriculation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Oui</label>
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Non</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">IDA:</label>
                                    <div class="col-sm-6">
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Oui</label>
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Non</label>
                                    </div>
                                </div>



                            </div>

                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garage:</label>
                                    <div class="col-sm-6">
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Oui</label>
                                        <label class="radio-inline">
                                            <input type="radio" name="optradio">Non</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garantie sinistré:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_Garantie" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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


                            </div>
                        </div>
                        <br />
                    </div>
                </div>

            </div>


        </section>
    </section>
</asp:Content>
