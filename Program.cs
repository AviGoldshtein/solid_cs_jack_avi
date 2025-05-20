using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmsAlert SA = new SmsAlert();
            BloodOxygen BO = new BloodOxygen();
            FileLogger FL = new FileLogger();
            EmailAlert EA = new EmailAlert();
            EmergencyHandler EH = new EmergencyHandler(FL, EA, SA);


            int level = BO.GetOxygenLevel();
            EH.IsDangerous(level);

        }
    }
}

