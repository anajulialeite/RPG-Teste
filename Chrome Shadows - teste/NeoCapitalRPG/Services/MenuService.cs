using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Servicos
{
    public class MenuService
    {
        private ArteService _arte;
        private AudioService _audio;
        private ArmaService _armas;
        private CombateService _combate;

        // O construtor deve ter um corpo.
        // Assume-se que 'EscolherArmaMenu' era uma referência ao construtor de MenuService.
        public MenuService(ArteService arte, AudioService audio, ArmaService armas, CombateService combate)
        {
            _arte = arte;
            _audio = audio;
            _armas = armas;
            _combate = combate;
        }

        public void CriarPersonagem(Personagem jogador)
        {
            // Lógica de criação de personagem
        }

        // Resolve: ‘MenuService’ não contém uma definição para "Obter"
        public void Obter(Personagem jogador)
        {
            Console.WriteLine("Narrativa: Você obtém um item e segue em frente.");
            // Implementação do prólogo
        }

        // Resolve: ‘MenuService’ não contém uma definição para "MenuViela"
        public void MenuViela(Personagem jogador)
        {
            Console.WriteLine("\n[MENU VIELA] 1. Lutar 2. Explorar");
            // Lógica do menu
        }
    }
}