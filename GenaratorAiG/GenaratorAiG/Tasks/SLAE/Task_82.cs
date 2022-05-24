using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_82: ITask
    {
        string description = "Решить матричные уравнения:";
        Random rnd = new Random();
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        int[,] reverse1 = new int[2, 2];
        int[,] result = new int[2, 2];
        int[] zero = new int[1] { 0 };
        int det = 0;

        public Task_82()
        {
            GenerateMatrix();

            reverse1[0, 0] = matrix1[1, 1];
            reverse1[0, 1] = -1 * matrix1[0, 1];
            reverse1[1, 0] = -1 * matrix1[1, 0];
            reverse1[1, 1] = matrix1[0, 0];

            result[0, 0] = reverse1[0, 0] * matrix2[0, 0] + reverse1[0, 1] * matrix2[1, 0];
            result[0, 1] = reverse1[0, 0] * matrix2[0, 1] + reverse1[0, 1] * matrix2[1, 1];
            result[1, 0] = reverse1[1, 0] * matrix2[0, 0] + reverse1[1, 1] * matrix2[1, 0];
            result[1, 1] = reverse1[1, 0] * matrix2[0, 1] + reverse1[1, 1] * matrix2[1, 1];
        }

        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"\\pmatrix{{{matrix1[0, 0]} & {matrix1[0, 1]} \\\\ {matrix1[1, 0]} & {matrix1[1, 1]}}} X = " +
                $"\\pmatrix{{{matrix2[0, 0]} & {matrix2[0, 1]} \\\\ {matrix2[1, 0]} & {matrix2[1, 1]}}}";
        }
        public string GetAnswer()
        {
            if (det == 1)
                return $"\\pmatrix{{{result[0, 0]} & {result[0, 1]} \\\\ {result[1, 0]} & {result[1, 1]}}}";
            else
                return $"\\frac{{1}}{{{det}}}\\pmatrix{{{result[0, 0]} & {result[0, 1]} \\\\ {result[1, 0]} & {result[1, 1]}}}";
        }

        public void GenerateMatrix()
        {
            while (det == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    do
                    {
                        matrix1[i, 0] = rnd.Next(-5, 10);
                    }
                    while (zero.Contains(matrix1[i, 0]));

                    do
                    {
                        matrix1[i, 1] = rnd.Next(-5, 10);
                    }
                    while (zero.Contains(matrix1[i, 1]));

                    do
                    {
                        matrix2[i, 0] = rnd.Next(-5, 10);
                    }
                    while (zero.Contains(matrix2[i, 0]));

                    do
                    {
                        matrix2[i, 1] = rnd.Next(-5, 10);
                    }
                    while (zero.Contains(matrix2[i, 1]));
                }

                det = matrix1[0, 0] * matrix1[1, 1] - matrix1[0, 1] * matrix1[1, 0];
            }
        }
    }
}
