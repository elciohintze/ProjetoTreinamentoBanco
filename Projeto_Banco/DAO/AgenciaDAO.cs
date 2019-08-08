using Projeto_Banco.DadosBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
   public class AgenciaDAO
    {
        private List<Agencia> agenciaCadastrada = new List<Agencia>();

        public void CadastroAgencia(Agencia ac)
        {
            agenciaCadastrada.Add(ac);
        }

    }
}
