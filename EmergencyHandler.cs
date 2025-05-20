using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        private FileLogger FL;
        private EmailAlert EA;
        private SmsAlert SA;

        public EmergencyHandler(FileLogger fl, EmailAlert ea, SmsAlert sa)
        {
            this.FL = fl;
            this.EA = ea;
            this.SA = sa;
        }
        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            FL.SendLog("log.txt", "EMERGENCY OCCURRED");
            EA.sendEmailAlert("admin@spaceagency.com", "Emergency triggered");
            SA.sendSmsAlert("054000000", "EMERGENCY");
        }

        public void AllRight()
        {
            Console.WriteLine("oxygen level is good");
            FL.SendLog("log.txt", "all rihgt");
            EA.sendEmailAlert("admin@spaceagency.com", "all rihgt");
            SA.sendSmsAlert("054000000", "all rihgt");
        }

        public void IsDangerous(int level)
        {
            if (level <= 20)
            {
                AllRight();
            }
            else
            {
                EmergencyShutdown();
            }
        }

    }
}
