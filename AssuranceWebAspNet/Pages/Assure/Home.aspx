<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssure.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assure.Home" %>

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Accueil</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Home.aspx">Accueil</a></li>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    </ol>
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:</h2>
                </div>
                <div class="col-md-9">
                    <fieldset>
                        <legend>Reclamations :</legend>
                        </fieldset>
                    </div>
                <div class="col-md-2">
                    <asp:Button ID="ButtonAjouterReclamation" CssClass="btn btn-info" runat="server" Text="Ajouter" />
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
            </div>


            <!-- Ajax Popup -->
            
            <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup">
                

                <div class="row">
                    <div class="col-md-1">
                        <h3 hidden="hidden">test</h3>
                    </div>
                    <div class="col-md-10">
                        <fieldset>
                            <legend>Ajouter réclamation: </legend>
                            
                               
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Titre:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBox_TitreReclamation" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Description:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="TextBoxDescription" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control input-sm" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                             <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">Titre:</label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="button_AjoutReclamation" CssClass="btn btn-info" runat="server" Text="Ajouter" OnClick="button_AjoutReclamation_Click" />
                                        <asp:Button ID="button_cancel" CssClass="btn btn-info" runat="server" Text="Annuler" />
                                    </div>
                                </div>
                        </fieldset>
                    </div>
                </div>



                </asp:Panel>
           
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" CancelControlID="button_cancel" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="ButtonAjouterReclamation"></ajaxToolkit:ModalPopupExtender>


        </section>
    </section>
</asp:Content>


