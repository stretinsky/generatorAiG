using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebraAndCo;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_105 : Task
    {
        private Random random = new Random();
        private string latex = "";
        public Task_105(int n)
        {
            Description = "Вычислить скалярное произведение векторов $ и $, заданных своими координатами, и углы между ними: ";
            taskLatex.Add("\\vec{a}");
            taskLatex.Add("\\vec{b}");
            GenerateTask(n);
        }
        public void GenerateTask(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Vector a = new Vector(0, 0, 0), b = new Vector(0, 0, 0);
                a = Vector.GenerateRandomVector(3, random, -10, 15);
                b = Vector.GenerateRandomVector(3, random, -10, 15);
                latex += letters[i] + $")\\vec{{a}}=({a.Coordinates[0]}, {a.Coordinates[1]}, {a.Coordinates[2]})," +
                    $"\\vec{{b}}=({b.Coordinates[0]}, {b.Coordinates[1]}, {b.Coordinates[2]})\\\\";
                double angle = 180 / Math.PI * Math.Acos(a.ScalarProduct(b) / Math.Sqrt(a.ScalarProduct(a)) / Math.Sqrt(b.ScalarProduct(b)));
                AnswerLatex += "\\arccos{\\frac{" + a.ScalarProduct(b) + "}{" +
                    StringSqrt(a.ScalarProduct(a)) + StringSqrt(b.ScalarProduct(b)) + "}}\\approx" + angle + "^{\\circ}\\\\";
            }
            taskLatex.Add(latex);
        }
    }
}
