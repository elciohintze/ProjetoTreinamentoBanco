using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
   public class MenuPrincipal
    {
        public void TelaInicial()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar Pessoa Fisica             ");
            Console.WriteLine("F2 - Cadastrar Pessoa Juridica           ");
            Console.WriteLine("F3 - Cadastrar Agencia                   ");
            Console.WriteLine("F4 - Cadastrar Conta bancaria            ");
            Console.WriteLine("F5 - Cadastrar Funcionario               ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            var tipoCadastro = Console.ReadKey();

            switch (tipoCadastro.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    MenuCadastrarPFisica pf = new MenuCadastrarPFisica();
                    pf.MenuCadastrarPessoaFisica();
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    MenuCadastrarPJuridica pj = new MenuCadastrarPJuridica();
                    pj.MenuCadastrarPessoaJuridica();
                    break;

                case ConsoleKey.F3:
                    Console.Clear();
                    MenuAgencia a = new MenuAgencia();
                    a.MenuCadastroAgencia();
                    break;

                case ConsoleKey.F4:
                    Console.Clear();
                    MenuConta c = new MenuConta();
                    c.MenuCadastroConta();
                    break;

                case ConsoleKey.F5:
                    Console.Clear();
                    MenuFuncionario cf = new MenuFuncionario();
                    cf.MenuCadastrarFuncionario();
                    
                    break;

                default:
                    Console.WriteLine("A Opção informada é invalida!\n Por favor informe uma opção valída");
                    Console.Read();
                    break;
            }

            //Cadastro(tipoCadastro);
        }
    }
}
