<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master" AutoEventWireup="true" CodeBehind="Sinistre.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.Sinistre" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa fa-bars"></i> Accueil</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
              
            </ol>
          </div>
        </div>
           </section>
    
         <div class="container">
             <div class="row">
                <div class="form-inline">
                    <div class="form-horizontal form-group">
                        
                    

                    <asp:TextBox ID="TextBox1_Sinistre" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>
                    </div>                   
                    <asp:Button ID="Button_RechercheSinistre" CssClass="btn btn-info" runat="server"   Text="Recherche" OnClick="Button_RechercheSinistre_Click"  />
                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox1_Sinistre" ErrorMessage="Value must be a whole number" />
                </div>
             </div>
        </div>
         <div class="container">
             <div class="row">
                <div class="form-inline">
                    <h3>Liste des sinistres</h3>
                </div>
             </div>
        </div>
        <div class="container">
             <div class="row">
                <div class="form-inline">
                    
                    <asp:PlaceHolder ID="PlaceHolder_TableSinistres" runat="server"></asp:PlaceHolder>
                    
                </div>
             </div>
        </div>
        
    </section>
</asp:Content>
