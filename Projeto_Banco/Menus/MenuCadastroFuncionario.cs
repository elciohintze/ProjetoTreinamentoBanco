using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    class MenuCadastroFuncionario
    {
       public void MenuCadastrarPessoaFisica()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("        Cadastro de Funcionario          ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar novo Funcionario\nF2 - Voltar");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var opcaoSelecionada = Console.ReadKey();
        }
    }
}
