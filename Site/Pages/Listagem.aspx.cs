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
    public partial class Listagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteDAL comamndo = new ClienteDAL();

            gridCliente.DataSource = comamndo.Select();
            gridCliente.DataBind();
        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/AtualizarCliente.aspx");
        }
    }
}