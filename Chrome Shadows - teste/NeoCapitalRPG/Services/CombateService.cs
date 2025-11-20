using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Servicos
{
    public class CombateService
    {
        private Random _random = new Random();


        public bool IniciarBatalha(Personagem jogador, Inimigo inimigo)
        {
            Console.WriteLine($"═══ BATALHA INICIADA ═══");
            Console.WriteLine($"Você enfrenta: {inimigo.Nome}");
            Console.WriteLine($"HP do Inimigo: {inimigo.HP}");


            while (inimigo.HP > 0 && jogador.HP > 0)
            {
                Console.WriteLine($"Seu HP: { jogador.HP}/{ jogador.HPMaximo} | Inimigo HP: { inimigo.HP}");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender (reduz dano recebido pela metade)");
                Console.Write("Sua ação: ");
                string acao = Console.ReadLine();


                bool defendendo = false;


                if (acao == "1")
                {
                    int dano = _random.Next(jogador.AtaqueTotal() - 2, jogador.AtaqueTotal() + 3);
                    inimigo.HP -= dano;


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Você causa {dano} de dano!");
                    Console.ResetColor();


                    if (inimigo.HP <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{inimigo.Nome} foi derrotado!");
                        Console.ResetColor();
                        return true;
                    }
                }
            }
        }
    }
}