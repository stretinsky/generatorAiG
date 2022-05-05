using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    internal class Task_26
    {
        string description = "Решить уравнение:";
        System.Numerics.Complex complex;
        int degree;
        Random rnd = new Random();

        public Task_26()
        {
            degree = rnd.Next(2, 6);
            complex = new System.Numerics.Complex(1, 1);

            //Корень degree-степени
            complex = System.Numerics.Complex.Pow(complex, 1/degree);
        }

        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"$z^{degree}$ - 1 = {complex.Imaginary}";
        }
        public string GetAnswer()
        {
            return $"z = {complex}";
        }
    }
}
