using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Banco.DadosBancario;
using Projeto_Banco.DAO;

namespace Projeto_Banco.Menus
{
    class MenuAgencia
    {
        private AgenciaDAO _agenciaDAO = new AgenciaDAO();
        public void MenuCadastroAgencia()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("         Cadastro de Agência             ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("F1 - Cadastrar nova agência\nF2 - Voltar ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var teclaDigitada = Console.ReadKey();

            switch (teclaDigitada.Key)
            {
                case ConsoleKey.F1:
                    CadastrarAgencia();
                    break;

                case ConsoleKey.F2:

                    Console.Clear();
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.TelaInicial();
                    break;
            }
        }

        public void CadastrarAgencia()
        {
            Console.Clear();            

            Agencia agencia = new Agencia();
           
            Console.WriteLine("Informe o codigo da agencia: ");
            agencia.CodigoAgencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da agência: ");
            agencia.NomeAgencia = Console.ReadLine();

            Console.WriteLine("Informe a cidade da agência: ");
            agencia.CidadeAgencia = Console.ReadLine();

            Console.WriteLine("Informe a UF: ");
            agencia.UfAgencia = Console.ReadLine();

            _agenciaDAO.CadastroAgencia(agencia);

            Console.WriteLine("Agência cadastrada!!!");

            Console.WriteLine("Deseja retornar ao menu de cadastro?\n F1 - SIM\n F2 - NAO");

            var novoCadastro = Console.ReadKey();
            switch (novoCadastro.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    MenuCadastroAgencia();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.TelaInicial();
                    break;
            }
            
            

        }
    }
}
