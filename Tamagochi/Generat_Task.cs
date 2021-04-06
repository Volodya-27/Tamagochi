//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Tamagochi;
//namespace Tamagochi
//{
//    class Generat_Task
//    {
//        private static Random random = new Random();
//        public delegate int Wanted();
//        public  Personag tamagochi;
//        public Wanted wanted;
//        public int zg;
//        private int for_random;
        
//        public  Generat_Task()
//        {
//            tamagochi = new Personag();
//            zg = 3;
//            eat();
//            sleep();
//            walk();
//            game();
//            health();
//        }

//        public int eat()
//        {
//            return tamagochi.Eat = zg;
//        }
//        public int walk()
//        {
//            return tamagochi.Walk = zg;
//        }
//        public int sleep()
//        {
//            return tamagochi.Sleep = zg;
//        }
//        public int game()
//        {
//            return tamagochi.Game = zg;
//        }
//        public int health()
//        {
//            return tamagochi.Health = 1;
//        }
//        public void add_delegate()
//        {
//            wanted = new Wanted(eat);

//            wanted += walk;
//            wanted += sleep;
//            wanted += game;
//        }

//        public string want_task()
//        {
//            add_delegate();
//            foreach (Wanted item in wanted.GetInvocationList())
//            {
//                Console.WriteLine(item());
//            }
//            for_random = Convert.ToInt32(MyR.GetRandom(ref random));
//            if (for_random == 1)
//            { return $"I want eat"; }
//            if (for_random == 2)
//            { return $"I want walk"; }
//            if (for_random == 3)
//            { return $"I want sleep"; }
//            if (for_random == 4)
//            { return $"I want game"; }
//            else return $"Not function";

//        }

//        public void Meesage()
//        {
//            Program.misMessegeBox++;

//            DialogResult res = MessageBox.Show(Convert.ToString(want_task()), "Tamagochi", MessageBoxButtons.OKCancel);
           
//            if (res == DialogResult.OK)
//            {
//                Console.WriteLine("You press Ok!");

//                if (for_random == 1&&tamagochi.Eat<zg)
//                    tamagochi.Eat += 1;
//                if (for_random == 2 && tamagochi.Walk<zg)
//                    tamagochi.Walk += 1;
//                if (for_random == 3 && tamagochi.Sleep<zg)
//                    tamagochi.Sleep += 1;
//                if (for_random == 4&&tamagochi.Game<zg)
//                    tamagochi.Game += 1;
//                Console.WriteLine($" {tamagochi.Eat}   {tamagochi.Walk}  {tamagochi.Game} {tamagochi.Sleep}");

//            }
//            else if (res == DialogResult.Cancel)
//            {
//                if (for_random == 1)
//                    tamagochi.Eat -= 1;
//                if (for_random == 2)
//                    tamagochi.Walk -= 1;
//                if (for_random == 3)
//                    tamagochi.Sleep -= 1;
//                if (for_random == 4)
//                    tamagochi.Game -= 1;
//                Console.WriteLine($" {tamagochi.Eat}   {tamagochi.Walk}  {tamagochi.Game} {tamagochi.Sleep}");
//            }
//        }
//        public bool Die()
//        {
//            if (tamagochi.Game == 0||tamagochi.Eat == 0|| tamagochi.Walk == 0|| tamagochi.Sleep == 0)
//                return true;
//            return false;
//        }
//        public bool Health()
//        {
//            DialogResult res = MessageBox.Show("I'm sick ", "Tamagochi", MessageBoxButtons.OKCancel);
//            if (res == DialogResult.Cancel)
//            {
//                tamagochi.Health = 0;
//                return true;
//            }
//            return false; 
//        }
//    }
//}
