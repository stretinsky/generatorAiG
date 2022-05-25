using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_80: ITask
    {
        string description = "Найти обратную матрицу методом присоединённой матрицы";
        int[,] a = new int[3, 3], intermediate = new int[3, 3], reverse = new int[3, 3];
        int determinant = 0;

        public Task_80(Random rnd)
        {
            while (determinant == 0)
            {
                CreateMatrix(rnd);
                determinant = a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * a[2, 1] -
                    a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] * a[2, 2] - a[0, 0] * a[1, 2] * a[2, 1];
            }

            intermediate[0, 0] = a[1, 1] * a[2, 2] - a[2, 1] * a[1, 2];
            intermediate[0, 1] = -(a[1, 0] * a[2, 2] - a[1, 2] * a[2, 0]);
            intermediate[0, 2] = a[1, 0] * a[2, 1] - a[1, 1] * a[2, 0];

            intermediate[1, 0] = -(a[0, 1] * a[2, 2] - a[0, 2] * a[2, 1]);
            intermediate[1, 1] = a[0, 0] * a[2, 2] - a[0, 2] * a[2, 0];
            intermediate[1, 2] = -(a[0, 0] * a[2, 1] - a[0, 1] * a[2, 0]);

            intermediate[2, 0] = a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1];
            intermediate[2, 1] = -(a[0, 0] * a[1, 2] - a[0, 2] * a[1, 0]);
            intermediate[2, 2] = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];


            reverse[0, 0] = intermediate[0, 0];
            reverse[1, 1] = intermediate[1, 1];
            reverse[2, 2] = intermediate[2, 2];

            reverse[0, 1] = intermediate[1, 0];
            reverse[1, 0] = intermediate[0, 1];

            reverse[0, 2] = intermediate[2, 0];
            reverse[2, 0] = intermediate[0, 2];

            reverse[2, 1] = intermediate[1, 2];
            reverse[1, 2] = intermediate[2, 1];


        }

        

        public string GetDescription()
        {
            return description;
        }
        public List<string> GetCondition()
        {
            string condition = $" \\left(\\matrix{{{a[0, 0]} & {a[0, 1]} & {a[0, 2]} " +
                $"\\\\ {a[1, 0]} & {a[1, 1]} & {a[1, 2]} " +
                $"\\\\ {a[2, 0]} & {a[2, 1]} & {a[2, 2]}}}\\right)";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public List<string> GetAnswer()
        {
            string result = $"\\frac{{1}}{{{determinant}}} \\left(\\matrix{{{reverse[0, 0]} & {reverse[0, 1]} & {reverse[0, 2]} " +
                $"\\\\ {reverse[1, 0]} & {reverse[1, 1]} & {reverse[1, 2]} " +
                $"\\\\ {reverse[2, 0]} & {reverse[2, 1]} & {reverse[2, 2]}}}\\right)";
            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }

        public void CreateMatrix(Random random)
        {
            for (int i = 0; i < 3; i++)
            {
                a[i, 0] = random.Next(-5, 10);
                a[i, 1] = random.Next(-5, 10);
                a[i, 2] = random.Next(-5, 10);
            }
        }
    }
}
