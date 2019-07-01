using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Productos
    {
        public int codproducto { get; set; }
        public string producto { get; set; }
        public int precio { get; set; }
        public int existencia { get; set; }
        public int codcategoria { get; set; }
        public int codproveedor { get; set; }


    }
}
