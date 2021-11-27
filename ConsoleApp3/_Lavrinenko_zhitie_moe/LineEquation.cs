using ConsoleApp3.Lavrinenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.zhitie_moe
{
    class LineEquations
    {
        protected double x = 0;
        protected double LineEquation(double a, double b)
        {
            if (a == 0) throw new MynameException("Определено, что это не линейное уравнение!");
            AlexeyLog.I().log("Определено, что это линейное уравнение");
            return x = -b / a;
        }
    }
}
