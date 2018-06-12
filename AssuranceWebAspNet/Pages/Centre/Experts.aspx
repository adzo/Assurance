<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterCentre.Master" AutoEventWireup="true" CodeBehind="Experts.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Centre.Experts" %>

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
	    border:1px solid black;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Accueil</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                        <li><a href="Experts.aspx">Experts</a></li>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    </ol>
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:

                        <asp:Button ID="ButtonUpdateExpert" CssClass="btn btn-info" runat="server" Text="Update" />
                    </h2>
                </div>
                <div class="col-md-9">
                    <fieldset>
                        <legend>Experts :</legend>
                        </fieldset>
                    </div>
                <div class="col-md-2">
                    <asp:Button ID="ButtonAjouterExpert" CssClass="btn btn-info" runat="server" Text="Ajouter" />
                </div>
                </div>

            <!-- Partie liste Garage -->
            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:</h2>
                </div>
                <div class="col-md-10">
                    <fieldset>
                        <asp:Table ID="TableExperts" class="table table-striped" runat="server"></asp:Table>
                        
                    </fieldset>
                </div>
            </div>
            
            

            <!-- Ajout Expert -->
            
            <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup">
                

                <div class="row">
                    <div class="col-md-1">
                        <h3 hidden="hidden">test</h3>
                    </div>
                    <div class="col-md-10">
                        <fieldset>
                            <legend>Ajouter expert: </legend>
                            
                               
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_FirstName" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prenom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_LastName" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Email:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_Mail"  CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Téléphone:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_PhoneNumber" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="button_AjoutExpert" CssClass="btn btn-info" runat="server" Text="Ajouter" OnClick="button_AjoutExpert_Click" />
                                        <asp:Button ID="button_cancel" CssClass="btn btn-info" runat="server" Text="Annuler" />
                                    </div>
                                </div>
                        </fieldset>
                    </div>
                </div>



                </asp:Panel>
            
            <!-- Update Expert -->
            <asp:Panel ID="UpdatePanel" runat="server" CssClass="modalpopup">
                
                <div class="row">
                    <div class="col-md-1">
                        <h3 hidden="hidden">test</h3>
                    </div>
                    <div class="col-md-10">
                        <fieldset>
                            <legend>Modifier expert: </legend>
                                <div hidden="hidden">
                                    <asp:TextBox ID="TextBox_UserIdUpdate" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                </div>
                               
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Nom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_LastNameUpdate" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Prenom:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_FirstNameUpdate" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Email:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_MailUpdate"  CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Téléphone:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_PhoneNumberUpdate" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="button_ModifierExpert" CssClass="btn btn-info" runat="server" Text="Modifier" OnClick="button_ModifierExpert_Click" />
                                        <asp:Button ID="button2_cancel2" CssClass="btn btn-info" runat="server" Text="Annuler" />
                                    </div>
                                </div>
                        </fieldset>
                    </div>
                </div>

            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="popupUpdate" runat="server" CancelControlID="button2_cancel2" PopupControlID="UpdatePanel" BackgroundCssClass="modalBackground" TargetControlID="ButtonUpdateExpert"></ajaxToolkit:ModalPopupExtender>


            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" CancelControlID="button_cancel" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="ButtonAjouterExpert"></ajaxToolkit:ModalPopupExtender>

        </section>
    </section>
</asp:Content>

