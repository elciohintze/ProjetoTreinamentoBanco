using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    class PessoaJuridica
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public DateTime DtAbertura { get; set; }
        public string Logradouro { get; set; }
        public int NumeroLogradouro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
