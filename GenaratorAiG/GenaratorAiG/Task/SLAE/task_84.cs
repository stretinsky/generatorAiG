using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Task.SLAE
{
    public class task_84
    {
        string description = "Найти ранг методом элементарных преобразований:";
        Random rnd = new Random();
        double[,] matrix;
        double[,] answer;
        int n, m;
        int rang = 0;
        string result = "";
        bool flag;

        public task_84()
        {
            //Матрица случайно размера
            n = rnd.Next(3, 6);
            matrix = new double[n, n];
            answer = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-15, 15);
                }
            }

            answer = ToTriangle(matrix);

            flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (answer[i, j] != 0.0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == true)
                    rang++;

                flag = false;
            }
        }




        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            result += "\\pmatrix{";
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    result += matrix[i, j];
                    if (j == m - 1)
                    {
                        continue;
                    }
                    result += " & ";
                }

                if (i == n - 1)
                    continue;

                result += " \\\\ ";
            }
            result += "}";

            return result;
        }
        public string GetAnswer()
        {
            return $"rang = {rang}";
        }



        static double[,] ToTriangle(double[,] matrix)
        {
            List<int> list = new List<int>();
            int n = matrix.GetLength(0);
            if (n != matrix.GetLength(1))
                throw new ArgumentException("Square matrix expected", "matrix");

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double koef = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < n; k++)
                        matrix[j, k] -= matrix[i, k] * koef;
                }

                list.Clear();

                for (int k = 0; k < n; k++)
                {
                    list[k] = 0;
                    for (int l = 0; l < n; l++)
                    {
                        if (matrix[k, l] == 0)
                            list[k]++;
                    }
                }

                var anyDuplicate = list.GroupBy(x => x).Any(g => g.Count() > 1);

                //Если количество нулей в строчках совпадает то продолжаем, иначе выходим
                if (anyDuplicate == true)
                    continue;
                else
                    break;

            }

            return matrix;
        }
    }
}
