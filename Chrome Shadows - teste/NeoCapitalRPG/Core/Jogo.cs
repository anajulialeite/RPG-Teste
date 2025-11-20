using NAudio.Wave;
using NeoCapitalRPG.Helpers;
using NeoCapitalRPG.Model;
using NeoCapitalRPG.Servicos;
using System;
using System.Threading;

namespace NeoCapitalRPG.Core
{
    public class Jogo
    {
        private Personagem _jogador;
        private ArteService _arte;
        private AudioService _audio;
        private ArmaService _armas;
        private CombateService _combate;
        private MissoesService _missoes;
        private MenuService _menu;


        public Jogo()
        {
            _arte = new ArteService();
            _audio = new AudioService();
            _armas = new ArmaService();
            _combate = new CombateService();
            _missoes = new MissoesService();
            _menu = new MenuService(_arte, _audio, _armas, _combate);
        }


        public void Iniciar()
        {
            _arte.Exibir("titulo");


            // criação de personagem via menu
            _jogador = new Personagem("Caçador", "Masculino");
            _menu.CriarPersonagem(_jogador);


            _arte.Exibir("cidade");
            Console.WriteLine("═══ PRÓLOGO ═══");
            // exemplo de narrativa curta
            _menu.EscolherArmaInicial(_jogador);


            while (true)
            {
                _jogador.CiclosCompletados++;


                _menu.MenuViela(_jogador);


                if (_jogador.HP <= 0) { Console.WriteLine("Você morreu. Fim de jogo."); break; }
                if (_jogador.XP >= 100) { Console.WriteLine("Você rompeu o ciclo! Fim de jogo."); break; }
            }
        }
    }
}
