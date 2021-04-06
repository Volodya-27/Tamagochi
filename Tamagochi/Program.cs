using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading;
using System.Drawing;

namespace Tamagochi
{
    class Program
    {       
        static void Main(string[] args)
        {
            Head head = new Head();
            head.begin();
            Console.ReadKey();
        }
    }
}
