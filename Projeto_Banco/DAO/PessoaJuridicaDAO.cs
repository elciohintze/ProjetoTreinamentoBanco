using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.DAO
{
    public class PessoaJuridicaDAO
    {
        private List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

        public void CadastroPJuridica(PessoaJuridica pj)
        {
            listaPj.Add(pj);
        }
    }
}
