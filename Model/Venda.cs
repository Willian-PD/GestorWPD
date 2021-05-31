using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda {
        public Int64 codigo { get; set; }
        public String cliente { get; set; }
        public Int64 totalDeProdutos { get; set; }
        public String local { get; set; }
        public float valor { get; set; }
    }
}
