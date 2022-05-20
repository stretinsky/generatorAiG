using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fractions;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_59
    {
        string description = "Решить уравнения:";
        Random rnd = new Random();
        int[,] matrix = new int[2, 2];
        int n, m, determinant;
        string condition, result = "";

        public Task_59()
        {
            matrix[0, 0] = rnd.Next(-5, 5);
            matrix[0, 1] = rnd.Next(-5, 5);
            matrix[1, 0] = rnd.Next(-5, 5);
            matrix[1, 1] = rnd.Next(-5, 5);

            n = rnd.Next(10);
            m = rnd.Next(10);
            determinant = rnd.Next(30);
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetCondition()
        {
            condition += $"\\pmatrix{{";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0 && j == 0 && n == 1)
                        condition += "(x";
                    else if (i == 0 && j == 0)
                        condition += "(" + n + "x";
                    else if (i == 1 && j == 0 && m == 1)
                        condition += "(x";
                    else if (i == 1 && j == 0)
                        condition += "(" + m + "x";

                    if (matrix[i, j] >= 0 && j == 1)
                        condition += $"{matrix[i, j]}";
                    else if (matrix[i, j] >= 0 && j == 0)
                        condition += $"+{matrix[i, j]})";
                    else if (j == 0)
                        condition += $"{matrix[i, j]})";
                    else
                        condition += $"{matrix[i, j]}";

                    if (j == 1)
                        continue;

                    condition += " & ";
                }

                if (i == 1)
                    continue;

                condition += "\\\\";
            }
            condition += $"}} = {determinant}";

            return condition;
        }

        public string GetAnswer()
        {
            if (matrix[0, 1] >= 0)
                result += $"{matrix[1, 1]}({n}x + {matrix[0, 0]}) - {matrix[0, 1]}({m}x + {matrix[1, 0]}) = {determinant}";
            else
                result += $"{matrix[1, 1]}({n}x + {matrix[0, 0]}) + {-matrix[0, 1]}({m}x + {matrix[1, 0]}) = {determinant}";

            result += "\\\\";

            int res = determinant + matrix[0, 1] * matrix[1, 0] - matrix[1, 1] * matrix[0, 0];
            int indexX = matrix[1, 1] * n - matrix[0, 1] * m;
            result += $"{indexX}x = {res}";

            result += "\\\\";

            Fraction fraction = new Fraction(res,indexX);

            result += $"x = \\frac{{{fraction.Numerator}}}{{{fraction.Denominator}}}";

            return result;
        }
    }
}
