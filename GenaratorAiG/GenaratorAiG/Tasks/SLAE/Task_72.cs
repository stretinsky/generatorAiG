using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_72: ITask
    {
        string description = "Найти произведения матриц A * B и B * A:";
        int[,] matrixA, matrixB;
        int lengthA, heightA, lengthB, heightB;
        int[,] resultM;
        string condition, result;

        public Task_72(Random rnd)
        {
            lengthA = rnd.Next(2, 5);
            heightA = rnd.Next(3, 5);

            lengthB = rnd.Next(1, 4);
            heightB = lengthA;

            //Столбцы первой == строки второй
            matrixA = new int[heightA, lengthA];
            matrixB = new int[heightB, lengthB];

            for (int i = 0; i < heightA; i++)
            {
                for (int j = 0; j < lengthA; j++)
                {
                    matrixA[i, j] = rnd.Next(-10, 10);
                }
            }

            for (int i = 0; i < heightB; i++)
            {
                for (int j = 0; j < lengthB; j++)
                {
                    matrixB[i, j] = rnd.Next(-10, 10);
                }
            }

            resultM = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            resultM = Multiplication(matrixA, matrixB);
        }

        public string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            condition += $"A = \\pmatrix{{";
            for (int i = 0; i < heightA; i++)
            {
                for (int j = 0; j < lengthA; j++)
                {
                    condition += $" {matrixA[i, j]} ";

                    if (j == lengthA - 1)
                        continue;

                    condition += " & ";
                }

                if (i == heightA - 1)
                    continue;

                condition += "\\\\";
            }
            condition += "}, ";

            condition += $"B = \\pmatrix{{";
            for (int i = 0; i < heightB; i++)
            {
                for (int j = 0; j < lengthB; j++)
                {
                    condition += $" {matrixB[i, j]} ";

                    if (j == lengthB - 1)
                        continue;

                    condition += " & ";
                }

                if (i == heightB - 1)
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
            result += $"\\pmatrix{{";

            for (int i = 0; i < resultM.GetLength(0); i++)
            {
                for (int j = 0; j < resultM.GetLength(1); j++)
                {
                    result += $" {resultM[i, j]} ";

                    if (j == resultM.GetLength(1) - 1)
                        continue;

                    result += " & ";
                }

                if (i == resultM.GetLength(0) - 1)
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
