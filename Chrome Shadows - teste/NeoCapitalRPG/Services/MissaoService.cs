using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Servicos
{
    public class MissoesService
    {
        public void MostrarMissoes()
        {
            Console.Clear();
            Console.WriteLine("═══ MISSÕES ═══");
            Console.WriteLine("No momento não há missões ativas.");
            Console.WriteLine("Pressione ENTER para voltar.");
            Console.ReadLine();
        }
    }
}