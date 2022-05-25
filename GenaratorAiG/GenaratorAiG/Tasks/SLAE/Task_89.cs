using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fractions;

namespace GenaratorAiG.Tasks.SLAE
{
    class Task_89 : Task_88, ITask
    {
        public Task_89(Random random) : base(random) { }
        public override string GetAnswer()
        {
            Fraction fraction1 = new Fraction(answers[0], determinant);
            Fraction fraction2 = new Fraction(answers[1], determinant);
            Fraction fraction3 = new Fraction(answers[2], determinant);
            return $" x_1 = \\frac{{{fraction1.Numerator}}}{{{fraction1.Denominator}}} \\\\ " +
                $"x_2 = \\frac{{{fraction2.Numerator}}}{{{fraction2.Denominator}}} \\\\ " +
                $"x_3 = \\frac{{{fraction3.Numerator}}}{{{fraction3.Denominator}}}";
        }
    }
}
