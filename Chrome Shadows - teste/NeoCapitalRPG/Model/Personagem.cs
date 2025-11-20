using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Model
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int HP { get; set; }
        public int HPMaximo { get; set; }
        public int Ataque { get; set; }
        public int Creditos { get; set; }
        public int PecasColetadas { get; set; }
        public int XP { get; set; }
        public int CiclosCompletados { get; set; }
        public Arma ArmaEquipada { get; set; }


        public Personagem(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
            HPMaximo = 50;
            HP = HPMaximo;
            Ataque = 2;
            Creditos = 0;
            PecasColetadas = 0;
            XP = 0;
            CiclosCompletados = 0;
            ArmaEquipada = null;
        }


        public int AtaqueTotal()
        {
            return Ataque + (ArmaEquipada?.Bonus ?? 0);
        }


        public void GanharXP(int xp)
        {
            XP += xp;
        }


        public void ReceberDano(int dano)
        {
            HP -= dano;
            if (HP < 0) HP = 0;
        }
    }
}