using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class LoginPrompt
    {
        public delegate void NameDelegate(string name);

        public event NameDelegate NameEvent;

        public void PromptUserAndGetName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            NameEvent?.Invoke(name);
            
        }
        
    }
}
