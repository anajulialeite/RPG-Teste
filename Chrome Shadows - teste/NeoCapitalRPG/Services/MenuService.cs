using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Servicos
{
    public class MenuService
    {
        private readonly ArteService _arte;
        private readonly AudioService _audio;
        private readonly ArmaService _armas;
        private readonly CombateService _combate;

        public MenuService(ArteService arte, AudioService audio, ArmaService armas, CombateService combate)
        {
            _arte = arte;
            _audio = audio;
            _armas = armas;
            _combate = combate;
        }

        public void CriarPersonagem(Personagem jogador)
        {
            Console.Clear();
            _arte.Exibir("personagem");

            Console.WriteLine("═══ CRIAÇÃO DE PERSONAGEM ═══");

            Console.Write("Digite o nome do seu caçador de créditos: ");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome)) nome = "Caçador";

            Console.WriteLine("Escolha o gênero: ");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");


            string genero = "";
            while (true)
            {
                Console.Write("Sua escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "1") { genero = "Masculino"; break; }
                else if (escolha == "2") { genero = "Feminino"; break; }
                else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Escolha inválida! Digite 1 ou 2."); Console.ResetColor(); }
            }

            jogador.Nome = nome;
            jogador.Genero = genero;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{ nome} foi criado com sucesso!");
            Console.ResetColor();

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}