<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterCentre.Master"  AutoEventWireup="true" CodeBehind="ListeSinistre.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Centre.ListeSinistre" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa fa-bars"></i>Recherche sinistre</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                <li><a href="PriseCharge.aspx">Recherche sinistre</a></li>
            </ol>
          </div>
        </div>
     <div class="container">
             <div class="row">
                <div class="form-inline">
                    <div class="form-horizontal form-group">
                    <asp:TextBox ID="TextBox_SinistreIdToSearch" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>
                    </div>                   
                    <asp:Button ID="Button_RechercheSinistre" CssClass="btn btn-info" runat="server"  Text="Recherche Sinistre" OnClick="Button_RechercheSinistre_Click" />
            <!--         <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox_SinistreIdToSearch" ErrorMessage="Value must be a whole number" /> -->
                </div>
             </div>
        </div>
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
          <div class="container">
          
          &nbsp;</div>
          <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
      </section>

    </section>
   
</asp:Content>