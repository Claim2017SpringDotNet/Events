using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Alarm
    {
        private readonly IEnumerable<string> _badNames; 

        public Alarm(LoginPrompt prompt, IEnumerable<string> badNames)
        {
            LoginPrompt.NameDelegate del = this.MaybeSetOff;
            prompt.NameEvent += del;

            this._badNames = badNames;
        }

        private void MaybeSetOff(string name)
        {
            if (this._badNames.Contains(name))
            {
                Console.Beep(600, 800);
                ConsoleColor oldColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("WEE");
                Console.Beep(400, 800);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("WOO ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Beep(600, 800);
                Console.Write("WEE ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(400, 800);
                Console.Write("WOO! ");
                Console.ForegroundColor = oldColor;
                Console.WriteLine("Remain seated, {0}! The authorities are on their way.", name);
            }
        }

    }
}
