using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio

{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public static Marca FirstOrDefault(List<Marca> marcas)
        {
            return marcas.FirstOrDefault();
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}