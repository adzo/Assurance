<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterGaragiste.Master" AutoEventWireup="true" Inherits="GarageAccueil" Codebehind="Accueil.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
      <div class="container">
          <div class="row">
              <div class="col-md-4">
                  <a href="PriseCharge.aspx" > <div class="thumbnail pull-right" style="width:60%;height:auto"><img src="../../../img/imgAccueil/voit.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Prise en charge</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
                  <a href="Historiques.aspx" > <div class="thumbnail centered" style="width:60%;height:auto"><img src="../../../img/imgAccueil/hist.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Historiques</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
                   <a href="Statistiques.aspx" > <div class="thumbnail pull-left" style="width:60%;height:auto"><img src="../../../img/imgAccueil/stat.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Statistiques</b></h4></div></div></a>
              </div>
          </div>
             
      </div>
      </section>
    </section>
</asp:Content>
