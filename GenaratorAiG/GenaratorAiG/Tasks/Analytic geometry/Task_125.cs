using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_125: ITask
    {
        string description = "Проверить, компланарны ли следующие вектора:";
        Random rnd = new Random();
        int[,] vectors = new int[3, 3];
        int determinant;

        public Task_125()
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

        public string GetCondition()
        {
            return $"\\vec{{a}} = ({vectors[0, 0]}; {vectors[0, 1]}; {vectors[0, 2]}), \\; " +
                $"\\vec{{b}} = ({vectors[1, 0]}; {vectors[1, 1]}; {vectors[1, 2]}), \\; " +
                $"\\vec{{c}} = ({vectors[2, 0]}; {vectors[2, 1]}; {vectors[2, 2]}) \\\\";
        }

        public string GetAnswer()
        {
            if (determinant == 0)
                return $"No, \\Delta = {determinant}"; //todo (Localization)
            else
                return $"Yes, \\Delta = {determinant}"; //todo (Localization)
        }
    }
}
