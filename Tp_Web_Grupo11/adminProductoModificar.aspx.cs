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
                        TxtId.Text = seleccionado.Id.ToString();
                        TxtNombre.Text = seleccionado.Nombre;
                        TxtDescripcion.Text = seleccionado.Descripcion;
                        TxtCodigo.Text = seleccionado.Codigo;
                        ddMarca.Text = seleccionado.Marca.Id.ToString();
                        ddCategoria.Text = seleccionado.Categoria.Id.ToString();
                        txtImagenUrl.Text = seleccionado.Imagen.FirstOrDefault()?.ImagenUrl.ToString();

                        decimal precioDecimal = seleccionado.Precio;

                        TxtPrecio.Text = precioDecimal.ToString();
                    }

                }

            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloBusiness originalbusiness = new ArticuloBusiness();
            Articulo original = new Articulo();

            ArticuloBusiness selecionadobusiness = new ArticuloBusiness();
            Articulo seleccionado = new Articulo();

            original = originalbusiness.ObtenerArticuloPorId(int.Parse(TxtId.Text));

            seleccionado.Id = int.Parse(TxtId.Text);
            seleccionado.Codigo = TxtCodigo.Text;
            seleccionado.Nombre = TxtNombre.Text;
            seleccionado.Descripcion = TxtDescripcion.Text;
            Marca marca = new Marca
            {
                Id = int.Parse(ddMarca.SelectedValue),
                Descripcion = original.Marca.Descripcion,
            };
            seleccionado.Marca = marca;

            Categoria categoria = new Categoria
            {
                Id = int.Parse(ddCategoria.SelectedValue),
                Descripcion = original.Categoria.Descripcion,
            };
            seleccionado.Categoria = categoria;

            if (txtImagenUrl.Text != null)
            {
                Imagen Imagen = new Imagen
                {
                    Id = original.Imagen[0].Id,
                    IdArticulo = int.Parse(TxtId.Text),
                    ImagenUrl = txtImagenUrl.Text
                };
                seleccionado.Imagen = new List<Imagen> { Imagen };
            }

            seleccionado.Precio = decimal.Parse(TxtPrecio.Text);

            selecionadobusiness.Modificar(original, seleccionado);
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




