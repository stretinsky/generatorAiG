using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_72: ITask
    {
        string description = "Найти произведения матриц A * B и B * A:";
        int[,] matrixA, matrixB;
        int[,] resultAB, resultBA;
        string condition, result;
        int n, m;

        public Task_72(Random rnd)
        {
            n = rnd.Next(2, 5);
            m = rnd.Next(2, 5);

            //Столбцы первой == строки второй
            matrixA = new int[n, m];
            matrixB = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixA[i, j] = rnd.Next(-10, 10);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixB[i, j] = rnd.Next(-10, 10);
                }
            }

            resultAB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            resultAB = Multiplication(matrixA, matrixB);

            resultBA = new int[matrixB.GetLength(0), matrixA.GetLength(1)];
            resultBA = Multiplication(matrixB, matrixA);
        }

        public string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            condition = "";
            condition += $"A = \\pmatrix{{";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    condition += $" {matrixA[i, j]} ";

                    if (j == m- 1)
                        continue;

                    condition += " & ";
                }

                if (i == n - 1)
                    continue;

                condition += "\\\\";
            }
            condition += "}, ";

            condition += $"B = \\pmatrix{{";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    condition += $" {matrixB[i, j]} ";

                    if (j == n - 1)
                        continue;

                    condition += " & ";
                }

                if (i == m - 1)
                    continue;

                condition += "\\\\";
            }
            condition += "}";

            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public List<string> GetAnswer()
        {
            result = "";
            result += $"A * B = \\pmatrix{{";

            for (int i = 0; i < resultAB.GetLength(0); i++)
            {
                for (int j = 0; j < resultAB.GetLength(1); j++)
                {
                    result += $" {resultAB[i, j]} ";

                    if (j == resultAB.GetLength(1) - 1)
                        continue;

                    result += " & ";
                }

                if (i == resultAB.GetLength(0) - 1)
                    continue;

                result += "\\\\";
            }

            result += "};";

            result += $"B * A = \\pmatrix{{";

            for (int i = 0; i < resultBA.GetLength(0); i++)
            {
                for (int j = 0; j < resultBA.GetLength(1); j++)
                {
                    result += $" {resultBA[i, j]} ";

                    if (j == resultBA.GetLength(1) - 1)
                        continue;

                    result += " & ";
                }

                if (i == resultBA.GetLength(0) - 1)
                    continue;

                result += "\\\\";
            }

            result += "}";

            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }

        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
                throw new Exception("Матрицы нельзя перемножить");

            int[,] r = new int[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
    }
}
