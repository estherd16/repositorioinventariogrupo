using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioRespaldo
    {
        accesoDatosRespaldo rbd = new accesoDatosRespaldo();

        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
