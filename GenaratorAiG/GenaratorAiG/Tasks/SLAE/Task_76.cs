﻿using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_76: ITask
    {
        string description = "Найти матрицу A^n";
        int[,] matrix = new int[2, 2];
        int n, choice;
      
        public Task_76(Random rnd)
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
        public List<string> GetCondition()
        {
            string condition;
            if (choice == 0)
            {
                condition = $"\\left(\\matrix{{{matrix[0, 0]} & {matrix[0, 1]} \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}\\right)";
            }
            else
            {
                if (n == 1)
                    condition = $"\\left(\\matrix{{cos(x) & sin(x) \\\\ -sin(x) & cos(x)}}\\right)";
                else
                    condition = $"\\left(\\matrix{{cos({n}x) & sin({n}x) \\\\ -sin({n}x) & cos({n}x)}}\\right)";
            }
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public List<string> GetAnswer()
        {
            string result="";
            if (choice == 0)
            {
                if (n == 1)
                    result = $"A^n = \\left(\\matrix{{{matrix[0, 0]} & n \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}\\right)";
                else
                    result = $"A^n = \\left(\\matrix{{{matrix[0, 0]} & {matrix[0, 1]}n \\\\ {matrix[1, 0]} & {matrix[1, 1]}}}\\right)";
            }
            else if (choice == 1)
            {
                if (n == 1)
                    result = $"A^n = \\left(\\matrix{{cos(nx) & sin(nx) \\\\ -sin(nx) & cos(nx)}}\\right)";
                else
                    result = $"A^n = \\left(\\matrix{{cos(n{n}x) & sin(n{n}x) \\\\ -sin(n{n}x) & cos(n{n}x)}}\\right)";
            }

            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }
    }
}
