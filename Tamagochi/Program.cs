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
using LogerLib;
namespace Tamagochi
{
    class Program
    {       
        static void Main(string[] args)
        {
            LogerLib.Loger.WriteStream("Start Program");
            Head head = new Head();
            head.begin();
            Console.ReadKey();
        }
    }
}
