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
    public partial class WebForm2 : System.Web.UI.Page
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
                ddCategoria.DataTextField = "Descripcion";
                ddCategoria.DataValueField = "Id";
                ddCategoria.DataBind();
            }

            if (Request.QueryString["id"] != null)
            {
                if (!IsPostBack)
                {
                    id = int.Parse(Request.QueryString["id"].ToString());
                    ArticuloBusiness articuloBusiness = new ArticuloBusiness();
                    List<Articulo> articulos = articuloBusiness.List();

                    Articulo seleccionado = articulos.Find(x => x.Id == id);

                    if (seleccionado != null)
                    {

                        TxtNombre.Text = seleccionado.Nombre;
                        TxtDescripcion.Text = seleccionado.Descripcion;
                        TxtCodigo.Text = seleccionado.Codigo;
                        ddMarca.Text = seleccionado.Marca.ToString();
                        ddCategoria.Text = seleccionado.Categoria.ToString();
                        txtImagenUrl.Text = seleccionado.Imagen.FirstOrDefault()?.ImagenUrl.ToString();

                        decimal precioDecimal = seleccionado.Precio;

                        TxtPrecio.Text = precioDecimal.ToString();
                    }

                }

            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            ArticuloBusiness articuloBusiness = new ArticuloBusiness();

            articulo.Codigo = TxtCodigo.Text;
            articulo.Nombre = TxtNombre.Text;
            articulo.Descripcion = TxtDescripcion.Text;

            // Obtener la descripción seleccionada de ddMarca y buscar la Marca correspondiente en la lista de marcas.
            string marcaDescripcionSeleccionada = ddMarca.SelectedValue;
            string categoriaelecionada = ddCategoria.SelectedValue;

            Debug.WriteLine("Marca seleccionada: " + marcaDescripcionSeleccionada);
            Debug.WriteLine("Categoria seleccionada: " + categoriaelecionada);

            Marca marcaSeleccionada = ObtenerMarcaPorDescripcion(marcaDescripcionSeleccionada);
            Categoria categoria1 = ObtenerCategoriaPorDescripcion(categoriaelecionada);

            articulo.Marca = marcaSeleccionada;
            articulo.Categoria = categoria1;

            Imagen nuevaImagen = new Imagen
            {
                IdArticulo = articulo.Id,
                ImagenUrl = txtImagenUrl.Text
            };
            articulo.Imagen = new List<Imagen> { nuevaImagen };
            articulo.Precio = int.Parse(TxtPrecio.Text);
            articuloBusiness.Agregar(articulo);
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