using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    internal class Task_152: ITask
    {
        string description;
        int x, y, z, p;
        int[,] points = new int[6, 3];

        public Task_152(Random rnd)
        {
            x = rnd.Next(2, 10);
            y = rnd.Next(2, 10);
            z = rnd.Next(2, 10);
            p = rnd.Next(2, 10);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    points[i, j] = rnd.Next(-5, 10);
                }
            }

            description = $"Проходит ли плоскость {x}x - {y}y + {z}z + {p} = 0 через одну из следующих точек:";
        }

        public string GetDescription()
        {
            return description;
        }

        public List<string> GetCondition()
        {
            string condition = $"A({points[0, 0]};{points[0, 1]};{points[0, 2]}), \\;" +
                $"B({points[1, 0]};{points[1, 1]};{points[1, 2]}), \\;" +
                $"C({points[2, 0]};{points[2, 1]};{points[2, 2]}), \\;" +
                $"D({points[3, 0]};{points[3, 1]};{points[3, 2]}), \\;" +
                $"E({points[4, 0]};{points[4, 1]};{points[4, 2]}), \\;" +
                $"F({points[5, 0]};{points[5, 1]};{points[5, 2]})";
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }

        public List<string> GetAnswer()
        {
            string result = "";
            string resultLATEX = "";
            if (x * points[0, 0] - y * points[0, 1] + z * points[0, 2] + p == 0)
            {
                result += $"A ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "A: YES, \\;";
            }
            else
            {
                result += $"A НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "A: NO, \\;";
            }

            if (x * points[1, 0] - y * points[1, 1] + z * points[1, 2] + p == 0)
            {
                result += $"B ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "B: YES, \\;";
            }
            else
            {
                result += $"B НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "B: NO, \\;";
            }

            if (x * points[2, 0] - y * points[2, 1] + z * points[2, 2] + p == 0)
            {
                result += $"C ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "C: YES, \\;";
            }
            else
            {
                result += $"C НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "C: NO, \\;";
            }

            if (x * points[3, 0] - y * points[3, 1] + z * points[3, 2] + p == 0)
            {
                result += $"D ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "D: YES, \\;";
            }
            else
            {
                result += $"D НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "D: NO, \\;";
            }

            if (x * points[4, 0] - y * points[4, 1] + z * points[4, 2] + p == 0)
            {
                result += $"E ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "E: YES, \\;";
            }
            else
            {
                result += $"E НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "E: NO, \\;";
            }

            if (x * points[5, 0] - y * points[5, 1] + z * points[5, 2] + p == 0)
            {
                result += $"F ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "F: YES";
            }
            else
            {
                result += $"F НЕ ПРОХОДИТ через плоскость, \\;";
                resultLATEX += "F: NO";
            }
            List<string> listResult = new List<string>();
            listResult.Add(resultLATEX);
            return listResult;
        }
    }
}
