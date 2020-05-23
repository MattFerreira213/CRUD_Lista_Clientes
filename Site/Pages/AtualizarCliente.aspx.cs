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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                ClienteDAL comando = new ClienteDAL();
                Cliente dados = comando.SelecionarCliente(id);

                if (dados != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = dados.Nome;
                    txtEmail.Text = dados.Email;
                    txtEndereco.Text = dados.Endereco;
                }
                else
                {
                    lblMensagem.Text = "Cliente não cadastrado.";

                    txtId.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtializarCliente(object sender, EventArgs e)
        {
            try
            {
                Cliente dados = new Cliente();

                dados.Id = Convert.ToInt32(txtId.Text);
                dados.Nome = txtNome.Text.ToString();
                dados.Email = txtEmail.Text.ToString();
                dados.Endereco = txtEndereco.Text.ToString();

                ClienteDAL comando = new ClienteDAL();

                comando.Update(dados);

                lblMensagem.Text = "Dados atualizados com sucesso!";

                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEndereco.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnDeletarCliente(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                ClienteDAL comando = new ClienteDAL();

                comando.Delete(id);

                lblMensagem.Text = "Dados deletados com sucesso!";

                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEndereco.Text = string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}