<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="Site.Pages.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="scripts/jquery-1.9.0.min.js"></script>
<script src="scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset-1">
                <div class="row">
                    <h3 class="well">Lista de CLientes</h3>

                    <asp:GridView ID="gridCliente" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ff6666">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                        </Columns>
                    </asp:GridView>

                    <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-primary btn-lg" OnClick="btnAtualizarCliente" />
                    <a href="~/HomePage.aspx" runat="server" class="btn btn-default btn-lg">Voltar</a>

                    <asp:Label ID="lblmensagem" runat="server" />

                </div>
            </div>

        </div>
    </form>
</body>
</html>
