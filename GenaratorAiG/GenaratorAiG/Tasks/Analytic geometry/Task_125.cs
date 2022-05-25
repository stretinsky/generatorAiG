﻿using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_125: ITask
    {
        string description = "Проверить, компланарны ли следующие вектора:";
        
        int[,] vectors = new int[3, 3];
        int determinant;

        public Task_125(Random rnd)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vectors[i, j] = rnd.Next(-10, 10);
                }
            }

            determinant = vectors[0, 0] * vectors[1, 1] * vectors[2, 2] + vectors[0, 2] * vectors[1, 0] * vectors[2, 1] + vectors[2, 0] * vectors[0, 1] * vectors[1, 2]
                - vectors[0, 2] * vectors[1, 1] * vectors[2, 0] - vectors[0, 1] * vectors[1, 0] * vectors[2, 2] - vectors[0, 0] * vectors[2, 1] * vectors[1, 2];
        }

        public string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            string condition = $"\\vec{{a}} = ({vectors[0, 0]}; {vectors[0, 1]}; {vectors[0, 2]}), \\; " +
                $"\\vec{{b}} = ({vectors[1, 0]}; {vectors[1, 1]}; {vectors[1, 2]}), \\; " +
                $"\\vec{{c}} = ({vectors[2, 0]}; {vectors[2, 1]}; {vectors[2, 2]}) \\\\";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public List<string> GetAnswer()
        {
            List<string> result = new List<string>();
            if (determinant == 0)
                result.Add($"Yes, \\Delta = {determinant}"); //todo (Localization)
            else
                result.Add($"No, \\Delta = {determinant}"); //todo (Localization)
            return result;
        }
    }
}
