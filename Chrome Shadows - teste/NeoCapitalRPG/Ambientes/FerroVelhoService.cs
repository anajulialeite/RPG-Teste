using NeoCapitalRPG.Model;
using NeoCapitalRPG.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Ambientes
{
    public class FerroVelhoService
    {
        private ArteService _arte;
        private CombateService _combate;
        private ArmaService _armas;

        public FerroVelhoService(ArteService arte, CombateService combate, ArmaService armas)
        {
            _arte = arte; _combate = combate; _armas = armas;
        }

        public void Executar(Personagem jogador)
        {
            Console.Clear();
            _arte.Exibir("ferro_velho");


            Console.WriteLine("═══ FERRO-VELHO ═══");
            Console.WriteLine("Você entra em um ferro-velho repleto de sucata tecnológica...");


            Inimigo drone = new Inimigo("Drone Policial Antigo", 30, 8, 10, 5);
            if (_combate.IniciarBatalha(jogador, drone))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você encontra peças úteis entre os destroços!");
                jogador.PecasColetadas++;
                jogador.GanharXP(drone.XPRecompensa);
                jogador.Creditos += drone.CreditosRecompensa;
                Console.ResetColor();
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
