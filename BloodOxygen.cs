using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class BloodOxygen
    {
        private Random r = new Random();
        public int GetOxygenLevel()
        {
            int oxygenLevel = r.Next(0, 100);
            return oxygenLevel;
        }
    }
}
