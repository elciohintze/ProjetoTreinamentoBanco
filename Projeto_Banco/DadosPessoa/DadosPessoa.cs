using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
     class DadosPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }

        public string cnpj { get; set; }

        public string cidade { get; set; }

        public string UF { get; set; }

        public DateTime dataNascimento { get; set; }

        public int NumeroEndereco { get; set; }

        public string pessoaFisicaJuridica { get; set; }

    }
}
