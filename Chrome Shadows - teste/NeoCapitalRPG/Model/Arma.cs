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
        public List<Arma> ObterArmasIniciais()
        {
            return Arma.ObterArmasIniciais();
        }


        public Arma ObterMelhoramento(Arma atual)
        {
            // lógica simples: se for Cano de Ferro -> Cano Blindado
            if (atual == null) return null;
            if (atual.Nome.Contains("Cano de Ferro"))
                return new Arma("Cano Blindado", 10, "Melhoramento do cano de ferro com peças coletadas");


            return atual;
        }
    }
}