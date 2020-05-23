<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtualizarCliente.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consultar</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="scripts/jquery-1.9.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset-1">
            <div class="row">
                <h3 class="well">Consultar Cliente</h3>
                
                Informe o ID:<br />
                <asp:TextBox ID="txtId" runat="server" Width="3%"/>
                <br /><br />
                <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-primary btn-lg" OnClick="btnPesquisarCliente" />
                <a href="~/HomePage.aspx" runat="server" class="btn btn-default btn-lg">Voltar</a>
                <br /><br />
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Panel ID="pnlDados" runat="server">
                    Nome Completo:<br />
                    <asp:TextBox ID="txtNome" runat="server" Width="45%" CssClass="form-control" />
                    <br /><br />

                    Email:<br />
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="35%" CssClass="form-control" />
                    <br /><br />

                    Endereço:<br />
                    <asp:TextBox ID="txtEndereco" runat="server" Width="55%" CssClass="form-control" />
                    <br /><br />

                    <asp:Button ID="btnUpdate" runat="server" Text="Update" cssClass="btn btn-success btn-lg" OnClick="btnAtializarCliente"/>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-lg" OnClick="btnDeletarCliente" />
                </asp:Panel>
            </div>

        </div>
    
    </div>
    </form>
</body>
</html>
