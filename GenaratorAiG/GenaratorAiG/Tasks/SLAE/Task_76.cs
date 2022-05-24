using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_76: ITask
    {
        string description = "Найти матрицу A^n";
        int[,] matrix = new int[2, 2];
        Random rnd = new Random();
        int n, choice;
      

        public Task_76()
        {
            choice = rnd.Next(2);

            switch (choice)
            {
                //Обычные числа
                case 0:
                    {
                        matrix[0, 0] = 1;
                        matrix[1, 1] = 1;
                        matrix[1, 0] = 0;

                        n = rnd.Next(1, 11);
                        matrix[0, 1] = n;

                        break;
                    }
                //Тригометрия
                case 1:
                    {
                        n = rnd.Next(1, 6);
                        break;
                    }
            }
        }

        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            if (choice == 0)
            {
                return $"\\pmatrix{{{matrix[0, 0]} & {matrix[0, 1]} \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}";
            }
            else
            {
                if (n == 1)
                    return $"\\pmatrix{{cos(x) & sin(x) \\\\ -sin(x) & cos(x)}}";
                else
                    return $"\\pmatrix{{cos({n}x) & sin({n}x) \\\\ -sin({n}x) & cos({n}x)}}";
            }
        }
        public string GetAnswer()
        {
            switch (choice)
            {
                case 0:
                    {
                        if (n == 1)
                            return $"A^n = \\pmatrix{{{matrix[0, 0]} & n \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}";
                        else
                            return $"A^n = \\pmatrix{{{matrix[0, 0]} & {matrix[0, 1]}n \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}";

                    }
                case 1:
                    {
                        if (n == 1)
                            return $"A^n = \\pmatrix{{cos(nx) & sin(nx) \\\\ -sin(nx) & cos(nx)}}";
                        else
                            return $"A^n = \\pmatrix{{cos(n{n}x) & sin(n{n}x) \\\\ -sin(n{n}x) & cos(n{n}x)}}";
                    }
            }

            return null;
        }
    }
}
