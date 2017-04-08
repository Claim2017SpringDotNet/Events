using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Welcomer
    {
        public Welcomer(LoginPrompt prompt)
        {
            LoginPrompt.NameDelegate del = PrintWelcome;
            prompt.NameEvent += del;
        }

        private void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
    }
}
