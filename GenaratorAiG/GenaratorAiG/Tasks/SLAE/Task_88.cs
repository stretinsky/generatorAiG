using System;
using System.Collections.Generic;
using Fractions;

namespace GenaratorAiG.Tasks.SLAE
{
    class Task_88: ITask
    {
        string description = "Решить систему уравнений матричным методом";
        int[,] slae = new int[3, 3];
        int[] matrixX = new int[3];
        int[,] inverse = new int[3, 3];
        public int determinant = 0;
        public int[] answers = new int[3];

        public Task_88(Random rnd)
        {
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        do
                        {
                            slae[i, j] = rnd.Next(-5, 10);
                        }
                        while (slae[i, j] == 0);
                    }

                    matrixX[i] = rnd.Next(10);
                }

                determinant = slae[0, 0] * slae[1, 1] * slae[2, 2] + slae[0, 2] * slae[1, 0] * slae[2, 1] + slae[2, 0] * slae[0, 1] * slae[1, 2]
                    - slae[0, 2] * slae[1, 1] * slae[2, 0] - slae[0, 1] * slae[1, 0] * slae[2, 2] - slae[0, 0] * slae[1, 2] * slae[2, 1];
            }
            while (determinant == 0);

            inverse[0, 0] = slae[1, 1] * slae[2, 2] - slae[2, 1] * slae[1, 2];
            inverse[1, 1] = slae[0, 0] * slae[2, 2] - slae[0, 2] * slae[2, 0];
            inverse[2, 2] = slae[0, 0] * slae[1, 1] - slae[1, 0] * slae[0, 1];

            inverse[0, 1] = -(slae[0, 1] * slae[2, 2] - slae[0, 2] * slae[2, 1]);
            inverse[0, 2] = slae[0, 1] * slae[1, 2] - slae[0, 2] * slae[1, 1];
            inverse[1, 0] = -(slae[1, 0] * slae[2, 2] - slae[1, 2] * slae[2, 0]);
            inverse[1, 2] = -(slae[0, 0] * slae[1, 2] - slae[1, 0] * slae[0, 2]);
            inverse[2, 0] = slae[1, 0] * slae[2, 1] - slae[2, 0] * slae[1, 1];
            inverse[2, 1] = -(slae[0, 0] * slae[2, 1] - slae[2, 0] * slae[0, 1]);

            answers[0] = inverse[0, 0] * matrixX[0] + inverse[0, 1] * matrixX[1] + inverse[0, 2] * matrixX[2];
            answers[1] = inverse[1, 0] * matrixX[0] + inverse[1, 1] * matrixX[1] + inverse[1, 2] * matrixX[2];
            answers[2] = inverse[2, 0] * matrixX[0] + inverse[2, 1] * matrixX[1] + inverse[2, 2] * matrixX[2];
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            string condition = $"\\cases{{{slae[0, 0]}x_1 + {slae[0, 1]}x_2 + {slae[0, 2]}x_3 = {matrixX[0]} \\\\" +
                $"{slae[1, 0]}x_1 + {slae[1, 1]}x_2 + {slae[1, 2]}x_3 = {matrixX[1]} \\\\ " +
                $"{slae[2, 0]}x_1 + {slae[2, 1]}x_2 + {slae[2, 2]}x_3 = {matrixX[2]}}}";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public virtual List<string> GetAnswer()
        {
            Fraction fraction1 = new Fraction(answers[0], determinant);
            Fraction fraction2 = new Fraction(answers[1], determinant);
            Fraction fraction3 = new Fraction(answers[2], determinant);
            string result = $"\\frac{{1}}{{{determinant}}}  \\pmatrix{{{inverse[0, 0]} & {inverse[0, 1]} & {inverse[0, 2]} \\\\" +
                $" {inverse[1, 0]} & {inverse[1, 1]} & {inverse[1, 2]} \\\\" +
                $" {inverse[2, 0]} & {inverse[2, 1]} & {inverse[2, 2]}}} " +
                $" \\pmatrix{{{matrixX[0]} \\\\ {matrixX[1]} \\\\ {matrixX[2]}}} = " +
                $"\\pmatrix{{ \\frac{{{fraction1.Numerator}}}{{{fraction1.Denominator}}} \\\\ \\frac{{{fraction2.Numerator}}}{{{fraction2.Denominator}}} \\\\ \\frac{{{fraction3.Numerator}}}{{{fraction3.Denominator}}} }}" +
                $", \\Delta = {determinant}";
            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }
    }
}
