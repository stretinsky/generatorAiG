﻿using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.Complex
{
    internal class Task_19 : ITask
    {
        string description = "Представить в показательной форме комплексное число:";
        private double a, b, r, f;
        private int index;
        private double[] trigonometry = new double[] { Math.PI / 3, Math.PI / 4, Math.PI / 5, Math.PI / 6, Math.PI / 7, Math.PI / 8, Math.PI / 9, Math.PI / 10 };
        private int[] array_f = new int[] { 173, 100, 72, 57, 48, 41, 36, 32 };
        public Task_19(Random rnd)
        {
            index = rnd.Next() % 8;
            double i = Math.Round(rnd.NextDouble(), 2);
            f = trigonometry[index];
            a = array_f[index] * i;
            b = 100 * i;
            r = Math.Round(Math.Sqrt(a * a + b * b));
        }
        public string GetDescription()
        {
            return description;
        }
        public List<string> GetCondition()
        {
            string condition = $"{a} + {b}i";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public List<string> GetAnswer()
        {
            string result = $"{r}e^{{\\frac{{\\pi}}{{{index + 1}}}i}}";
            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }
    }
}
