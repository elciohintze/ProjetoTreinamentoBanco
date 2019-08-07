using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Banco.Menus;

namespace Projeto_Banco.Menus
{
    class MenuFuncionario
    {
        public void MenuCadastrarFuncionario()
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

            switch (opcaoSelecionada.Key)
            {
                case ConsoleKey.F1:

                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.TelaInicial();
                    break;

            }
        }

        public void NovoCadastroFuncionario()
        {

        }
    }
}
