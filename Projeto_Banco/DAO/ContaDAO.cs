using Projeto_Banco.DadosBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
    public class ContaDAO 
    {
        private List<Conta> _contas = new List<Conta>();


        public void CadastroConta(Conta newConta) {
            _contas.Add(newConta);
        }

    }
}
