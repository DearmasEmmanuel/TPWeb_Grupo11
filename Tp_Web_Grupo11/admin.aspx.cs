using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_Web_Grupo11
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBusiness articuloBusiness = new ArticuloBusiness();
            dgvProductos.DataSource = articuloBusiness.List();
            dgvProductos.DataBind();

            dgvProductos.Columns[0].Visible = false;
        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvProductos.SelectedDataKey.Value.ToString();
            Response.Redirect("adminProductoModificar.aspx?id=" + id);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminProductoNuevo.aspx");
        }
    }
}