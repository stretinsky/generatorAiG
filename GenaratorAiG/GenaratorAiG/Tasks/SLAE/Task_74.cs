using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_74: ITask
    {
        string description = "Найти произведения матриц A * A^T и A^T * A";
        int length, height;
        int[,] matrix, matrixT;
        double[,] answer1, answer2;
        Random rnd = new Random();
        string result = "";
        string condition = "";

        public Task_74()
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
        public string GetCondition()
        {
            condition += "\\pmatrix{";
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
            condition += "}";

            return condition;
        }
        public string GetAnswer()
        {
            result += "\\pmatrix{";
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
            result += "}";

            result += "\\\\";

            result += "\\pmatrix{";
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
            result += "}";

            return result;
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
