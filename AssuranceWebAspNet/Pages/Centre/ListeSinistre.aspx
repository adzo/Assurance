<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterCentre.Master"  AutoEventWireup="true" CodeBehind="ListeSinistre.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Centre.ListeSinistre" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
	    border-radius: 15px 50px;
	    background-color: white;
	    border:1px solid black;
    }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa fa-bars"></i>Recherche sinistre</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                <li><a href="listeSinistre.aspx">Recherche sinistre</a></li>
            </ol>
          </div>
        </div>
           <div class="container">
             <div class="row">
                <div class="form-inline">
                    <div class="form-horizontal form-group">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:Button ID="Button_ajouterSinistre" CssClass="btn btn-info" runat="server" Text="Ajouter" />
                        
                    </div>
                </div>
            </div>
            </div>

          <br />

     <div class="container">
             <div class="row">
                <div class="form-inline">
                    <div class="form-horizontal form-group">
                    <asp:TextBox ID="TextBox_SinistreIdToSearch" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>
                    </div>                   
                    <asp:Button ID="Button_RechercheSinistre" CssClass="btn btn-info" runat="server"  Text="Recherche Sinistre" OnClick="Button_RechercheSinistre_Click" />
                     <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_SinistreIdToSearch" ErrorMessage="Value must be a whole number" />
                </div>
             </div>
        </div>

          <!-- Tableau des sinistres -->
          <div class="container">
               <asp:Table ID="TableListeSinistre" runat="server" Width="100%"> 
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>N° Sinistre</asp:TableHeaderCell>
            <asp:TableHeaderCell>Date</asp:TableHeaderCell>
            <asp:TableHeaderCell>Conducteur</asp:TableHeaderCell>
            <asp:TableHeaderCell>Permis</asp:TableHeaderCell>
            <asp:TableHeaderCell>Date Permis</asp:TableHeaderCell>
            <asp:TableHeaderCell>Nature</asp:TableHeaderCell>
            <asp:TableHeaderCell>Expert</asp:TableHeaderCell>
            <asp:TableHeaderCell>Garage</asp:TableHeaderCell>
            <asp:TableHeaderCell>Phase</asp:TableHeaderCell>
            <asp:TableHeaderCell>Etat</asp:TableHeaderCell>
            <asp:TableHeaderCell>Fichier</asp:TableHeaderCell>
            <asp:TableHeaderCell>Editer</asp:TableHeaderCell>

        </asp:TableHeaderRow>
        
    </asp:Table> 
          </div>
          
          
          

          <!-- Add sinistre body -->
          <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup">
              <div  class="tab-pane">
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
                                


                            </div>

                            <div class="col-md-4 form-horizontal">
                                
                                <div class="form-group">
                                    <label class="control-label col-sm-4" for="email">N° Permis:</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="_S_NumPermis" CssClass="form-control input-sm" runat="server"></asp:TextBox>
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
                                    <label class="control-label col-sm-4" for="email"></label>
                                    <div class="col-sm-6">
                                        <asp:Button ID="Button_EnregistrerSinistre" runat="server" CssClass="btn btn-info" OnClick="Button_EnregistrerSinistre_Click" Text="Enregistrer" />
                                        <asp:Button ID="Button_cancel" runat="server" CssClass="btn btn-info"  Text="Cancel" />
                                    </div>
                                </div>

                            </div>
                        </div>
                        <br />
                    </div>

          </asp:Panel>
          
          <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" CancelControlID="button_cancel" PopupControlID="Panel1" TargetControlID="Button_ajouterSinistre" BackgroundCssClass="modalBackground">

          </ajaxToolkit:ModalPopupExtender>














          <div class="container">
          
          &nbsp;</div>
          <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
      </section>
        
    </section>
   
</asp:Content>