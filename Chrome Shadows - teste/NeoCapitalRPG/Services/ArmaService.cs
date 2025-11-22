using System.Collections.Generic;
using NeoCapitalRPG.Model; 
using System;

namespace NeoCapitalRPG.Servicos
{
    public class ArmaService
    {
        // Este método não é mais o principal para escolher arma, 
        // mas é ajustado para consistência.
        public void EscolherArma(Personagem jogador)
        {
            Console.Clear();
            Console.WriteLine("==== ESCOLHER ARMA ====");

            Console.WriteLine("1 - Cano de Ferro (Dano: 5, Durabilidade: 50)");
            Console.WriteLine("2 - Punhal (Dano: 3, Durabilidade: 30)");
            Console.WriteLine("3 - Cano Blindado (Dano: 10, Durabilidade: 100)");

            while (true)
            {
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    // [CORREÇÃO] Usa ArmaEquipada
                    jogador.ArmaEquipada = new Arma("Cano de Ferro", 5, 50);
                    break;
                }
                if (opcao == "2")
                {
                    // [CORREÇÃO] Usa ArmaEquipada
                    jogador.ArmaEquipada = new Arma("Punhal", 3, 30);
                    break;
                }
                if (opcao == "3")
                {
                    // [CORREÇÃO] Usa ArmaEquipada
                    jogador.ArmaEquipada = new Arma("Cano Blindado", 10, 100);
                    break;
                }

                Console.WriteLine("Opção inválida, tente novamente.");
            }
        }
    }
}