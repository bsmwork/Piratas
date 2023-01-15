using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ficha { 
        public int id { get; set; }
        public string titulo { get; set; }
        public string texto { get; set; }
        public string autor { get; set; }
        public string obra { get; set; }
        // DESCRIPTORES
        public string nombre { get; set; }
        public string tema { get; set; }
        public string tiempo { get; set; }
        public string espacio { get; set; }

    }
}
