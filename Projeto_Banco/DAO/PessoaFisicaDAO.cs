using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
    public class PessoaFisicaDAO
    {
        private List<PessoaFisica> listaPf = new List<PessoaFisica>();

        public void CadastroPFisica(PessoaFisica pf)
        {
            listaPf.Add(pf);
        }
    }
}
