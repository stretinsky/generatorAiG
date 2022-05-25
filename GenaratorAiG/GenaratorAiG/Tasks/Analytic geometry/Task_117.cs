using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_117: ITask
    {
        string description = "Найти векторное произведение векторов [a, b]"; //Над а и б вектора должны быть
        int[,] vectors = new int[2, 3];
        string result, condition = "";
        int[] answer = new int[3];

        public Task_117(Random rnd)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        vectors[i, j] = rnd.Next(-10, 10);
                    }
                    while (vectors[i, j] == 0);
                }
            }

            answer[0] = vectors[0, 1] * vectors[1, 2] - vectors[0, 2] * vectors[1, 1];
            answer[1] = vectors[0, 0] * vectors[1, 2] - vectors[0, 2] * vectors[1, 0];
            answer[2] = vectors[0, 0] * vectors[1, 1] - vectors[0, 1] * vectors[1, 0];
        }

        public string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            condition += $"\\vec{{a}} = {vectors[0, 0]}\\vec{{i}}";

            if (vectors[0, 1] >= 0)
                condition += $"+{vectors[0, 1]}\\vec{{j}} ";
            else
                condition += $" {vectors[0, 1]}\\vec{{j}} ";

            if (vectors[0, 2] >= 0)
                condition += $"+{vectors[0, 2]}\\vec{{k}} \\\\ \\vec{{b}} = {vectors[1, 0]}\\vec{{i}}";
            else
                condition += $" {vectors[0, 2]}\\vec{{k}} \\\\ \\vec{{b}} = {vectors[1, 0]}\\vec{{i}}";

            if (vectors[1, 1] >= 0)
                condition += $"+{vectors[1, 1]}\\vec{{j}} ";
            else
                condition += $" {vectors[1, 1]}\\vec{{j}} ";

            if (vectors[1, 2] >= 0)
                condition += $"+{vectors[1, 2]}\\vec{{j}} ";
            else
                condition += $" {vectors[1, 1]}\\vec{{j}} ";

            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public List<string> GetAnswer()
        {
            result += $"\\vec{{ab}} = ";
            result += "\\pmatrix{ \\vec{i} & \\vec{j} & \\vec{k} \\\\" +
                $"{vectors[0, 0]} & {vectors[0, 1]} & {vectors[0, 2]} \\\\ {vectors[1, 0]} & {vectors[1, 1]} & {vectors[1, 2]} }} = ";

            result += $"{answer[0]}\\vec{{i}}";

            if (answer[1] < 0)
                result += $" + {-answer[1]}\\vec{{j}}";
            else if (answer[1] > 0)
                result += $" - {answer[1]}\\vec{{j}}";

            if (answer[2] > 0)
                result += $" + {answer[2]}\\vec{{k}}";
            else if (answer[2] < 0)
                result += $" {answer[2]}\\vec{{k}}";

            List<string> listResult = new List<string>();
            listResult.Add(result);
            return listResult;
        }

    }
}
