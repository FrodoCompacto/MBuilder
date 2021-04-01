using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBuilder.Models
{
    class InputStatus
    {
        public Keyboard keyboard { get; set; }
        public Mouse mouse { get; set; }
        public int delay { get; set; }

        public InputStatus()
        {

        }

        public InputStatus(Mouse mouse, Keyboard keyboard, int delay)
        {
            this.keyboard = keyboard;
            this.mouse = mouse;
            this.delay = delay;
        }
    }
}
