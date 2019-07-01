using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioClientes
    {
        accesoDatosClientes acli = new accesoDatosClientes();

        public int insertarCliente(Clientes cli)
        {
            return acli.insertarCliente(cli);
        }

        public List<Clientes> listarClientes()
        {
            return acli.listarClientes();
        }

        public int eliminarCliente(int codcliente)
        {
            return acli.eliminarCliente(codcliente);
        }

        public int editarClientes(Clientes cli)
        {
            return acli.editarClientes(cli);
        }
        public List<Clientes> BuscarClientes(string dato)
        {
            return acli.BuscarClientes(dato);
        }
    }
}
