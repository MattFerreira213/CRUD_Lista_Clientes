<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Site.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Projeto - CRUD Lista de Clientes</h1>
        
        Selecione uma opção:<br />
        <asp:DropDownList ID="ddlCliente" runat="server">
            <asp:ListItem Value="0" Text="- Selecione uma opção -"/>
            <asp:ListItem Value="1" Text="Cadastrar Cliente" />
            <asp:ListItem Value="2" Text="Listar Clientes" />
            <asp:ListItem Value="3" Text="Manipular dados" />
        </asp:DropDownList>   

        <asp:Button ID="btnAcessar" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessarMenu" />

        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>
        
    </div>
    </form>
</body>
</html>
