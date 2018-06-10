<%@ Page Language="C#"  MasterPageFile="~/MasterPage/MasterGaragiste.Master"  AutoEventWireup="true" Inherits="GaragistePriseCharge" Codebehind="PriseCharge.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                    <asp:TextBox ID="TextBox1_Sinistre" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>
                    </div>                   
                    <asp:Button ID="Button_RechercheSinistre" CssClass="btn btn-info" runat="server"  OnClick="Button_RechercheSinistre_Click"  Text="Recherche" />
                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox1_Sinistre" ErrorMessage="Value must be a whole number" />
                </div>
             </div>
        </div>
          <div class="container">
                          <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#menu1">Sinistre</a></li>
                    <li><a data-toggle="tab" href="#menu2">Devis</a></li>
                    <li><a data-toggle="tab" href="#menu3">Factures</a></li>
                    <li><a data-toggle="tab" href="#menu4">Bon de sortie</a></li>
                </ul>
                <div class="tab-content" style="background-color: white">
                    <!-- Menu Sinistre -->
                    <div id="menu1" class="tab-pane fade in active">
                        <br />
                            <asp:Table ID="SinistreTable" runat="server"></asp:Table>
                        <hr />
                        <div class="row">
                        <div class="col-md-4">
                            <h5>Conducteur: <asp:Label ID="LabelConducteur" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5> Immatriculation: <asp:Label ID="LabelMatricule" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5>Nature: <asp:Label ID="LabelNature" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5> IDA:<asp:Label ID="LabelIDA" runat="server" Text="Label"></asp:Label></h5>
                            <h5>Expert: <asp:Label ID="LabelExpert" runat="server" Text="Label"></asp:Label> <br /></h5>
                                                                                                     
                        </div> 
                        <div class="col-md-4">
                            <h5> Garantie sinistré: <asp:Label ID="LabelGarantie" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5>Num permis: <asp:Label ID="LabelNumPermis" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5> Part de respnnsabilité:<asp:Label ID="LabelResponsabilite" runat="server" Text="Label"></asp:Label></asp:RadioButtonList></h5>
                            <h5>Companie d'assurance: <asp:Label ID="LabelCompagnie" runat="server" Text="Label"></asp:Label> <br /></h5>

                        </div> 
                        <div class="col-md-4">
                            <h5> Date de sinistre: <asp:Label ID="LabelDateSinistre" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5>date permis: <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label> <br /></h5>
                            <h5>Compagnie Adverse <br /><asp:Label ID="LabelCompagnieAdverse" runat="server" Text="Label"></asp:Label> </h5>
                            <h5>Vehicule Adverse: <asp:Label ID="LabelVehiculeAdverse" runat="server" Text="Label"></asp:Label> <br /></h5>

                        </div> 
                        </div> 
                    </div>
                    <div id="menu2" class="tab-pane">
                        <br />
                        <fieldset>
                            <legend>Devis</legend>

                            <asp:FileUpload ID="FileUpload_Devis" runat="server" />
                            <asp:Button ID="ButtonUploadDevis" runat="server" OnClick="ButtonUploadDevis_Click" Text="sauvegarder" />
                            <br />
                            <asp:Table ID="devisTable" runat="server"></asp:Table>
                        </fieldset>
                    </div>
                    <div id="menu3" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Photo apres réparation</legend> 
                                    <asp:FileUpload ID="FileUpload4" runat="server" /><asp:Button ID="Button3" runat="server" Text="sauvegarder" />
                                    <asp:Table ID="rep_table" runat="server"></asp:Table>
                                </fieldset>
                            </div>
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Factures</legend> 
                                    <asp:FileUpload ID="FileUpload3" runat="server" /><asp:Button ID="Button4" runat="server" Text="sauvegarder" />
                                    <asp:Table ID="favt_table" runat="server"></asp:Table>
                                </fieldset>
                            </div>
                        </div>
                    </div>
                    <div id="menu4" class="tab-pane">
                        <br />
                       <fieldset>
                            <legend>Bon de sortie</legend>

                            <asp:FileUpload ID="FileUpload2" runat="server" /><asp:Button ID="Button5" runat="server" Text="sauvegarder" />
                            <br />
                            <asp:Table ID="Table1" runat="server"></asp:Table>
                        </fieldset>
                    </div>
                </div>
          </div>
          <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
      </section>
    </section>
                            <style>
                            .row{
                                margin-left:0px;
                                margin-right:0px;
                            }
                        </style>
</asp:Content>