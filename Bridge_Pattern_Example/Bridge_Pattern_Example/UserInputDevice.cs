using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example
{
    abstract class UserInputDevice
    {
        /// <summary>
        /// sends input from the device
        /// </summary>
        /// <param name="input"></param>
        public abstract void sendInput(String input);
    }
}
