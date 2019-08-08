using Projeto_Banco.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco.Menus
{
    public class MenuCadastrarPFisica : IMenu
    {
        private PessoaFisicaDAO _pessoaFisicaDAO = new PessoaFisicaDAO();
       
        public void MenuCadastrar()
        {

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("      Cadastro de Pessoa Fisica          ");
            Console.WriteLine("----------------------------------- ------");
            Console.WriteLine("F1 - Cadastrar nova Pessoa fisica\nF2 - Voltar");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 MyBank                  ");
            Console.WriteLine("-----------------------------------------");

            var teclaDigitada = Console.ReadKey();

            switch (teclaDigitada.Key)
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
            PessoaFisica pf = new PessoaFisica();

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("CADASTRANDO PESSOA FISICA");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Informe o ID");
            pf.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome: ");
            pf.Nome = Console.ReadLine();

            bool isValidCpf = false;
            while (!isValidCpf)
            {
                Console.WriteLine("Informe o CPF: ");
                var cpfDigitado = Console.ReadLine();
                if (ValidaCPF.IsCpf(cpfDigitado))
                {
                    pf.Cpf = cpfDigitado;
                    isValidCpf = true;
                }
                else
                {
                    Console.WriteLine("CNPJ Invalido! \n Por favor digite um CNPJ valido");
                }
            }

            Console.WriteLine("Informe a data de nascimento: \n");
            pf.DtNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe o logradouro: ");
            pf.Logradouro = Console.ReadLine();

            Console.WriteLine("Informe o numero do logradouro: ");
            pf.NumeroLogradouro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da cidade: ");
            pf.Cidade = Console.ReadLine();

            Console.WriteLine("Informe a UF: ");
            pf.Uf = Console.ReadLine();
            _pessoaFisicaDAO.CadastroPFisica(pf);
        }
    }
}
