using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Model
{
    public class Inimigo : Personagem
    {
        // Adiciona uma propriedade Dano para o combate
        public int Dano { get; set; }

        // [Correção 3] Adiciona as propriedades de recompensa
        public int XPRecompensa { get; set; }
        public int CreditosRecompensa { get; set; }

        // [Correção 4] Construtor que aceita 5 argumentos
        public Inimigo(string nome, int hp, int dano, int xpRecompensa, int creditosRecompensa)
            : base(nome, "Inimigo") // Chama o construtor base (Personagem)
        {
            this.HP = hp;
            this.Dano = dano;
            this.XPRecompensa = xpRecompensa;
            this.CreditosRecompensa = creditosRecompensa;
        }

        // Construtor com 2 argumentos (mantido do exemplo anterior)
        public Inimigo(string nome, int hp) : base(nome, "Inimigo")
        {
            this.HP = hp;
        }
    }
}