using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Servicos
{
    public class ArmaService
    {
        public void EscolherArma(Jogador jogador)
        {
            Console.Clear();
            Console.WriteLine("==== ESCOLHER ARMA ====");


            Console.WriteLine("1 - Cano de Ferro");
            Console.WriteLine("2 - Punhal");
            Console.WriteLine("3 - Cano Blindado");


            while (true)
            {
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();


                if (opcao == "1") { jogador.Arma = new Arma("Cano de Ferro", 5, "Improvisado, pesado"); break; }
                if (opcao == "2") { jogador.Arma = new Arma("Punhal", 3, "Rápido e silencioso"); break; }
                if (opcao == "3") { jogador.Arma = new Arma("Cano Blindado", 10, "Melhoria reforçada"); break; }


                Console.WriteLine("Opção inválida, tente novamente.");
            }
        }
    }
}
