using Projeto_Banco.DadosPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
    
    public class FuncionarioDAO
    {
        private List<Funcionario> _funcionario = new List<Funcionario>();

        public void CadastroFuncionario(Funcionario funcionario)
        {
            _funcionario.Add(funcionario);
        }

    }
}
