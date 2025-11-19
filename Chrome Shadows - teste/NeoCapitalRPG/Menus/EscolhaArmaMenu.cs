using NeoCapitalRPG.Model;
using NeoCapitalRPG.Servicos;
using System;

namespace NeoCapitalRPG.Menus
{
    public class EscolherArmaMenu
    {
        private readonly ArteService _arte;
        private readonly AudioService _audio;

        public EscolherArmaMenu(ArteService arte, AudioService audio)
        {
            _arte = arte;
            _audio = audio;
        }

        public void Executar(Personagem jogador)
        {
            Console.Clear();
            _arte.Exibir("armas");

            Console.WriteLine("═══ ESCOLHA SUA ARMA ═══\n");

            var armas = Arma.ObterArmasIniciais(); // ← Agora vem da classe Arma.cs

            Console.WriteLine("1 - " + armas[0].Nome);
            Console.WriteLine("2 - " + armas[1].Nome);

            while (true)
            {
                Console.Write("\nSua escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "1" || escolha == "2")
                {
                    jogador.ArmaEquipada = armas[int.Parse(escolha) - 1];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nVocê equipou: {jogador.ArmaEquipada.Nome}");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha inválida! Digite 1 ou 2.");
                    Console.ResetColor();
                }
            }

            _audio.PararMusica();
        }
    }
}
