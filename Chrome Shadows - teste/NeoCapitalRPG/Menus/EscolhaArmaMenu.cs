using NeoCapitalRPG.Model;
using NeoCapitalRPG.Servicos;
using System.Collections.Generic;
using System;

namespace NeoCapitalRPG.Menus
{
    public class EscolherArmaMenu
    {
        // Torna os campos somente leitura (readonly) para seguir a boa prática (Boa Prática)
        private readonly ArteService _arte;
        private readonly AudioService _audio;

        // [CORREÇÃO 1] O construtor deve ter um corpo ({}) para as atribuições
        public EscolherArmaMenu(ArteService arte, AudioService audio)
        {
            _arte = arte;
            _audio = audio;
        } // Adicionado o fechamento do bloco do construtor

        public void Executar(Personagem jogador)
        {
            Console.Clear();
            _arte.Exibir("armas");

            Console.WriteLine("═══ ESCOLHA SUA ARMA ═══\n");

            // Chamada ao método estático em Arma, que deve retornar List<Arma>
            var armas = Arma.ObterArmasIniciais();

            // Se o método ObterArmasIniciais retornar menos de 2 armas, o código pode falhar.
            // Para segurança, vamos garantir que a lista tem itens antes de acessar os índices.
            if (armas == null || armas.Count == 0)
            {
                Console.WriteLine("Nenhuma arma inicial disponível.");
                // Retorna para evitar erros de índice
                return;
            }

            // Exibir todas as armas disponíveis
            for (int i = 0; i < armas.Count; i++)
            {
                // Garante que o índice existe
                if (i < armas.Count)
                {
                    Console.WriteLine($"{i + 1} - {armas[i].Nome}");
                }
            }


            while (true)
            {
                Console.Write("\nSua escolha: ");
                string escolha = Console.ReadLine();

                // Usamos TryParse e verificamos o limite da lista.
                if (int.TryParse(escolha, out int indice) && indice >= 1 && indice <= armas.Count)
                {
                    // Atribui a arma ao jogador
                    jogador.ArmaEquipada = armas[indice - 1];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nVocê equipou: {jogador.ArmaEquipada.Nome}");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Escolha inválida! Digite um número entre 1 e {armas.Count}.");
                    Console.ResetColor();
                }
            }
        }
    }
}