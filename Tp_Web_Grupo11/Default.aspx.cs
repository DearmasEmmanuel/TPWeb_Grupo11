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
            string terminoBusqueda = Session["TerminoBusqueda"] as string;

            if (!IsPostBack)
            {
                List<Articulo> resultados;

                if (string.IsNullOrEmpty(terminoBusqueda))
                {
                    
                    resultados = ObtenerArticulosDesdeLaBaseDeDatos();
                }
                else
                {
                    
                    resultados = articuloBusiness.Buscar(terminoBusqueda);
                }

                
                rptProductos.DataSource = resultados;
                rptProductos.DataBind();
            }
        }





        private List<Articulo> ObtenerArticulosDesdeLaBaseDeDatos()
        {
           
            ArticuloBusiness articuloBusiness = new ArticuloBusiness();
            //List<Articulo> articulos = articuloBusiness.List();
            List<Articulo> articulos = articuloBusiness.List();
            // Llena 'articulos' con datos de la base de datos.
            return articulos;
        }

        protected void AgregarAlCarrito_Click(object sender, EventArgs e)

        {
            ArticuloBusiness articuloBusiness = new ArticuloBusiness();
            Button btn = (Button)sender;
            //GridViewRow row = (GridViewRow)btn.NamingContainer;
            int productoId = Convert.ToInt32(btn.CommandArgument);

            // Obtener el producto seleccionado según el ID

            Articulo producto = new Articulo();
            producto = articuloBusiness.ObtenerArticuloPorId(productoId);

            // Agregar el producto al carrito (por ejemplo, una lista)
            List<Articulo> carrito = (List<Articulo>)Session["Carrito"] ?? new List<Articulo>();
            carrito.Add(producto);
            Session["Carrito"] = carrito;

            lblMensaje.Text = "¡Producto agregado al carrito correctamente!";
            lblMensaje.CssClass = "visible"; // Muestra el mensaje
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);

        }
       



    }
}


