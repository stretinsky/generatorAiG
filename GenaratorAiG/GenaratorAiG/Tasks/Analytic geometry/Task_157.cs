using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebraAndCo;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_157 : Task
    {
        Random random = new Random();
        public Task_157(int n)
        {
            Description = "Провести через следующие точки такие плоскости, которые отсекали бы на осях координат неотрицательные и равные между собою отрезки:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n);
        }
        public Task_157()
        {
            Description = "Провести через следующие точки такие плоскости, которые отсекали бы на осях координат неотрицательные и равные между собою отрезки.\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5);
        }
        public void GenerateTask(int n)
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
                AnswerLatex += letters[i] + ")" + Expression($"x+y+z+{-a}") + "=0\\\\";
            }
        }
    }
}
