using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessarMenu(object sender, EventArgs e)
        {
            string opcao = ddlCliente.SelectedValue;

            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Por favor, escolha uma opção válida.";
                    break;
                case "1":
                    Response.Redirect("/Pages/Cadastro.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/Listagem.aspx");
                    break;
                case "3":
                    Response.Redirect("/Pages/AtualizarCliente.aspx");
                    break;
            }
        }
    }
}