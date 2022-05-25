using System;
using System.Collections.Generic;
using System.Linq;
using Fractions;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_87: ITask
    {
        private string desciption = "Решить систему линейных уравнений с помощью правила Крамера:";
        int[] zero = new int[1] { 0 };
        int[,] slae = new int[3, 3];
        int determinant = 0;
        string condition, answer = "";
        int[] results = new int[3];
        int determinant1, determinant2, determinant3;

        public Task_87(Random rnd)
        {
            while (determinant == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        slae[i, 0] = rnd.Next(-5, 5);
                    }
                    while (zero.Contains(slae[i, 0]));

                    do
                    {
                        slae[i, 1] = rnd.Next(-5, 5);
                    }
                    while (zero.Contains(slae[i, 0]));

                    do
                    {
                        slae[i, 2] = rnd.Next(-5, 5);
                    }
                    while (zero.Contains(slae[i, 0]));

                    results[i] = rnd.Next(-10, 10);
                }

                determinant = slae[0, 0] * slae[1, 1] * slae[2, 2] + slae[0, 2] * slae[1, 0] * slae[2, 1] + slae[0, 1] * slae[1, 2] * slae[2, 0]
                    - slae[0, 2] * slae[1, 1] * slae[2, 0] - slae[0, 1] * slae[1, 0] * slae[2, 2] - slae[0, 0] * slae[1, 2] * slae[2, 1];
            }

            determinant1 = results[0] * slae[1, 1] * slae[2, 2] + results[1] * slae[0, 2] * slae[2, 1] + results[2] * slae[1, 2] * slae[0, 1]
                    - slae[0, 2] * slae[1, 1] * results[2] - slae[0, 1] * results[1] * slae[2, 2] - results[0] * slae[1, 2] * slae[2, 1];

            determinant2 = slae[0, 0] * results[1] * slae[2, 2] + slae[0, 2] * slae[1, 0] * results[2] + results[0] * slae[1, 2] * slae[2, 0]
                    - slae[0, 2] * results[1] * slae[2, 0] - results[0] * slae[1, 0] * slae[2, 2] - slae[0, 0] * slae[1, 2] * results[2];

            determinant3 = slae[0, 0] * slae[1, 1] * results[2] + results[0] * slae[1, 0] * slae[2, 1] + slae[0, 1] * results[1] * slae[2, 0]
                    - results[0] * slae[1, 1] * slae[2, 0] - slae[0, 1] * slae[1, 0] * results[2] - slae[0, 0] * results[1] * slae[2, 1];
        }

        public string GetDescription()
        {
            return desciption;
        }

        public List<string> GetCondition()
        {
            condition = "";
            condition += "\\cases{";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (slae[i, j] >= 0)
                        condition += $" + {slae[i, j]}x_{j + 1}";
                    else
                        condition += $" {slae[i, j]}x_{j + 1}";
                }

                condition += " = " + results[i];
                condition += @"\\";
            }

            condition += "}";

            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public List<string> GetAnswer()
        {
            answer = "";

            Fraction fraction1 = new Fraction(determinant, determinant1);
            answer += $"x_1 = \\frac{{\\Delta_x_1}}{{\\Delta}} = \\frac{{{fraction1.Denominator}}}{{{fraction1.Numerator}}} \\\\";

            Fraction fraction2 = new Fraction(determinant, determinant2);
            answer += $"x_2 = \\frac{{\\Delta_x_2}}{{\\Delta}} = \\frac{{{fraction2.Denominator}}}{{{fraction2.Numerator}}} \\\\";

            Fraction fraction3 = new Fraction(determinant, determinant3);
            answer += $"x_3 = \\frac{{\\Delta_x_3}}{{\\Delta}} = \\frac{{{fraction3.Denominator}}}{{{fraction3.Numerator}}} \\\\";

            List<string> listResult = new List<string>();
            listResult.Add(answer);
            return listResult;
        }
    }
}