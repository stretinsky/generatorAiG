using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    class Task_12:Task
    {
        private readonly string description = "Представить в тригонометрической форме следующие комплексные числа";
        private readonly double cos, sin;
        private readonly double a, b, r, z;
        private readonly double[] deis = new double[] { 1, 2, 3, 4, -1, -2, -3, -4, 0, 2 ^ (1 / 2), 3 ^ (1 / 2) };
        private readonly double[] mnim = new double[] { 1, 2, 3, 4, -1, -2, -3, -4, 0, 2 ^ (1 / 2), 3 ^ (1 / 2) };
        public Task_12()
        {

            Random rnd = new Random();
            double i = (-1) ^ 2;
            double a = deis[rnd.Next(11)];
            b = mnim[rnd.Next(11)];
            cos = a / r;
            sin = b / r;
            r = Math.Round(Math.Sqrt(a * a + b * b));
            z = r * (Math.Cos(cos) + i * (Math.Sin(sin)));
            taskLatex.Add($"{a} + {b}i");
            AnswerLatex += $"{z}";

        }
        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"{a} + {b}i";
        }
        public string GetAnswer()
        {
            return $"{z}";
        }
    }
}
