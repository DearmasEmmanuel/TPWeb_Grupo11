using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Business
{
    public class CategoriaBusiness
    {
        public static List<Categoria> List()
        {

            List<Categoria> categoriaList = new List<Categoria>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT Id, Descripcion FROM CATEGORIAS");


                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Categoria cateAux = new Categoria()
                    {
                        Id = (int)data.Reader["Id"],
                        Descripcion = (string)data.Reader["Descripcion"],
                    };
                    categoriaList.Add(cateAux);
                }

                return categoriaList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.Close();
            }
        }
    }
}