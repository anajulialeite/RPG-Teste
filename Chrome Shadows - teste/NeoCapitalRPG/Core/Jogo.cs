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
            string[] introducao = {
                "O ano é 2147. A cidade Neo-Capital, construída sobre a antiga São Paulo,",
                "está mais populosa do que nunca. Isso a faz entrar em um ciclo inquebrável de violência.",
                "",
                "Megacorporações, controladas por donos sem rosto, ditam tudo:",
                "a comida, as informações… até o ar que você respira é monitorado.",
                "",
                "Não existem mais becos escuros, pois em cada esquina há um letreiro de neon",
                "tentando chamar sua atenção. Também não existem mais locais seguros:",
                "gangues cibernéticas extremamente violentas disputam o pouco de liberdade restante",
                "contra drones e droids mercenários da polícia.",
                "",
                "É aí que você entra: um(a) caçador(a) de créditos que, após mais uma briga",
                "genérica de bar, se vê preso em um dilema incomum.",
                "",
                "O problema? O mesmo dia se repete, sempre!",
                "",
                "Toda vez que o sol 'nasce', você desperta na mesma viela suja,",
                "com as mesmas oportunidades de luta.",
                "",
                "Talvez, se ficar forte o bastante, consiga abrir uma brecha e quebrar o ciclo..."
            };
            _menu.Obter(_jogador);


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
