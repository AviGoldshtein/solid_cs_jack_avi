﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void SendLog(string db, string log)
        {
            Console.WriteLine($"sending {log} to {db}");
        }
    }
}
