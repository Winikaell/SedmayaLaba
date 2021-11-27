//using ConsoleApp3.Lavrinenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lavrinenko
{
    class MynameException: Exception
    {
        public MynameException(string message) : base(message)
        { }
    }
}