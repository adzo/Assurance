<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssure.Master" AutoEventWireup="true" CodeBehind="Compte.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assure.Compte" %>


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
                        <li><i class="fa fa-home"></i><a href="Home.aspx">Accueil</a></li>
                        <li><i class="fa fa-home"></i><a href="Compte.aspx">Compte</a></li>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    </ol>
                </div>
            </div>
            <div class="row">
                <div class="col-md-1">
                    <h3 hidden="hidden">test</h3>
                </div>
                <div class="col-md-10">
                    <fieldset>
                        <legend>Modifier Mot de Pass: </legend>
                        <div class="form-group">

                            <div class="col-sm-6">
                                <asp:Button ID="ButtonLunchUpdate" CssClass="btn btn-info" runat="server" Text="Modifier" />

                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>


            <!-- Ajax Part -->
            <asp:Panel ID="PanelPassword" runat="server" CssClass="modalpopup">
                <div class="row">
                    <div class="col-md-1">
                        <h3 hidden="hidden">test</h3>
                    </div>
                    <div class="col-md-10">
                        <fieldset>
                            <legend>Modifier Mot de Pass: </legend>

                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Ancien:</label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="TextBoxOldPassword" TextMode="Password" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBoxOldPassword" runat="server" ErrorMessage="champ obligatoire" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Nouveau:</label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="TextBoxNewPassword" TextMode="Password" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxNewPassword" runat="server" ErrorMessage="champ obligatoire" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label col-sm-4" for="email">Confirmer:</label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="TextBoxConfirmPassword" TextMode="Password" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="Label_passwordValidator" ControlToValidate="TextBoxConfirmPassword" runat="server" ErrorMessage="champ obligatoire" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
                                    
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-sm-6">
                                    <asp:Button ID="ButtonUpdate" CssClass="btn btn-info" runat="server" Text="Modifier" OnClick="ButtonUpdate_Click"  />
                                    <asp:Button ID="ButtonCancel" CssClass="btn btn-info" runat="server" Text="Annuler" />
                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="ButtonLunchUpdate" PopupControlID="PanelPassword" BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>

        </section>
    </section>
</asp:Content>
