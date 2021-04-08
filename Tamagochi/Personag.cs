using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi
{
    class Personag
    {
        //public string Name { get; set; }
        DialogResult res;
        public int Eat { get; set; }
        public int Walk { get; set; }
        public int Sleep { get; set; }
        public int Game { get; set; }
        public int Health { get; set; }
        public Personag()
        {
            res = 0;
            Game = Sleep = Walk= Eat = 3;
            Health = 1;
        }

        public void EatEvent(object sender, Event_Tamagochi action)
        {
            if (action.Action != 1) return;
            res = MessageBox.Show("I want eat", "Tamagochi", MessageBoxButtons.OKCancel);
            LogerLib.Loger.WriteStream("Eat");

            if (res == DialogResult.Cancel)
            {
                Eat -= 1;
            }
            else if (Eat < 3)
            {
                Eat += 1;
            }
        }
        public void GameEvent(object sender, Event_Tamagochi action)
        {
            if (action.Action != 2) return;

            res = MessageBox.Show("I want Game", "Tamagochi", MessageBoxButtons.OKCancel);
            LogerLib.Loger.WriteStream("Game");

            if (res == DialogResult.Cancel)
                Game -= 1;
            else if (Game < 3)
            {
                Game += 1;
            }
        }
        public void SleepEvent(object sender, Event_Tamagochi action)
        {
            if (action.Action != 3) return;

            res = MessageBox.Show("I want Sleep", "Tamagochi", MessageBoxButtons.OKCancel);
                LogerLib.Loger.WriteStream("Sleep");

            if (res == DialogResult.Cancel)
                Sleep -= 1;
            else if (Sleep < 3)
            {
                Sleep += 1;
            }
        }
        public void WalkEvent(object sender, Event_Tamagochi action)
        {
            if (action.Action != 4) return;

            res = MessageBox.Show("I want Walk", "Tamagochi", MessageBoxButtons.OKCancel);
                LogerLib.Loger.WriteStream("Walk");

            if (res == DialogResult.Cancel)
                Walk -= 1;
            else if (Walk < 3)
            {
                Walk += 1;
            }
        }
    }
}
