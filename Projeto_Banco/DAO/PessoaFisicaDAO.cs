using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
    public class PessoaFisicaDAO
    {
        private List<PessoaFisica> _listaPf = new List<PessoaFisica>();

        public void CadastroPFisica(PessoaFisica pf)
        {
            _listaPf.Add(pf);
        }
    }
}
