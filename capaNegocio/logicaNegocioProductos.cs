using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioProductos
    {
        accesoDatosProductos ap = new accesoDatosProductos();

        public int insertarProductos(Productos po)
        {
            return ap.insertarProductos(po);
        }

        public List<Productos> listarProductos()
        {
            return ap.listarProductos();
        }

        public int eliminarProductos(int codproducto)
        {
            return ap.eliminarProductos(codproducto);
        }

        public int editarProductos(Productos po)
        {
            return ap.editarProductos(po);
        }
        public List<Productos> BuscarProductos(string dato)
        {
            return ap.BuscarProductos(dato);
        }

    }
}
