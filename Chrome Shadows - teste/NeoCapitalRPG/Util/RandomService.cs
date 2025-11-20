using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoCapitalRPG.Util
{
    public static class RandomService
    {
        private static Random _rnd = new Random();
        public static int Next(int min, int max) => _rnd.Next(min, max);
    }
}