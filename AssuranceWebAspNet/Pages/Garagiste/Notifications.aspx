<%@ Page Language="C#"  MasterPageFile="~/MasterPage/MasterGaragiste.Master"  AutoEventWireup="true" CodeFile="Notifications.aspx.cs" Inherits="GaragisteNotifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <meta http-equiv="Refresh" content="5; url=Accueil.aspx" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa fa-bars"></i>Notifications</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="Accueil.aspx">Accueil</a></li>
                <li><a href="Notifications.aspx">Notifications</a></li>

              
            </ol>
          </div>
        </div>
       <div class="row">
              <div class="col-md-2">
                  <h3 hidden="hidden">Test</h3>
              </div>
              <div class="col-md-8">
                  <fieldset>
                      <legend>
                          Under construction!!
                      </legend>
                      <h2>You will be redirected automatically!</h2>
                          <div style="height: 30px;width: 30px;">
                              <img style="max-width:100%; max-height:100%" src="../../img/gifs/loading.gif" alt="gif image" />
                          </div>
                  </fieldset>
              </div>
          </div>
      </section>
    </section>
</asp:Content>
