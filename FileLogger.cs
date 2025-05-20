using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        public void SendLog(string file, string log)
        {
            File.WriteAllText(file, log);
        }
    }
}
