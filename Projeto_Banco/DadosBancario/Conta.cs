using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DadosBancario
{
    public class Conta
    {
        public int IdConta { get; set; }
        public int AgenciaConta { get; set; }
        public int IdPessoa { get; set; }
        public double SaldoConta { get; set; }
        public DateTime DataAberturaConta { get; set; }
    }
}
