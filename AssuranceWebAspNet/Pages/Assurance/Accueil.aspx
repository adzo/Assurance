<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterAssurance.Master"  AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="AssuranceWebAspNet.Pages.Assurance.AssuranceAceuil" %>


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
      <div class="container">
          <div class="row">
              <div class="col-md-4">
                  <a href="PriseEnCharge.aspx" > <div class="thumbnail pull-right" style="width:60%;height:auto"><img src="../../img/imgAccueil/voit.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Prise en charge</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
                  <a href="Experts.aspx" > <div class="thumbnail centered" style="width:60%;height:auto"><img src="../../img/imgAccueil/exp.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Experts</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
                   <a href="Garages.aspx" > <div class="thumbnail pull-left" style="width:60%;height:auto"><img src="../../img/imgAccueil/gar.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Garages</b></h4></div></div></a>
              </div>
          </div>
             <div class="row">
              <div class="col-md-4">
                  <a href="Assures.aspx" > <div class="thumbnail pull-right" style="width:60%;height:auto"><img src="../../img/imgAccueil/client.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Clients</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
              <a href="Historique.aspx" > <div class="thumbnail centered" style="width:60%;height:auto"><img src="../../img/imgAccueil/hist.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Historiques</b></h4></div></div></a>
              </div>
               <div class="col-md-4">
                   <a href="Statistiques.aspx" > <div class="thumbnail pull-left" style="width:60%;height:auto"><img src="../../img/imgAccueil/stat.jpg" class="img-rounded img-responsive"  /><div class="caption"><h4 class="text-center"><b>Statistiques</b></h4></div></div></a>
              </div>
          </div>
      </div>
      </section>
    </section>
</asp:Content>

