using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Kapustin;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            KapustinLog logger = KapustinLog.I();

            Console.WriteLine("Введите a, b и с");

            List<float> arg = new List<float>(3);

            for (int i = 0; i < 3; i++)
            {
                arg.Add(float.Parse(Console.ReadLine()));
            }

            logger.log($"{arg[0]}x^2 + {arg[1]}x + {arg[2]}");

            A b = new A();

            try
            {
                logger.log("Корни уравнения: " + string.Join(", ", b.solve(arg[0], arg[1], arg[2]).ToArray()));
            }
            catch (KapustinException e)
            {
                logger.log(e.Message);
            }

            logger.write();
            Console.ReadKey();

        }
    }
}
