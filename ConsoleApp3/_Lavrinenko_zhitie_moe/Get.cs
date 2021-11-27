using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Get
    {
        public double number()
        {
            try
            {
                return Convert.ToDouble(Console.ReadKey());
            }
            catch { return number(); }
        }
    }
}
