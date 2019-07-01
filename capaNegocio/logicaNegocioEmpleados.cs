using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioEmpleados
    {
        accesoDatosEmpleados ae = new accesoDatosEmpleados();

        public int insertarEmpleados(Empleados em)
        {
            return ae.insertarEmpleados(em);
        }

        public List<Empleados> listarEmpleados()
        {
            return ae.listarEmpleados();
        }

        public int eliminarEmpleados(int codempleado)
        {
            return ae.eliminarEmpleados(codempleado);
        }

        public int editarEmpleados(Empleados em)
        {
            return ae.editarEmpleados(em);
        }
        public List<Empleados> BuscarEmpleado(string dato)
        {
            return ae.BuscarEmpleado(dato);
        }
    }
}
