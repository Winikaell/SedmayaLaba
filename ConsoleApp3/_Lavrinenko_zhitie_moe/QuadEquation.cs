using ConsoleApp3.Lavrinenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.zhitie_moe
{
    class QuadEquations: LineEquations, EquationInterface
    {
        protected double x2;
        public List<double> solve(double a, double b, double c)
        {
                List<double> ArrX = new List<double>();
                if (a == 0)
                {
                    ArrX.Add(LineEquation(b, c));
                }
                double desk = DesCream(a, b, c);
                if (desk == 0)
                {
                x = -(b / (2 * a));
                }
                if (desk > 0)
                {
                    
                    x = (-b + Math.Sqrt(desk)) / (2 * a);
                    x2 = (-b - Math.Sqrt(desk)) / (2 * a);
                    ArrX.Add(x);
                    ArrX.Add(x2);
                }
                else
                {
                    
                    throw new MynameException("Ошибка: уравнение не имеет решений!");
                    //корней нет 
                }
            AlexeyLog.I().log("Определено, что это квадратное уравнение");
            AlexeyLog.I().log("Корни уравнения:"+ArrX.ToArray());
                return ArrX;
        }
        protected double DesCream(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
