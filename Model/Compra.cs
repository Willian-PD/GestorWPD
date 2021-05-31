using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Compra {
		public String codigo { get; set; }

		public String fornecedor { get; set; }

		public Int64 totalDeProdutos { get; set; }

		public String tipoDeProduto { get; set; }

		public String local { get; set; }

		public float valor { get; set; }

	}
}
