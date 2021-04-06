using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi
{
   
    class Event_Tamagochi: EventArgs
    {
        public int Action { get; private set; }
        public Event_Tamagochi(int a )
        {
            Action = a;
        }

    }
}
