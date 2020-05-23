using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Modal;
using DAL.Percistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Cliente dados = new Cliente();

                dados.Nome      = txtNome.Text;
                dados.Email     = txtEmail.Text;
                dados.Endereco  = txtEndereco.Text;

                ClienteDAL comando = new ClienteDAL();

                comando.Insert(dados);

                lblMensagem.Text = "Cliente cadastrado com sucesso!";

                txtNome.Text        = string.Empty;
                txtEmail.Text       = string.Empty;
                txtEndereco.Text    = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}