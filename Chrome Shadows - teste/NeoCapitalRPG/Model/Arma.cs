using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Model
{
    public class Arma
    {
        public string Nome { get; set; }
        public int Bonus { get; set; }
        public string Descricao { get; set; }

        public Arma(string nome, int bonus, string descricao)
        {
            Nome = nome;
            Bonus = bonus;
            Descricao = descricao;
        }

        public Arma returnarArma(int decisao)
        {
            if (decisao == 1)
            {
                return new Arma("Cano de Ferro", 5, "Uma arma improvisada, pesada mas eficaz");
            }
            else if (decisao == 2)
            {
                return new Arma("Punhal", 3, "Rápido e silencioso, perfeito para ataques furtivos");
            }
            else if (decisao == 3)
            {
                return new Arma("Cano Blindado", 10, "Melhoramento do cano de ferro com peças coletadas");
            }
            else
            {
                return null;
            }
        }
    }
}
