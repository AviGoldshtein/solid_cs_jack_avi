using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class SmsAlert : ISmsAlert
    {
        public void sendSmsAlert(string sms, string alert)
        {
            Console.WriteLine($"sending {alert} to {sms}");
        }
    }
}
