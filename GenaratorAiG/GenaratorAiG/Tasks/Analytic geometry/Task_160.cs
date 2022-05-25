using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_160: ITask
    {
        string description = "Найти расстояние от точки $ до плоскости $";
        int[] point = new int[3];
        int a, b, c, d;
        int sqrt, numerator;
        
        public Task_160(Random rnd)
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

        public List<string> GetCondition()
        {
            string condition = $"A({point[0]};{point[1]};{point[2]})";
            List<string> formules = new List<string>();
            formules.Add(condition);
            formules.Add($"{a}x+{b}y+{c}z+{d}=0");
            return formules;
        }

        public List<string> GetAnswer()
        {
            double between = Math.Sqrt(sqrt);
            string result;
            if (Convert.ToInt32(between) == Math.Truncate(between) && (numerator / between) == Math.Truncate(numerator / between))
            {
                result = $"{numerator / between}";
            }
            else if (between == Math.Truncate(between))
            {
                result = $"\\frac{{{numerator}}}{{{between}}}";
            }
            else
            {
                result = $"\\frac{{{numerator}}}{{ \\sqrt{{{sqrt}}} }}";
            }
            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }
    }
}
