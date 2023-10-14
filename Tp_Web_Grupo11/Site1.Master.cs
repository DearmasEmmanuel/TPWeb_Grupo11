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
    public partial class Site1 : System.Web.UI.MasterPage

    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar el control en la página secundaria
            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
            TextBox txtbuscar = (TextBox)contentPlaceHolder.FindControl("txtbuscar");

            if (txtbuscar != null)
            {
                string terminoBusqueda = txtbuscar.Text;
                Session["TerminoBusqueda"] = terminoBusqueda;
            }
        }

        protected void onclick_home(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }

        protected void LbCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx", false);
        }
    }
}