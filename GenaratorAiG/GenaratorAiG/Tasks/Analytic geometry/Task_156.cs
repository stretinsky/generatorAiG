using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_156 : Task
    {
        private Random random = new Random();
        public Task_156(int n)
        {
            Description = "Вычислить отрезки, отсекаемые плоскостью на осях координат,следующими плоскостями:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n);
        }
        public Task_156()
        {
            Description = "Вычислить отрезки, отсекаемые плоскостью на осях координат,следующими плоскостями:\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5);
        }
        public void GenerateTask(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = random.Next(-15, 15), y = random.Next(-15, 15), z = random.Next(-15, 15), d = random.Next(-15, 15);
                taskLatex.Add(letters[i] + ")" + Expression($"{x}x+{y}y+{z}z+{d}") + "=0;");
                if (x == 0) AnswerLatex += letters[i] + ")" + $"\\;\\;a=0,";
                else AnswerLatex += letters[i] + ")" + $"\\;\\;a={BuildFraction(-d, x)},";
                if (y == 0) AnswerLatex += "b=0,";
                else AnswerLatex += $"b={BuildFraction(-d, y)},";
                if (z == 0) AnswerLatex += "c=0\\\\";
                else AnswerLatex += $"c={BuildFraction(-d, z)}\\\\";
            }
        }
    }
}
