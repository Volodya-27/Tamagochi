using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public static class MyR
    {
        public static int GetRandom(ref Random random)
        {
            return random.Next(1, 5);
        }
    }
}
