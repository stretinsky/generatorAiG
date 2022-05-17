using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LinearAlgebraAndCo
{
    public class Polynomial
    {
        public Complex[] Coefficients { get; private set; } //0-ой элемент - свободный член, 1-ый - коэф. при x и т.д.
        public Complex[] Roots { get; private set; }
        public Polynomial() { }
        public Polynomial(params Complex[] coefficients)
        {
            Coefficients = coefficients;
        }
        public void SetRoots(params Complex[] roots)
        {
            Roots = roots;
            int n = roots.Length;
            Coefficients = new Complex[n + 1];
            Coefficients[n] = 1d;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i - 1; j < n; j++)
                {
                    Coefficients[j] -= roots[i] * Coefficients[j + 1];
                }
            }
        }
        public int[] GetIntCoefficients()
        {
            if (Coefficients.All(s => s.Imaginary == 0))
            {
                int[] output = new int[Coefficients.Length];
                for(int i = 0; i < Coefficients.Length; i++)
                {
                    output[i] = (int)Coefficients[i].Real;
                }
                return output;
            }
            return null;
        }
    }
}
