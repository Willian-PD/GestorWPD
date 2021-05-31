using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Cliente : Pessoa {
        public Cliente () {
            this.PessoaCliente = new Pessoa();
        }

        public String codigo { get; set; }

        public String preferencias { get; set; }

        public Int32 totalDeCompras { get; set; }

        public Pessoa PessoaCliente { get; set; }
    }
}
