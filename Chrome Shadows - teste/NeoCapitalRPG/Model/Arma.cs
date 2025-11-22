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
        public int Dano { get; set; }
        public int Durabilidade { get; set; }

        public Arma() { }

        public Arma(string nome, int dano, int durabilidade)
        {
            this.Nome = nome;
            this.Dano = dano;
            this.Durabilidade = durabilidade;
        }

        // [CORREÇÃO] Adiciona o método estático ObterArmasIniciais, que estava faltando.
        public static List<Arma> ObterArmasIniciais()
        {
            // Retorna as armas iniciais que o menu precisa
            return new List<Arma>
            {
                new Arma("Punho de Ferro", 5, 50),
                new Arma("Faca de Sobrevivência", 3, 30),
                new Arma("Cano Blindado", 10, 100)
            };
        }
    }
}