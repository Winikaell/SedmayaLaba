using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using core;
namespace ConsoleApp3.Lavrinenko
{
    class AlexeyLog : LogAbstract, LogInterface
    {
        private static AlexeyLog single = null;
        public static AlexeyLog I()
        {
            if (single == null)
            {
                single = new AlexeyLog();
            }
            return single;
        }
        List<string> mass = new List<string>();
        public LogInterface log(string str)
        {
            mass.Add(str);
            return this;
        }

        public LogInterface write()
        {
            Console.Write(mass.ToArray());
            return this;
        }
    }
}