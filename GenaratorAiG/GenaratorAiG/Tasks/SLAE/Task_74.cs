using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_74: ITask
    {
        string description = "Найти произведения матриц A * A^T и A^T * A";
        int length, height;
        int[,] matrix, matrixT;
        double[,] answer1, answer2;
        string result = "";
        string condition = "";

        public Task_74(Random rnd)
        {
            length = rnd.Next(2, 5);
            height = rnd.Next(2, 4);

            matrix = new int[length, height];
            matrixT = new int[height, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    matrix[i, j] = rnd.Next(-5, 5);
                }
            }

            //A^T
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrixT[i, j] = matrix[j, i];
                }
            }

            //A * A^T
            answer1 = new double[length, length];

            //A^T * A
            answer2 = new double[height, height];

            answer1 = MultiplyMatrix(matrix, matrixT);
            answer2 = MultiplyMatrix(matrixT, matrix);
        }

        public string GetDescription()
        {
            return description;
        }
        public List<string> GetCondition()
        {
            condition = "";
            condition += "\\left(\\matrix{";
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    condition += matrix[i, j];
                    if (j == length - 1)
                    {
                        continue;
                    }
                    condition += " & ";
                }

                if (i == length - 1)
                    continue;

                condition += " \\\\ ";
            }
            condition += "}\\right)";

            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public List<string> GetAnswer()
        {
            result = "";
            result += "A * A^T = \\left(\\matrix{";
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    result += answer1[i, j];
                    if (j == length - 1)
                    {
                        continue;
                    }
                    result += " & ";
                }

                if (i == length - 1)
                    continue;

                result += " \\\\ ";
            }
            result += "}\\right)";

            result += "\\\\";

            result += "A^T * A = \\left(\\matrix{";
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    result += answer2[i, j];
                    if (j == height - 1)
                    {
                        continue;
                    }
                    result += " & ";
                }

                if (i == height - 1)
                    continue;

                result += " \\\\ ";
            }
            result += "}\\right)";

            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }

        public double[,] MultiplyMatrix(int[,] A, int[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);
            double temp = 0;
            double[,] kHasil = new double[rA, cB];
            if (cA != rB)
            {
                Console.WriteLine("matrik can't be multiplied !!");
                return null;
            }
            else
            {
                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        kHasil[i, j] = temp;
                    }
                }
                return kHasil;
            }
        }
    }
}
