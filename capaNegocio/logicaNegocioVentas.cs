using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioVentas
    {
        accesoDatosVentas av = new accesoDatosVentas();

        public int insertarVenta(Ventas ve)
        {
            return av.insertarVenta(ve);
        }

        public List<Ventas> listarVentas()
        {
            return av.listarVentas();
        }

        public List<Ventas> BuscarVentas(string dato)
        {
            return av.BuscarVentas(dato);
        }
    }
}
