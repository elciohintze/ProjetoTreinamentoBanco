using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DadosBancario
{
    class Operacao
    {
        public int IdOperacao { get; set; }
        public int IdContaMovimentada { get; set; }
        public int IdContaOrigem { get; set; }
        public int TipoLancamento { get; set; }
        public int OperacaoVinculada { get; set; }
        public int TipoOperacao { get; set; } //debito ou credito
        public double ValorOperacao { get; set; }

    }
}
