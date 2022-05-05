using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    internal class Task_25
    {
        string description = "Решить квадратное уравнение:";
        System.Numerics.Complex complex1, complex2, discriminant, z1, z2;
        Random rnd = new Random();

        public Task_25()
        {
            //Можно убрать System.Numerics (у меня using не работал просто)
            complex1 = new System.Numerics.Complex(rnd.Next(1,10), rnd.Next(-5, 5));
            complex2 = new System.Numerics.Complex(rnd.Next(1, 10), rnd.Next(-5, 5));

            discriminant = System.Numerics.Complex.Sqrt(complex1 * complex1 - 4 * complex2);

            z1 = (-complex1 + discriminant) / 2;
            z1 = (- complex1 - discriminant) / 2;
        }

        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"$z^2$ + z * ({complex1}) + ({complex2}) = 0";
        }
        public string GetAnswer()
        {
            return $"$z_1$ = \\frac{{{-complex1} + {discriminant}}} {{{2}}} = {z1}" + $"\n$z_2$ = \\frac{{{-complex1} - {discriminant}}} {{{2}}} = {z2}";
        }
    }
}
