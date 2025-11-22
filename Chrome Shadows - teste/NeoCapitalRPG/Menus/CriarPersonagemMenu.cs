using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoCapitalRPG.Servicos;

namespace NeoCapitalRPG.Model
{
    internal class CriarPersonagemMenu
    {
        private readonly ArteService _arte;

        public CriarPersonagemMenu(ArteService arte)
        {
            _arte = arte;
        }

        public Personagem Executar()
        {
            Console.Clear();
            _arte.Exibir("personagem");

            Console.WriteLine("═══ CRIAÇÃO DE PERSONAGEM ═══\n");

            Console.Write("Digite o nome do seu caçador de créditos: ");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome)) nome = "Caçador";

            Console.WriteLine("\nEscolha o gênero:");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");

            string genero = "";
            while (true)
            {
                Console.Write("\nSua escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    genero = "Masculino";
                    break;
                }
                else if (escolha == "2")
                {
                    genero = "Feminino";
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha inválida! Digite 1 ou 2.");
                    Console.ResetColor();
                }
            }

            return new Personagem(nome, genero);
        }
    }
}
