using System;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_156 : Task
    {
        public Task_156(int n, Random random)
        {
            Description = "Вычислить отрезки, отсекаемые плоскостью на осях координат,следующими плоскостями:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n, random);
        }
        public Task_156(Random random)
        {
            Description = "Вычислить отрезки, отсекаемые плоскостью на осях координат,следующими плоскостями:\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5, random);
        }
        public void GenerateTask(int n, Random random)
        {
            for (int i = 0; i < n; i++)
            {
                string result = "";
                int x = random.Next(-15, 15), y = random.Next(-15, 15), z = random.Next(-15, 15), d = random.Next(-15, 15);
                taskLatex.Add(letters[i] + ")" + Expression($"{x}x+{y}y+{z}z+{d}") + "=0;");
                if (x == 0) result += letters[i] + ")" + $"\\;\\;a=0,";
                else result += letters[i] + ")" + $"\\;\\;a={BuildFraction(-d, x)},";
                if (y == 0) result += "b=0,";
                else result += $"b={BuildFraction(-d, y)},";
                if (z == 0) result += "c=0;";
                else result += $"c={BuildFraction(-d, z)};";
                answerLatex.Add(result);
            }
        }
    }
}