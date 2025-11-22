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
        public string Classe { get; set; }
        public string Genero { get; set; }
        public int HP { get; set; } = 100;
        public int XP { get; set; } = 0;
        public int CiclosCompletados { get; set; } = 0;
        public Arma ArmaEquipada { get; set; }

        // [Correção 1] Adiciona as propriedades PecasColetadas e Creditos
        public int PecasColetadas { get; set; } = 0;
        public int Creditos { get; set; } = 0;

        public Personagem(string classe, string genero)
        {
            this.Classe = classe;
            this.Genero = genero;
        }

        // [Correção 2] Adiciona o método GanharXP
        public void GanharXP(int quantidade)
        {
            this.XP += quantidade;
        }
    }
}