using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
using System.Windows.Forms;
using System.Timers;
using LogerLib;

namespace Tamagochi
{
    class Head
    {
        Timer timer;

        static Random random = new Random();
        
        Personag tamagochi ;
        
        Control_People myEvant;

        public Head()
        {
            myEvant = new Control_People();
            tamagochi = new Personag();
            
            timer = new Timer();
            timer.Elapsed += Foo;
            timer.Interval = 5000;
            LogerLib.Loger.WriteStream("Creat Timer");

        }

        private void Foo(object sender, ElapsedEventArgs e)
        {
            head();
            check(timer);
        }
        
        public void begin()
        {
            LogerLib.Loger.WriteStream("Add metod to event");

            myEvant.FuncEv += tamagochi.SleepEvent;
            myEvant.FuncEv += tamagochi.EatEvent;
            myEvant.FuncEv += tamagochi.GameEvent;
            myEvant.FuncEv += tamagochi.WalkEvent;
            timer.Start();

        }

        public  void head()
        {
            int rand = MyR.GetRandom(ref random);
            LogerLib.Loger.WriteStream("Start new Random");

            myEvant.Event_start(new Event_Tamagochi(rand));
       
            Console.Clear();
            Console.WriteLine($"My Walk   {tamagochi.Walk }\nMy Sleep   {tamagochi.Sleep}\n" +
                $"My Eat   {tamagochi.Eat}\nMy Game  {tamagochi.Game}\n\n");
        }
        public void check(Timer timer)
        {
            if (tamagochi.Eat == 0 || tamagochi.Game == 0 || tamagochi.Sleep == 0 || tamagochi.Walk == 0)
            {
                LogerLib.Loger.WriteStream("Sick");

                timer.Stop();

                DialogResult res = MessageBox.Show("I sick. To cure?", "Tamagochi", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {

                    Console.WriteLine("I am alive");
                    tamagochi.Eat = 3;
                    tamagochi.Game = 3;
                    tamagochi.Sleep = 3;
                    tamagochi.Walk = 3;
                    timer.Start();
                }
                else
                {
                    LogerLib.Loger.WriteStream("Died");


                    timer.Stop();
                    Console.WriteLine("Died");
                }
            }
        }
    }
}         
