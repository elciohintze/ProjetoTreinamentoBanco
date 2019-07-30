using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    class MenuPrincipal
    {
        public void TelaInicial()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar Pessoa                    ");
            Console.WriteLine("F2 - Cadastrar Agencia                   ");
            Console.WriteLine("F3 - Cadastrar Conta bancaria            ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            var tipoCadastro = Console.ReadKey();
        }
    }
}
