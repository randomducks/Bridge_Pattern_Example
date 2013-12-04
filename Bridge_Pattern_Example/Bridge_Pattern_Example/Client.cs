using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example
{
    class Client
    {
        public static void Main(string[] args)
        {
            // copy and paste on a mac
            Computer mac = new Mac();
            UserInputDevice macKeyboard = new Keyboard(mac);
            macKeyboard.sendInput("command-c");
            macKeyboard.sendInput("command-v");

            // copy and paste on a pc
            Computer pc = new PC();
            UserInputDevice pcKeyboard = new Keyboard(pc);
            pcKeyboard.sendInput("control-c");
            pcKeyboard.sendInput("control-v");

            Console.ReadKey();
        }
    }
}
