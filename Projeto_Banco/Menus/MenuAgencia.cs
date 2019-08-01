﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Banco.DadosBancario;

namespace Projeto_Banco.Menus
{
    class MenuAgencia
    {
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
            List<Agencia> agenciaCadastrada = new List<Agencia>();

            Agencia agencia = new Agencia();
           
            Console.WriteLine("Informe o codigo da agencia: ");
            agencia.CodigoAgencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da agência: ");
            agencia.NomeAgencia = Console.ReadLine();

            Console.WriteLine("Informe a cidade da agência: ");
            agencia.CidadeAgencia = Console.ReadLine();

            Console.WriteLine("Informe a UF: ");
            agencia.UfAgencia = Console.ReadLine();

            agenciaCadastrada.Add(agencia);
            Console.WriteLine("Agência cadastrada!!!");
            Console.Read();

            Console.WriteLine("Deseja retornar ao menu principal?\n F1 - SIM\n F2 - NAO");

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