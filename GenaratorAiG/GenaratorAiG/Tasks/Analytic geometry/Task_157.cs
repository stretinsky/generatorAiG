using System;
using System.Linq;
using LinearAlgebraAndCo;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_157 : Task
    {
        public Task_157(int n, Random random)
        {
            Description = "Провести через следующие точки такие плоскости, которые отсекали бы на осях координат неотрицательные и равные между собою отрезки:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n, random);
        }
        public Task_157(Random random)
        {
            Description = "Провести через следующие точки такие плоскости, которые отсекали бы на осях координат неотрицательные и равные между собою отрезки.\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5, random);
        }
        public void GenerateTask(int n, Random random)
        {
            for (int i = 0; i < n; i++)
            {
                Vector point;
                int a;
                do
                {
                    point = Vector.GenerateRandomVector(3, random, -10, 10);
                    a = point.Coordinates.Sum();
                } while (a < 0);
                taskLatex.Add(letters[i] + $")P\\left({point.Coordinates[0]},{point.Coordinates[1]},{point.Coordinates[2]}\\right);");
                answerLatex.Add(letters[i] + ")" + Expression($"x+y+z+{-a}") + "=0;");
            }
        }
    }
}