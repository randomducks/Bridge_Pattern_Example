using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example
{
    class Keyboard : UserInputDevice
    {
        /// <summary>
        /// the computer the keyboard is attached to
        /// </summary>
        public Computer computer { get; set; }

        public Keyboard(Computer computer)
        {
            this.computer = computer;
        }

        public override void sendInput(string input)
        {
            this.computer.readInput(input);
        }
    }
}
