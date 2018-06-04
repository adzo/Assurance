<%@ Page Language="C#"  MasterPageFile="~/MasterPage/MasterGaragiste.Master"  AutoEventWireup="true" Inherits="GaragistePriseCharge" Codebehind="PriseCharge.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa fa-bars"></i>Prise en charge</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                <li><a href="PriseCharge.aspx">Prise en charge</a></li>
                    <li><a href="Detail.aspx">Detail Sinistre</a></li>

              
            </ol>
          </div>
        </div>
      <div class="container">
          
          Recherche Sinistre:
          <asp:TextBox ID="TextBox1_Sinistre" runat="server"></asp:TextBox>
          <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox1_Sinistre" ErrorMessage="Value must be a whole number" />
          <asp:Button ID="Button_RechercheSinistre" runat="server" OnClick="Button_RechercheSinistre_Click" Text="Recherche" />
          
      </div>
          <div class="container">
          
          &nbsp;</div>
          <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
      </section>
    </section>
</asp:Content>