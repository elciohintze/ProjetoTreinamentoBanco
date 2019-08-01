using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DadosPessoa
{
    public class Funcionario : PessoaFisica
    {
        public DateTime DtAdminissao { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
    }
}
