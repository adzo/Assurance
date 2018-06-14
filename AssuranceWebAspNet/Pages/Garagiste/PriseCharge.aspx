<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterGaragiste.Master" AutoEventWireup="true" Inherits="GaragistePriseCharge" CodeBehind="PriseCharge.aspx.cs" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .modalBackground {
            background-color: gray;
            opacity: 0.7;
            z-index: 20;
        }

        .modalpopup {
            padding: 20px 0px 24px 10px;
            position: relative;
            
            background-color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="main-content">
        <section class="wrapper">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Prise en charge</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                        <li><a href="listeSinistre.aspx">Liste Sinistre</a></li>
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
                        <asp:Button ID="Button_RechercheSinistre" CssClass="btn btn-info" runat="server" OnClick="Button_RechercheSinistre_Click" Text="Recherche" />
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
                                <h5>Conducteur:
                                    <asp:Label ID="LabelConducteur" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>Immatriculation:
                                    <asp:Label ID="LabelMatricule" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>Nature:
                                    <asp:Label ID="LabelNature" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>IDA:<asp:Label ID="LabelIDA" runat="server" Text="Label"></asp:Label></h5>
                                <h5>Expert:
                                    <asp:Label ID="LabelExpert" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>

                            </div>
                            <div class="col-md-4">
                                <h5>Garantie sinistré:
                                    <asp:Label ID="LabelGarantie" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>Num permis:
                                    <asp:Label ID="LabelNumPermis" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>Part de respnnsabilité:<asp:Label ID="LabelResponsabilite" runat="server" Text="Label"></asp:Label></asp:RadioButtonList></h5>
                                <h5>Companie d'assurance:
                                    <asp:Label ID="LabelCompagnie" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>

                            </div>
                            <div class="col-md-4">
                                <h5>Date de sinistre:
                                    <asp:Label ID="LabelDateSinistre" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>date permis:
                                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>
                                <h5>Compagnie Adverse
                                    <br />
                                    <asp:Label ID="LabelCompagnieAdverse" runat="server" Text="Label"></asp:Label>
                                </h5>
                                <h5>Vehicule Adverse:
                                    <asp:Label ID="LabelVehiculeAdverse" runat="server" Text="Label"></asp:Label>
                                    <br />
                                </h5>

                            </div>
                        </div>
                    </div>

                    <!-- Menu Devis -->
                    <div id="menu2" class="tab-pane">
                        <br />
                        <fieldset>
                            <legend>Devis</legend>

                            <div class="row">
                                <div class="col-md-1">
                                    <h2 hidden="hidden">test</h2>
                                </div>
                                <div class="col-md-10">
                                    <asp:Table ID="TableDevis" runat="server"></asp:Table>
                                </div>
                            </div>



                            <asp:FileUpload ID="FileUpload_Devis" runat="server" />
                            <asp:Button ID="ButtonUploadDevis" runat="server" OnClick="ButtonUploadDevis_Click" Text="sauvegarder" />
                            <br />





                            
                        </fieldset>
                    </div>

                    <!-- Menu Factures -->
                    <div id="menu3" class="tab-pane">
                        <br />
                        <div class="row">
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Photo apres réparation</legend>
                                    <asp:FileUpload ID="FileUpload_PhotoAfterReparation" runat="server" /><asp:Button ID="Button_UploadPhotoAfterReparation" runat="server" OnClick="Button_UploadPhotoAfterReparation_Click" Text="Envoyer" />
                                    <asp:Table ID="Table_PhotoApresReparation" runat="server"></asp:Table>
                                </fieldset>
                            </div>
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Factures</legend>
                                    <asp:FileUpload ID="FileUpload_Factures" runat="server" /><asp:Button ID="Button_UploadFactures" runat="server" OnClick="Button_UploadFactures_Click" Text="Envoyer" />
                                    <asp:Table ID="favt_table" runat="server"></asp:Table>
                                </fieldset>
                            </div>
                        </div>
                    </div>

                    <!-- Menu Bon de sortie -->
                    <div id="menu4" class="tab-pane">
                        <br />
                         <br />

                        <div class="row">
                            <div class="col-md-2">
                                <h1 hidden="hidden">Test</h1>
                            </div>

                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Bon de sortie :</legend>
                                </fieldset>
                            </div>
                            
                        </div>
                        <div class="row" runat="server" id="divUploadBonDeSortie">
                            <div class="col-md-2">
                                <h1 hidden="hidden">Test</h1>
                            </div>

                            <div class="col-md-8">
                                <asp:FileUpload ID="FileUploadBonDeSortie" runat="server" />
                                <asp:Button ID="ButtonAjouterBonDeSortie" CssClass="btn btn-info" runat="server" Text="Ajouter" OnClick="ButtonAjouterBonDeSortie_Click" />
                            
                            </div>
                           
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                                <h1 hidden="hidden">Test</h1>
                            </div>

                            <div class="col-md-8">
                                <fieldset>
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>N° </th>
                                                <th>Date</th>
                                                <th>B.S. non signé</th>
                                                <th>B.S. Signé</th>
                                                <th>Supprimer</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="LabelBonDeSortieNumero" runat="server" Text=""></asp:Label></td>
                                                <td>
                                                    <asp:Label ID="LabelBonDeSortieDate" runat="server" Text=""></asp:Label></td>
                                                <td>
                                                    <asp:LinkButton ID="ViewNonSigne" runat="server"></asp:LinkButton></td>
                                                <td>
                                                    <asp:LinkButton ID="ViewSigne" runat="server"></asp:LinkButton></td>
                                                <td>
                                                    <asp:LinkButton ID="DeleteBonSortie" runat="server"></asp:LinkButton></td>

                                            </tr>
                                        </tbody>
                                    </table>

                                </fieldset>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <asp:Panel ID="PanelImageAvantReparation" runat="server" CssClass="modalpopup">
                <div class="container">
                    <div class="row">
                        <asp:Image ID="ImageAvantReparationPreview" runat="server" AlternateText="Image text" ImageAlign="left" ImageUrl="images/image1.jpg" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Msg" runat="server" Text="Msg"></asp:Label>
                        <asp:Button ID="button_CancelImageView" runat="server" Text="Close" />
                    </div>
                </div>
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="modalBackground" CancelControlID="button_CancelImageView" PopupControlID="PanelImageAvantReparation" TargetControlID="Button_PreviewImage"></ajaxToolkit:ModalPopupExtender>


            <div class="form-group" hidden="hidden">

                <div class="col-sm-4">
                    <asp:Button ID="Button_PreviewImage" runat="server" CssClass="btn btn-info" Text="Preview" />
                </div>

            </div>


        </section>
    </section>


</asp:Content>
