using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Control_People
    {
        public event Action<object, Event_Tamagochi> FuncEv;

        public void Event_start(Event_Tamagochi event_Tamagochi)
        {
            FuncEv(this,event_Tamagochi);
        }

       

    }
}
