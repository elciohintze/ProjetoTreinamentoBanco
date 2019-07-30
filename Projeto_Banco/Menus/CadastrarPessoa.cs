using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    class CadastrarPessoa
    {
      public void MenuCadastrarPessoa()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("          Cadastro de Pessoa             ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Deseja cadastrar pessoa fisica ou juridica");
            Console.WriteLine("F1 - Pessoa fisica\nF2 - Pessoa juridica");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var teclaDigitada = Console.ReadKey();
            List<DadosPessoa> lista = new List<DadosPessoa>();

            if (teclaDigitada.Key == ConsoleKey.F1)
            {
                DadosPessoa pessoa = new DadosPessoa();

                Console.WriteLine("Informe o ID");
                pessoa.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome: ");
                pessoa.Nome = Console.ReadLine();
                bool isValidCpf = false;
                while (!isValidCpf)
                {
                    Console.WriteLine("Informe o CPF: ");
                    var b = Console.ReadLine();
                    if (ValidaCPF.IsCpf(b))
                    {
                        pessoa.cpf = b;
                        isValidCpf = true;
                    }
                    else
                    {
                        Console.WriteLine("CPF Invalido! \n Por favor digite um CPF valido");
                    }
                }

                Console.WriteLine("Informe Data nascimento: \n");
                pessoa.dataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe o CEP: ");
                pessoa.cep = Console.ReadLine();

                Console.WriteLine("Informe o numero endereco");
                pessoa.numeroEndereco = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome da cidade: ");
                pessoa.cidade = Console.ReadLine();

                Console.WriteLine("Informe a UF: ");
                pessoa.UF = Console.ReadLine();

                pessoa.pessoaFisicaJuridica = "Pessoa juridica";

                lista.Add(pessoa);

                Console.WriteLine("Dados Salvos! Segue detalhes:");

            }
        }
    }
}
