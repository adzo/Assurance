<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterExpert.Master" AutoEventWireup="true" CodeBehind="PriseEnCharge.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Expert.PriseEnCharge" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
   <style>
    .modalBackground{
	    background-color: gray;
        opacity:0.7;
	    
	    z-index:20;
    }
    .modalpopup{
	    padding:20px 0px 24px 10px;
	    position:relative;
	    width: 80%;
	    
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
                        <li><a href="PriseEnCharge.aspx">Prise en charge</a></li>
                    </ol>
                </div>
            </div>
            <div class="container">
                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#menu1">Sinistre</a></li>
                    <li><a data-toggle="tab" href="#menu2">Rapport d'expertise</a></li>
                    <li><a data-toggle="tab" href="#menu3">Devis</a></li>
                    <li><a data-toggle="tab" href="#menu4">Rapport Final</a></li>
                </ul>
                <div class="tab-content" style="background-color: white">
                    <!-- Menu Sinistre -->
                    <div id="menu1" class="tab-pane fade in active">
                        <br />
                        <div class="row">
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Conducteur :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelConducteur" runat="server" Text="Label"></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Matricule :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelMatricule" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nature :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelNature" runat="server" Text="Label"></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Indemnisation :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelIndemnisation" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">IDA :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelIDA" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Garantie Sinistrée :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelGarantie" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Permis :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelNumPermis" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Part Responsabilité :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelResponsabilite" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Montant :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelMontant" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Compagnie Adverse :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelCompagnieAdverse" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date Sinistre :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelDateSinistre" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date Permis</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelDatePermis" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="Label13" runat="server" Text=""></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Date Indemnisation :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelDateIndemnisation" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Vehicule Adverse :</label>
                                    <div class="col-sm-6">
                                        <asp:Label ID="LabelVehiculeAdverse" runat="server" Text="Label"></asp:Label>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Menu Rapport d'expertise -->
                    <div id="menu2" class="tab-pane fade">
                        <br />
                        <div class="row">
                            <!-- Upload des images avant réparation -->
                            <div class="col-md-6 form-horizontal" style="border-right:1px solid black">

                                
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Photo avant réparation :</label>
                                    
                                    </div>
                                <div class="form-group">
                                    <div class="col-sm-1">
                                        <span></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:FileUpload ID="FileUpload_ImageAvantReparation" runat="server" CssClass="form-control input-sm" />
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button_UploadImage" runat="server" CssClass="btn btn-info" OnClick="Button_UploadImage_Click" Text="Archiver" />
                                    </div>

                                </div>
                                <div class="form-group" hidden="hidden">
                                    
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button_PreviewImage" runat="server" CssClass="btn btn-info"  Text="Preview" />
                                    </div>

                                </div>
                                <br />
                                <asp:Table ID="TableImageAvantReparation" runat="server" Width="90%"> 

                            </asp:Table>
                            </div>
                            <!-- Upload des Rapport -->
                            <div class="col-md-6 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Rapport d'expertise :</label>
                                    
                                    </div>
                                <div class="form-group">
                                    <div class="col-sm-1">
                                        <span></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:FileUpload ID="FileUpload_RapportExpertise" runat="server" CssClass="form-control input-sm" />
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button_UploadRapport" runat="server" CssClass="btn btn-info" OnClick="Button_UploadRapport_Click" Text="Archiver" />
                                    </div>

                                </div>
                                <div class="form-group" hidden="hidden" >
                                    
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-info"  Text="Preview" />
                                    </div>

                                </div>
                                <br />
                                <asp:Table ID="TableRapportExpertise" runat="server" Width="90%"> 

                                </asp:Table>
                            </div>
                        </div>
                        
                    </div>

                    <!-- Menu Devis -->
                    <div id="menu3" class="tab-pane fade">
                        <asp:Table ID="TableDevis" runat="server" Width="90%"> 
                            </asp:Table>

                         
                    </div>
                    <!-- Menu Rapport Final -->
                    <div id="menu4" class="tab-pane fade">
                        
                        <br />
                        <div class="row">
                            <!-- Upload des images aprés réparation -->
                            <div class="col-md-6 form-horizontal" style="border-right:1px solid black">

                                
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Photo Aprés réparation :</label>
                                    
                                    </div>
                                
                                <div class="form-group" hidden="hidden">
                                    
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button3" runat="server" CssClass="btn btn-info"  Text="Preview" />
                                    </div>

                                </div>
                                <br />
                                <asp:Table ID="TableImageApresReparation" runat="server" Width="90%"> 

                            </asp:Table>
                            </div>
                            <!-- Upload des Rapport finaux -->
                            <div class="col-md-6 form-horizontal">
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Rapport d'expertise final :</label>
                                    
                                    </div>
                                <div class="form-group">
                                    <div class="col-sm-1">
                                        <span></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:FileUpload ID="FileUpload_RapportExpertiseFinal" runat="server" CssClass="form-control input-sm" />
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button_UploadRapportFinal" runat="server" CssClass="btn btn-info" OnClick="Button_UploadRapportFinal_Click" Text="Archiver" />
                                    </div>

                                </div>
                                <div class="form-group" hidden="hidden" >
                                    
                                    <div class="col-sm-4">
                                        <asp:Button ID="Button5" runat="server" CssClass="btn btn-info"  Text="Preview" />
                                    </div>

                                </div>
                                <br />
                                <asp:Table ID="TableRapportExpertiseFinal" runat="server" Width="90%"> 

                                </asp:Table>
                            </div>
                        </div>
                        
                    
                    </div>
                </div>
            </div>

            <!-- Panel Image -->
            <asp:Panel ID="PanelImageAvantReparation" runat="server" CssClass="modalpopup">
                <div class="container">
                <div class="row">
                    <asp:Image id="ImageAvantReparationPreview" runat="server" AlternateText="Image text" ImageAlign="left" ImageUrl="images/image1.jpg"/>
                </div>
                <div class="row">
                    <asp:Label ID="Msg" runat="server" Text="Msg"></asp:Label>
                <asp:Button ID="button_CancelImageView" runat="server" Text="Close" />
                </div>
                    </div>
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="modalBackground" CancelControlID="button_CancelImageView" PopupControlID="PanelImageAvantReparation" TargetControlID="Button_PreviewImage"></ajaxToolkit:ModalPopupExtender>

            <!-- Panel PDF -->
            <asp:Panel ID="PanelRapportPreview" runat="server" CssClass="modalpopup">
                <div class="container">
                
                <div class="row">
                    <asp:Label ID="Label1" runat="server" Text="Msg">Rapport View</asp:Label>
                <asp:Button ID="button_RapportViewClose" runat="server" Text="Close" />
                </div>
                    </div>
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" BackgroundCssClass="modalBackground" CancelControlID="button_RapportViewClose" PopupControlID="PanelRapportPreview" TargetControlID="Button2"></ajaxToolkit:ModalPopupExtender>
        </section>
    </section>
</asp:Content>
