using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Model
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int HP { get; set; }
        public int Ataque { get; set; }
        public int CreditosRecompensa { get; set; }
        public int XPRecompensa { get; set; }


        public Inimigo(string nome, int hp, int ataque, int creditos, int xp)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            CreditosRecompensa = creditos;
            XPRecompensa = xp;
        }
    }
}