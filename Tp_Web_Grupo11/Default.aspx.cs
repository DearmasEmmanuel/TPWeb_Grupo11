using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Business;

namespace Tp_Web_Grupo11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBusiness articuloBusiness = new ArticuloBusiness();
            dgvProductos.DataSource = articuloBusiness.List();
            dgvProductos.DataBind();


        }
    }
}