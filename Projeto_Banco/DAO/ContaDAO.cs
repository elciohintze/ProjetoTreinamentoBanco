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
        private List<Conta> contas = new List<Conta>();


        public void CadastroConta(Conta a) {
            contas.Add(a);
        }

    }
}
