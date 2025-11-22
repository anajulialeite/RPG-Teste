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
        // Resolve: "CombateService.IniciarBatalha(Personagem, Inimigo)": nem todos os caminhos de código retornam um valor
        // A função deve garantir que sempre retorne um valor (e.g., true se o jogador vencer, false se perder).
        public bool IniciarBatalha(Personagem jogador, Inimigo inimigo)
        {
            Console.WriteLine($"Batalha: {jogador.Classe} vs {inimigo.Genero}");

            // Lógica de combate (simplificada para resolver o erro)
            if (jogador.HP > 0 && inimigo.HP > 0)
            {
                // Implemente a lógica real...
                inimigo.HP -= 10;
                if (inimigo.HP <= 0)
                {
                    Console.WriteLine("Vitória!");
                    return true;
                }
            }

            // Retorno de falha ou fim do combate
            if (jogador.HP <= 0)
            {
                return false;
            }

            // Se o método pode chegar ao fim sem os 'if/else' acima, um retorno padrão é necessário.
            return true; // Retorno padrão para garantir todos os caminhos.
        }
    }
}