using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario : Pessoa {
        public Funcionario() {
            this.PessoaFuncionario = new Pessoa();
        }

        public String matricula { get; set; }

        public float salario { get; set; }

        public Int64 totalDeVendas { get; set; }

        public Pessoa PessoaFuncionario { get; set; }
    }
}
