using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Kapustin
{
    class B
    {
        protected List<float> x;
        public List<float> LinearEquation(float a, float b)
        {
            if (a == 0)
            {
                throw new KapustinException("Невозможное уравнение");
            }

            KapustinLog.I().log("Это линейное уравнение");
            return x = new List<float>() { -b / a };
        }

    }
}
