using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioCategoria
    {
        accesoDatosCategoria ac = new accesoDatosCategoria();

        public int insertarCategoria(Categoria ca)
        {
            return ac.insertarCategoria(ca);
        }

        public List<Categoria> listarCategoria()
        {
            return ac.listarCategoria();
        }

        public int eliminarCategoria(int codcategoria)
        {
            return ac.eliminarCategoria(codcategoria);
        }

        public int editarCategoria(Categoria ca)
        {
            return ac.editarCategoria(ca);
        }
        public List<Categoria> buscarCategoria(string dato)
        {
            return ac.BuscarCategoria(dato);
        }
    }
}
