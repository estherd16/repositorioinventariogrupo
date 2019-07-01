using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioProveedores
    {
        accesoDatosProveedores apv = new accesoDatosProveedores();

        public int insertarProveedores(Proveedores pv)
        {
            return apv.insertarProveedores(pv);
        }

        public List<Proveedores> listarProveedores()
        {
            return apv.listarProveedores();
        }

        public int eliminarProveedor(int codproveedor)
        {
            return apv.eliminarProveedor(codproveedor);
        }

        public int editarProveedores(Proveedores pv)
        {
            return apv.editarProveedores(pv);
        }
        public List<Proveedores> BuscarProveedores(string dato)
        {
            return apv.BuscarProveedores(dato);
        }
    }
}
