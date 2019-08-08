using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Banco.DadosPessoa;
using Projeto_Banco.DAO;
using Projeto_Banco.Menus;

namespace Projeto_Banco.Menus
{
    public class MenuFuncionario : IMenu
    {
        private FuncionarioDAO _funcionarioDAO = new FuncionarioDAO();

        public void MenuCadastrar()
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
                    Cadastrar();
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.TelaInicial();
                    break;
            }
        }

        public void Cadastrar()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("CADASTRANDO FUNCIONARIO");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Informe o ID");
            funcionario.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome: ");
            funcionario.Nome = Console.ReadLine();

            bool isValidCpf = false;
            while (!isValidCpf)
            {
                Console.WriteLine("Informe o CPF: ");
                var cpfDigitado = Console.ReadLine();
                if (ValidaCPF.IsCpf(cpfDigitado))
                {
                    funcionario.Cpf = cpfDigitado;
                    isValidCpf = true;
                }
                else
                {
                    Console.WriteLine("CNPJ Invalido! \n Por favor digite um CNPJ valido");
                }
            }

            Console.WriteLine("Informe a data de nascimento: ");
            funcionario.DtNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe o logradouro: ");
            funcionario.Logradouro = Console.ReadLine();

            Console.WriteLine("Informe o numero do logradouro: ");
            funcionario.NumeroLogradouro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.WriteLine("Informe a UF: ");
            funcionario.Uf = Console.ReadLine();

            Console.WriteLine("Informe a data de admissão");
            funcionario.DtAdminissao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a função desempenhada: ");
            funcionario.Funcao = Console.ReadLine();

            Console.WriteLine("Informe o salario: ");
            funcionario.Salario = Convert.ToDouble(Console.ReadLine());
            _funcionarioDAO.CadastroFuncionario(funcionario);

            Console.Clear();

            Console.WriteLine("O Funcionario " + funcionario.Nome + " foi cadastrado com sucesso!\n\n\n");

            

            Console.WriteLine("Deseja retornar ao menu de cadastro?\n F1 - SIM\n F2 - NAO");

            var novoCadastro = Console.ReadKey();
            switch (novoCadastro.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    MenuCadastrar();
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
