using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example
{
    abstract class Computer
    {
        /// <summary>
        /// read input from an outside source
        /// </summary>
        public abstract void readInput(String input);
    }
}
