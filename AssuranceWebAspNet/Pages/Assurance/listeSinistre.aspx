<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master" AutoEventWireup="true" CodeBehind="listeSinistre.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.listeSinistre" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa fa-bars"></i>Liste Sinistre</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                        <li><a href="listeSinistre.aspx">Liste Sinistre</a></li>


                    </ol>
                </div>
            </div>
            <div class="container">

                <div class="row">
                    <div class="form-inline">
                        <div class="form-horizontal form-group">

                            <asp:TextBox ID="_TxtNumSinistre" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de sinistre"></asp:TextBox>


                        </div>
                        <div class="form-horizontal form-group">

                            <asp:TextBox ID="_TxtNumContrat" CssClass="form-control input-group-sm" runat="server" placeholder="Numéro de contrat"></asp:TextBox>

                        </div>
                        <asp:Button ID="btnChercher" CssClass="btn btn-info" runat="server" onClick="btnChercher_Click" Text="Recherche" />
                    </div>
                </div>
            </div>
            <div class="container">
                <asp:Table ID="TableListeSinistre" runat="server" Width="100%">
                </asp:Table>
            </div>

        </section>
    </section>
</asp:Content>
