using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_160
    {
        string description = "Найти расстояние:";
        int[] point = new int[3];
        int a, b, c, d;
        Random rnd = new Random();
        int sqrt, numerator;

        public Task_160()
        {
            point[0] = rnd.Next(-10, 10);
            point[1] = rnd.Next(-10, 10);
            point[2] = rnd.Next(-10, 10);

            a = rnd.Next(2, 30);
            b = rnd.Next(2, 30);
            c = rnd.Next(2, 30);
            d = rnd.Next(2, 30);

            numerator = Math.Abs(point[0] * a + point[1] * b + point[2] * c + d);
            sqrt = a * a + b * b + c * c;


        }
        public string GetDescription()
        {
            return description;
        }

        public string[] GetCondition()
        {
            string[] conditions = new string[1] { $"point ({point[0]};{point[1]};{point[2]})\\; to\\; flat\\; {a}x+{b}y+{c}z+{d}=0" };
            return conditions;
        }

        public string GetAnswer()
        {
            double between = Math.Sqrt(sqrt);

            if (Convert.ToInt32(between) == Math.Truncate(between) && (numerator / between) == Math.Truncate(numerator / between))
            {
                return $"{numerator / between}";
            }
            else if (between == Math.Truncate(between))
            {
                return $"\\frac{{{numerator}}}{{{between}}}";
            }
            else
            {
                return $"\\frac{{{numerator}}}{{ \\sqrt{{{sqrt}}} }}";
            }
        }
    }
}
