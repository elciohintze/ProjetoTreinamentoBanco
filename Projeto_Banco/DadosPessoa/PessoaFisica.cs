using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Logradouro { get; set; }
        public int NumeroLogradouro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
