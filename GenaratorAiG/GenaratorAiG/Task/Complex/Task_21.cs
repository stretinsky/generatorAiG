using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Task.Complex
{
    class Task_21
    {
        string description = "Используя формулу (22), найти все значения \\oldsqrt[n]{w}, если:";
        private double a, b, r, f;
        private int index,n;
        private double[] trigonometry = new double[] { Math.PI / 3, Math.PI / 4, Math.PI / 5, Math.PI / 6, Math.PI / 7, Math.PI / 8, Math.PI / 9, Math.PI / 10 };
        private int[] array_f = new int[] { 173, 100, 72, 57, 48, 41, 36, 32 };
        public Task_21()
        {
            Random rnd = new Random();
            index = rnd.Next(0,8);
            n = rnd.Next(1, 10);
            double i = Math.Round(rnd.NextDouble(), 2);
            f = trigonometry[index];
            a = array_f[index] * i;
            b = 100 * i;
            r = Math.Round(Math.Pow(a * a + b * b,(double) 1 / n),3);
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"{a} + {b}*i";
        }
        public string GetAnswer()
        {
            string s;
            if (r!= 1)
              s = $"{r}e^(\\frac{{\\pi}}{{{n * index}}} + \\frac{{{2}\\pi}}{{{n}}})";
            else
              s = $"e^(\\frac{{\\pi}}{{{n * index}}} + \\frac{{{2}\\pi}}{{{n}}})";
            return s;
        }
    }
}
