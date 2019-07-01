using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioFactura
    {
        accesoDatosFacturas af = new accesoDatosFacturas();

        public int insertarFacturas(Factura fa)
        {
            return af.insertarFacturas(fa);
        }

        public List<Factura> listarEmpleados()
        {
            return af.listarFactura();
        }

        public List<Factura> BuscarFacturas(string dato)
        {
            return af.BuscarFacturas(dato);
        }
    }
}
