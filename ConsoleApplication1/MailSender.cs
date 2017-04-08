using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MailSender
    {
        private IEnumerable<string> _badNames;
        public MailSender(LoginPrompt prompt, IEnumerable<string> badNames)
        {
            LoginPrompt.NameDelegate del = this.MaybeSendEmail;
            prompt.NameEvent += del;

            this._badNames = badNames;
        }

        private void MaybeSendEmail(string name)
        {
            if (this._badNames.Contains(name))
            {
                Console.WriteLine("Administration has been notified by email.");
            }
        }
    }
}
