using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmailAlert : IEmailAlert
    {
        public void sendEmailAlert(string email, string alert)
        {
            Console.WriteLine($"sending {alert} to {email}");
        }
    }
}
