using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NeoCapitalRPG.Model;

namespace NeoCapitalRPG.Servicos
{
    public class ArteService
    {
        private readonly string _pastaArte;

        public ArteService()
        {
            // Pasta onde ficam as artes (pode ajustar se estiver em outro local)
            _pastaArte = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AsciiArt");
        }

        /// <summary>
        /// Exibe uma arte ASCII pelo nome do arquivo (sem extensão).
        /// Exemplo: Exibir("personagem") → personagem.txt
        /// </summary>
        public void Exibir(string nomeArquivo, ConsoleColor cor = ConsoleColor.Cyan)
        {
            try
            {
                string caminho = Path.Combine(_pastaArte, $"{nomeArquivo}.txt");

                if (!File.Exists(caminho))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[ARTE NÃO ENCONTRADA] Arquivo: {caminho}");
                    Console.ResetColor();
                    return;
                }

                Console.ForegroundColor = cor;
                string arte = File.ReadAllText(caminho);
                Console.WriteLine(arte);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO AO CARREGAR ARTE:");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}

