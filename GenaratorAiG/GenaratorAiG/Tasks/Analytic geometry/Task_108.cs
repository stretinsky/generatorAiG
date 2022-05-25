using System;
using LinearAlgebraAndCo;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_108 : Task
    {
        public Task_108(Random random)
        {
            Description = "Вычислить угол между векторами $ и$, где $ и $ – единичные взаимно перпендикулярные векторы.";
            GenerateTask(random);
        }
        public void GenerateTask(Random random)
        {
            Vector a = Vector.GenerateRandomVector(2, random, -5, 5), b = Vector.GenerateRandomVector(2, random, -5, 5);
            taskLatex.Add(Expression($"\\vec{{a}}={a.Coordinates[0]}\\vec{{p}}+{a.Coordinates[1]}\\vec{{q}}"));
            taskLatex.Add(Expression($"\\vec{{b}}={b.Coordinates[0]}\\vec{{p}}+{b.Coordinates[1]}\\vec{{q}}"));
            taskLatex.Add("\\vec{p}");
            taskLatex.Add("\\vec{q}");
            double angle = Math.Round(180 / Math.PI * Math.Acos(a.ScalarProduct(b) / Math.Sqrt(a.ScalarProduct(a)) / Math.Sqrt(b.ScalarProduct(b))), 5);
            answerLatex.Add("\\arccos{\\frac{" + a.ScalarProduct(b) + "}{" +
                    StringSqrt(a.ScalarProduct(a)) + StringSqrt(b.ScalarProduct(b)) + "}}\\approx" + angle + "^{\\circ}");
        }
    }
}
