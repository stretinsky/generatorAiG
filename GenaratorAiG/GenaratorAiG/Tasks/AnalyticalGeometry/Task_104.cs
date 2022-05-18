using System;
using LinearAlgebraAndCo;

namespace GenaratorAiG
{
    public class Task_104 : TaskTemplate
    {
        Random random = new Random();
        public Task_104()
        {
            Name = "Скалярное произведение";
            Description = "Пусть $ . Найти скалярное произведение векторов $ .";

            Vector a = Vector.GenerateRandomVector(2, random, -5, 5), b = Vector.GenerateRandomVector(2, random, -5, 5);
            Vector c = a - b;

            string condition = $"|\\vec{{a}}|=" + StringSqrt(a.ScalarProduct(a)) + $",|\\vec{{b}}|=" +
                StringSqrt(b.ScalarProduct(b)) + $",|\\vec{{a}}-\\vec{{b}}|=" + StringSqrt(c.ScalarProduct(c));
            taskLatex.Add(condition);

            int[] pm = new int[] { -1, 1 };
            int c0 = pm[random.Next(0, 1)] * random.Next(1, 5), c1 = pm[random.Next(0, 1)] * random.Next(1, 5),
                c2 = pm[random.Next(0, 1)] * random.Next(1, 5), c3 = pm[random.Next(0, 1)] * random.Next(1, 5);
            string question = "(" + Expression($"{c0}\\vec{{a}} + {c1}\\vec{{b}},") + 
                Expression($"{c2}\\vec{{a}} + {c3}\\vec{{b}}");
        }
        private string StringSqrt(int number)
        {
            double a = Math.Sqrt(number);
            if ((int)a == a)
            {
                return ((int)Math.Sqrt(number)).ToString();
            }
            return $"\\sqrt{{{number}}}";
        }
    }
}
