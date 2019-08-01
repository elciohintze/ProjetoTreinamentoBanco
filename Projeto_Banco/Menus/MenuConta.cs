using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    class MenuConta
    {
        public void MenuCadastroConta()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("           Cadastro de Conta             ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar nova conta\nF2 - Voltar   ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var teclaDigitada = Console.ReadKey();
        }
    }
}
