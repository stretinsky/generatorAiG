using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime;
using Fractions;

namespace GenaratorAiG.Tasks.Complex
{
    class Task_13546
    {
        string desription = "Вычислите сумму";
        Fraction frac1, frac2, answer;
        Random r = new Random();
        public Task_13546()
        {
            frac1 = new Fraction(r.Next(10), r.Next(1, 10));
            frac2 = new Fraction(r.Next(10), r.Next(1, 10));
            answer = frac1 + frac2;
        }
        public string GetDescription()
        {
            return desription;
        }
        public string GetCondition()
        {
            return "\\frac{" + frac1.Numerator + "}{" + frac1.Denominator + "} + \\frac{" + frac2.Numerator + "}{" + frac2.Denominator + "}";
        }
        public string GetAnswer()
        {
            return $"\\frac{{{answer.Numerator}}}{{{answer.Denominator}}}";
        }
    }
}
