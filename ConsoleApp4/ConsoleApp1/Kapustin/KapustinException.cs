using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Kapustin
{
    class KapustinException : Exception
    {
        public KapustinException(string message) : base(message) { }
    }
}
