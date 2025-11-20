using NeoCapitalRPG.Model;
using NeoCapitalRPG.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Ambientes
{
    public class MercadoService
    {
        private ArteService _arte;
        private CombateService _combate;
        private ArmaService _armas;

        public MercadoService(ArteService arte, CombateService combate, ArmaService armas)
        {
            _arte = arte; _combate = combate; _armas = armas;
        }

        public void Executar(Personagem jogador)
        {
            Console.Clear();
            _arte.Exibir("mercado");

            Console.WriteLine("═══ MERCADO ABANDONADO ═══");
            Inimigo gangster = new Inimigo("Membro Chrome Shadows", 45, 12, 25, 8);
            if (_combate.IniciarBatalha(jogador, gangster))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você saqueia os créditos do gangster!");
                jogador.GanharXP(gangster.XPRecompensa);
                jogador.Creditos += gangster.CreditosRecompensa;
                Console.ResetColor();
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
