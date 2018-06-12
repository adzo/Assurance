<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master" AutoEventWireup="true" CodeBehind="Reclamation.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.ReclamationView" %>


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
            width: 60%;
            background-color: white;
            border: 1px solid black;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Accueil</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Reclamations</a></li>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    </ol>
                </div>
            </div>

            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:</h2>
                </div>
                <div class="col-md-11">
                    <fieldset>
                        <legend>Reclamations :</legend>
                    </fieldset>
                </div>

            </div>


            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:</h2>
                </div>
                <div class="col-md-10">
                    <fieldset>
                        <asp:Table ID="TableReclamations" class="table table-striped" runat="server"></asp:Table>

                    </fieldset>
                </div>
                <div hidden="hidden">
                    <asp:Button ID="ButtonLunchUpdate" hidden="hidden" CssClass="btn btn-info" runat="server" Text="Fermer" />
                </div>
                
            </div>

            <!-- Panel detail reclamation body -->
            <asp:Panel ID="PanelDetailReclamation" runat="server" CssClass="modalpopup">
                <div class="row">
                    <div class="col-md-1">
                        <h3 hidden="hidden">Assure</h3>
                    </div>
                    <div class="col-md-10">
                        <fieldset>
                            <legend>Détail réclamation : </legend>
                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Assuré:</label>
                                <div class="col-sm-8">
                                    <asp:Label ID="LabelAssure" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Titre:</label>
                                <div class="col-sm-8">
                                    <asp:Label ID="LabelTitre" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Description:</label>
                                <div class="col-sm-8">
                                    <asp:Label ID="LabelDescription" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                            <br />

                            <div class="form-group">

                                <div class="col-sm-12">
                                    <asp:Button ID="ButtonCancel" CssClass="btn btn-info" runat="server" Text="Fermer" />
                                    
                                </div>

                            </div>
                        </fieldset>
                    </div>
                </div>


            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="ButtonLunchUpdate" PopupControlID="PanelDetailReclamation" BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>


        </section>
    </section>
</asp:Content>
