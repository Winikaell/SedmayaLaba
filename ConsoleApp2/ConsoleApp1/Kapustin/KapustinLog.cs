using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Core;

namespace ConsoleApp1.Kapustin
{
    class KapustinLog : LogAbstract, LogInterface
    {
        private List<string> myLogs = new List<string>();

        private static KapustinLog instance;

        public static KapustinLog I()
        {
            if (instance == null)
                instance = new KapustinLog();
            return instance;
        }

        public LogInterface log(string str)
        {
            myLogs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(myLogs.ToArray());
            return this;
        }
    }
}

