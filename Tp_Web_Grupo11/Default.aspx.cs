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

            if (!IsPostBack)
            {
                // Aquí deberías obtener tus datos de la base de datos o de donde sea que los almacenes
                // y asignarlos a la variable 'articulos' como una lista de objetos Articulo.
                List<Articulo> articulos = ObtenerArticulosDesdeLaBaseDeDatos(); // Debes implementar esta función.

                // Asigna la lista de 'articulos' al GridView
                dgvProductos.DataSource = articulos;
                dgvProductos.DataBind();

                // Asigna la lista de 'articulos' al carrusel
                rptProductos.DataSource = articulos;
                rptProductos.DataBind();
            }


        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var algo= dgvProductos.SelectedRow.Cells[0].Text;
            var id= dgvProductos.SelectedDataKey.Value.ToString();
            Response.Redirect("Productos.aspx?id=" + id);
            
        }



        private List<Articulo> ObtenerArticulosDesdeLaBaseDeDatos()
        {
            // Aquí debes implementar la lógica para obtener los datos de los Articulos
            // desde tu base de datos y retornarlos como una lista de objetos Articulo.
            // Por ejemplo:
            ArticuloBusiness articuloBusiness = new ArticuloBusiness();
            //List<Articulo> articulos = articuloBusiness.List();
            List<Articulo> articulos = articuloBusiness.List();
            // Llena 'articulos' con datos de la base de datos.
            return articulos;
        }
    }
}