using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedNames = new List<string> { "Jack", "Steven", "Mathew" };

            var loginPrompt = new LoginPrompt();
            var welcomer = new Welcomer(loginPrompt);
            var alarm = new Alarm(loginPrompt, bannedNames);
            var mailSender = new MailSender(loginPrompt, bannedNames);
            loginPrompt.PromptUserAndGetName();
            


            Console.ReadKey();
        }
    }
}
