using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_80: ITask
    {
        string description = "Найти обратную матрицу методом присоединённой матрицы";
        int[,] a = new int[3, 3], intermediate = new int[3, 3], reverse = new int[3, 3];
        int determinant = 0;
        Random rnd = new Random();

        public Task_80()
        {
            while (determinant == 0)
            {
                CreateMatrix();
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
            string condition = $" \\pmatrix{{{a[0, 0]} & {a[0, 1]} & {a[0, 2]} " +
                $"\\\\ {a[1, 0]} & {a[1, 1]} & {a[1, 2]} " +
                $"\\\\ {a[2, 0]} & {a[2, 1]} & {a[2, 2]}}}";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public string GetAnswer()
        {
            return $"\\frac{{1}}{{{determinant}}} \\pmatrix{{{reverse[0, 0]} & {reverse[0, 1]} & {reverse[0, 2]} " +
                $"\\\\ {reverse[1, 0]} & {reverse[1, 1]} & {reverse[1, 2]} " +
                $"\\\\ {reverse[2, 0]} & {reverse[2, 1]} & {reverse[2, 2]}}}";
        }

        public void CreateMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                a[i, 0] = rnd.Next(-5, 10);
                a[i, 1] = rnd.Next(-5, 10);
                a[i, 2] = rnd.Next(-5, 10);
            }
        }
    }
}
