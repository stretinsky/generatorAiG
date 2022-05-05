using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    public class Task_25
    {
        string description = "Решить квадратное уравнение:";
        System.Numerics.Complex complex1, complex2, discriminant, z_1, z_2;
        Random rnd = new Random();

        public Task_25()
        {
            //Можно убрать System.Numerics (у меня using не работал просто)
            complex1 = new System.Numerics.Complex(rnd.Next(1,5), rnd.Next(1, 5));
            complex2 = new System.Numerics.Complex(rnd.Next(1,5), rnd.Next(1, 5));

            discriminant = complex1 * complex1 - 4 * complex2;

            z_1 = (-complex1 + discriminant) / 2;
            z_2 = (-complex1 - discriminant) / 2;
        }

        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"z^2 + z * ({complex1.Real}+{complex1.Imaginary}i)+({complex2.Real}+{complex2.Imaginary}i) = 0";
        }
        public string GetAnswer()
        {
            return $"z_1 = \\frac{{({-complex1.Real}-{complex1.Imaginary}i)+$\\sqrt{discriminant}$}} {{{2}}} = {z_1}" +
                $"\nz_2 = \\frac{{({-complex1.Real}-{complex1.Imaginary}i)-$\\sqrt{discriminant}$}} {{{2}}} = {z_2}";
        }
    }
}
