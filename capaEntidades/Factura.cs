using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Factura
    {
        public int idFactura { get; set; }
        public DateTime fechaFactura { get; set; }
        public int codcliente { get; set; }
        public int codempleado { get; set; }
    }
}
