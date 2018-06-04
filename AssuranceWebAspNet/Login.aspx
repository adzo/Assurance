<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AssuranceWebAspNet.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>GGC LOGIN</title>
    
	
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="stylelogin/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="stylelogin/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="stylelogin/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="stylelogin/vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="stylelogin/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="stylelogin/vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="stylelogin/css/util.css">
	<link rel="stylesheet" type="text/css" href="stylelogin/css/main.css">
<!--===============================================================================================-->
</head>
<body>
    <form id="form1" runat="server">
    <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<div class="login100-pic js-tilt" data-tilt>
					<img src="stylelogin/images/img-01.png" alt="IMG">
				</div>

				<div class="login100-form validate-form">
					<span class="login100-form-title">
						espace privé
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						
                        <asp:TextBox ID="text_mail" class="input100" placeholder="login" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Label_mailValidator" ControlToValidate="text_mail" runat="server" ErrorMessage="champ obligatoire" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Password is required">
						 <asp:TextBox ID="text_password" TextMode="Password" class="input100" placeholder="mot de passe" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Label_passwordValidator" ControlToValidate="text_password" runat="server" ErrorMessage="champ obligatoire" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>
					
					<div class="container-login100-form-btn">
						
                         <asp:Button ID="btn_connexion" runat="server" CssClass="login100-form-btn" Text="Connexion" OnClick="btn_connexion_Click"  />
                        <asp:Label ID="Label_connexionValidator" runat="server" ForeColor="Red"></asp:Label>
					</div>

					

					<div class="text-center p-t-136">
						<a class="txt2" href="http://www.ntis.com.tn/">
			                 2018 &copy by NTIS
							<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
						</a>
					</div>
				</div>
			</div>
		</div>
	</div>
    </form>
    <!--===============================================================================================-->	
	<script src="stylelogin/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="stylelogin/vendor/bootstrap/js/popper.js"></script>
	<script src="stylelogin/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="stylelogin/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="stylelogin/vendor/tilt/tilt.jquery.min.js"></script>
	<script >
		$('.js-tilt').tilt({
			scale: 1.1
		})
	</script>
<!--===============================================================================================-->
	<script src="stylelogin/js/main.js"></script>
</body>
</html>
