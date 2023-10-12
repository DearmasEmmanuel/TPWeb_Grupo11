using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Tp_Web_Grupo11
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Recuperar los productos del carrito desde la variable de sesión
                List<Articulo> carrito = (List<Articulo>)Session["Carrito"];

                // Calcular el precio total y la cantidad total
                decimal precioTotal = 0;
                int cantidadTotal = 0;

                if (carrito != null)
                {
                    cantidadTotal = carrito.Count;

                    foreach (Articulo producto in carrito)
                    {
                        precioTotal += producto.Precio;
                    }
                }

                // Asignar la lista de productos al GridView
                dgvCarrito.DataSource = carrito;
                dgvCarrito.DataBind();

                // Mostrar la cantidad y el precio total
                lblCantidadTotal.Text = cantidadTotal.ToString();
                lblPrecioTotal.Text = precioTotal.ToString("C"); // Formatear como moneda
            }
        }
    }
}
