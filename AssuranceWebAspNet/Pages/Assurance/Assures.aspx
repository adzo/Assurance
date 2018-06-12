<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master" AutoEventWireup="true" CodeBehind="Assures.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.Assures" %>




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
            width: 90%;
            height : 80%;
            overflow:auto;
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
                        <li><a href="Assures.aspx">Assurés</a></li>
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
                        <legend>Assurés :</legend>
                    </fieldset>
                </div>
                <div class="col-md-2">
                    <asp:Button ID="ButtonAjouterAssure" CssClass="btn btn-info" runat="server" Text="Ajouter" />
                </div>
            </div>

            <!-- Partie liste Assurés -->
            <div class="row">
                <div class="col-md-1">
                    <h2 hidden="hidden">Test:</h2>
                </div>
                <div class="col-md-10">
                    <fieldset>
                        <asp:Table ID="TableAssures" class="table table-striped" runat="server"></asp:Table>

                    </fieldset>
                </div>
            </div>



            <!-- Ajout Assure -->

            <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup">

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
                        


                    </div>
                    <div class="col-md-4 form-horizontal">
                        <div class="form-group">
                            <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="_A_DelivreeLe" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-4" for="email">N° Permis:</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="_A_NumPermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="control-label col-sm-4" for="email">Délivrée le:</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="_A_DatePermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                    
                    
                </div>
                <br />
                <div class="row">
                    <div class="col-md-9">
                        <h3 hidden="hidden">test</h3>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <div >
                                <asp:Button ID="Button_EnregistrerAssure" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerAssure_Click" Text="Enregistrer" />
                                <asp:Button ID="button_cancel" runat="server" CssClass="btn btn-info" Text="Annuler" />
                            </div>
                        </div>
                    </div>
                </div>



            </asp:Panel>

            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" CancelControlID="button_cancel" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="ButtonAjouterAssure"></ajaxToolkit:ModalPopupExtender>

        </section>
    </section>
</asp:Content>


