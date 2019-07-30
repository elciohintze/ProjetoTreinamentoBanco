using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    class MenuCadastrarPJuridica
    {
        public void CadastrarPessoaJuridica()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("      Cadastro de Pessoa Juridica        ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar nova Pessoa juridica\nF2 - Voltar");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var teclaDigitada = Console.ReadKey(); 

            if (teclaDigitada.Key == ConsoleKey.F1)
            {


                PessoaJuridica pj = new PessoaJuridica();
                List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

                Console.WriteLine("Informe o ID");
                pj.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a razão social: ");
                pj.RazaoSocial = Console.ReadLine();

                Console.WriteLine("Informa o nome fantasia: ");
                pj.NomeFantasia = Console.ReadLine();

                bool isValidCnpj = false;
                while (!isValidCnpj)
                {
                    Console.WriteLine("Informe o CNPJ: ");
                    var cnpjDigitado = Console.ReadLine();
                    if (ValidaCNPJ.IsCnpj(cnpjDigitado))
                    {
                        pj.Cnpj = cnpjDigitado;
                        isValidCnpj = true;
                    }
                    else
                    {
                        Console.WriteLine("CNPJ Invalido! \n Por favor digite um CNPJ valido");
                    }
                }

                Console.WriteLine("Informe Data abertura: \n");
                pj.DtAbertura = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe o logradouro: ");
                pj.Logradouro = Console.ReadLine();

                Console.WriteLine("Informe o numero do logradouro: ");
                pj.NumeroLogradouro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome da cidade: ");
                pj.Cidade = Console.ReadLine();

                Console.WriteLine("Informe a UF: ");
                pj.Uf = Console.ReadLine();

                listaPj.Add(pj);

                Console.WriteLine("Dados Salvos! Segue detalhes:");

            }
        }
    }
}
