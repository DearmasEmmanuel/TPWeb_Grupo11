using Business;
using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_Web_Grupo11
{
    public partial class adminProductoModificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            int id;

            if (!IsPostBack)
            {
                ddMarca.DataSource = MarcaBusiness.List();
                ddMarca.DataTextField = "Descripcion";
                ddMarca.DataValueField = "Id";
                ddMarca.DataBind();
            }

            if (!IsPostBack)
            {
                ddCategoria.DataSource = CategoriaBusiness.List();
                ddCategoria.DataBind();
            }

            if (Request.QueryString["id"] != null)
            {
                id = int.Parse(Request.QueryString["id"].ToString());
                ArticuloBusiness articuloBusiness = new ArticuloBusiness();
                List<Articulo> articulos = articuloBusiness.List();


                Articulo seleccionado = articulos.Find(x => x.Id == id);


                if (seleccionado != null)
                {

                    TxtId.Text = seleccionado.Id.ToString();
                    TxtNombre.Text = seleccionado.Nombre;
                    TxtDescripcion.Text = seleccionado.Descripcion;
                    TxtCodigo.Text = seleccionado.Codigo;
                    ddMarca.Text = seleccionado.Marca.Id.ToString();
                    ddCategoria.Text = seleccionado.Categoria.ToString();
                    txtImagenUrl.Text = seleccionado.Imagen.FirstOrDefault()?.ImagenUrl.ToString();

                    decimal precioDecimal = seleccionado.Precio;

                    TxtPrecio.Text = precioDecimal.ToString();

                }

            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloBusiness business = new ArticuloBusiness();
            Articulo seleccionado = new Articulo();

            seleccionado.Id = int.Parse(TxtId.Text);
            seleccionado.Codigo = TxtCodigo.Text;
            seleccionado.Nombre = TxtNombre.Text;
            seleccionado.Descripcion = TxtDescripcion.Text;
            Marca marca = new Marca
            {
                Id = int.Parse(ddMarca.SelectedValue),
                Descripcion = "NN"
            };
            seleccionado.Marca = marca;
                //seleccionado.Categoria.Descripcion = ddCategoria.SelectedValue.ToString();
                if (txtImagenUrl.Text != null)
            {
                Imagen Imagen = new Imagen
                {
                    IdArticulo = int.Parse(TxtId.Text),
                    ImagenUrl = txtImagenUrl.Text
                };
                seleccionado.Imagen = new List<Imagen> { Imagen };

            }
            seleccionado.Precio = decimal.Parse(TxtPrecio.Text);
            business.Modificar(seleccionado, seleccionado);
            Response.Redirect("admin.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {


            ArticuloBusiness business = new ArticuloBusiness();
            Articulo seleccionado = new Articulo();

            seleccionado.Id = int.Parse(TxtId.Text);
            //seleccionado.Codigo = TxtCodigo.Text;
            //seleccionado.Nombre = TxtNombre.Text;
            //seleccionado.Descripcion = TxtDescripcion.Text;
            //seleccionado.Marca.Descripcion = ddMarca.SelectedValue;
            //seleccionado.Categoria.Descripcion = ddCategoria.SelectedValue;
            if (txtImagenUrl.Text != null)
            {
                Imagen Imagen = new Imagen
                {
                    IdArticulo = int.Parse(TxtId.Text),
                    ImagenUrl = txtImagenUrl.Text
                };
                seleccionado.Imagen = new List<Imagen> { Imagen };

            }
            //seleccionado.Precio = int.Parse(TxtPrecio.Text);

            business.Eliminar(seleccionado);
            Response.Redirect("admin.aspx");

        }

        // Esta función busca una marca por su descripción en la lista de marcas.
        private Marca ObtenerMarcaPorDescripcion(string descripcion)
        {
            List<Marca> marcas = MarcaBusiness.List(); // Obtener las marcas desde tu capa de negocio.
            return marcas.FirstOrDefault(m => m.Descripcion == descripcion);
        }
        private Categoria ObtenerCategoriaPorDescripcion(string descripcion)
        {
            List<Categoria> categorias = CategoriaBusiness.List(); // Obtener las categorías desde tu capa de negocio.
            return categorias.FirstOrDefault(c => c.Descripcion == descripcion);
        }

    }
}




