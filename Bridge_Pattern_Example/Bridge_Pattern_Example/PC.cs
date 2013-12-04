using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example
{
    class PC : Computer
    {
        public override void readInput(string input)
        {
            if (input.Equals("control-c"))
            {
                this.copyText();
            }
            else if (input.Equals("control-v"))
            {
                this.pasteText();
            }
            else
            {
                // the input isn't recognized, so do nothing
            }
        }
        public void copyText()
        {
            Console.Out.WriteLine("Text copied on a PC");
        }

        public void pasteText()
        {
            Console.Out.WriteLine("Text pasted on a PC");
        }
    }
}
