using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Banco.DadosBancario;
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

            switch (teclaDigitada.Key)
            {
                case ConsoleKey.F1:
                    //chamar metodo de cadastro
                    
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.TelaInicial();
                    break;
            }
        }

        public void CadastrarConta()
        {
            List<Conta> contas = new List<Conta>();
            Conta conta = new Conta();

            Console.WriteLine("Informe o codigo da agência");
            conta.AgenciaConta = Convert.ToInt32(Console.ReadLine()); //deve validar se existe

            Console.WriteLine("Informe o codigo do cliente");
            conta.IdPessoa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o saldo da conta: ");
            conta.SaldoConta = Convert.ToInt32(Console.ReadLine());

            conta.DataAberturaConta = DateTime.Now;
            contas.Add(conta);

        }
    }
}
