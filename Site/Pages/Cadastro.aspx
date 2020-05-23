<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="scripts/jquery-1.9.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset-1">
            <div class="row">
                <h3 class="well">Cadastrar Cliente</h3>

                Nome Completo:
                <asp:TextBox ID="txtNome" runat="server" Width="45%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome"
                    ErrorMessage="Por favor, digite seu nome Completo" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />

                Email:
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="35%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Por favor, digite um email válido." ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />

                Endereço Residencial:
                <asp:TextBox ID="txtEndereco" runat="server" Width="55%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvEndereco" runat="server" ControlToValidate="txtEndereco"
                    ErrorMessage="Por favor, digite o seu endereço." ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />

                <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarCliente" />  
                <a href="~/HomePage.aspx" runat="server" class="btn btn-default btn-lg">Voltar</a>

                <asp:Label ID="lblMensagem" runat="server" />
            </div>

        </div>
    
    </div>
    </form>
</body>
</html>
