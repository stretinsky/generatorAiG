using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebraAndCo;
using Fractions;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_119 : Task
    {
       
        public Task_119(Random random)
        {
            Description = "a) Дан треугольник с вершинами $, $, $." +
                "Найти площадь треугольника и длину его высоты, опущенной из вершины $ на сторону $.\n" +
                "b) Даны векторы $, $.Найти их векторное произведение, синус угла между ними, " +
                "площадь параллелограмма,построенного на этих векторах.";
            Vector AminC, BminC, C = Vector.GenerateRandomVector(3, random, -5, 5);
            do
            {
                AminC = Vector.GenerateRandomVector(3, random, -3, 3);
                BminC = Vector.GenerateRandomVector(3, random, -3, 3);
            } while ((AminC * BminC).ScalarProduct(AminC * BminC) == 0);

            Vector A = AminC + C, B = BminC + C, product = AminC * BminC;
            string area = "S=\\frac{" + StringSqrt(product.ScalarProduct(product)) + "}{2}";
            string height = "H=\\frac{" + StringSqrt(product.ScalarProduct(product)) + "}{" + StringSqrt((A - B).ScalarProduct(A - B)) + "}";
            answerLatex.Add("a)" + area + "," + height);
            taskLatex.Add($"A\\left({A.Coordinates[0]},{A.Coordinates[1]},{A.Coordinates[2]}\\right)");
            taskLatex.Add($"B\\left({B.Coordinates[0]},{B.Coordinates[1]},{B.Coordinates[2]}\\right)");
            taskLatex.Add($"C\\left({C.Coordinates[0]},{C.Coordinates[1]},{C.Coordinates[2]}\\right)");
            taskLatex.Add("C");
            taskLatex.Add("AB");
            do
            {
                A = Vector.GenerateRandomVector(3, random, -3, 3);
                B = Vector.GenerateRandomVector(3, random, -3, 3);
            } while ((A * B).ScalarProduct(A * B) == 0);
            taskLatex.Add($"\\vec{{a}}=\\left({A.Coordinates[0]},{A.Coordinates[1]},{A.Coordinates[2]}\\right)");
            taskLatex.Add($"\\vec{{b}}=\\left({B.Coordinates[0]},{B.Coordinates[1]},{B.Coordinates[2]}\\right)");
            product = A * B;
            answerLatex.Add($"b)\\left[\\vec{{a}},\\vec{{b}}\\right]=\\left({product.Coordinates[0]},{product.Coordinates[1]},{product.Coordinates[2]}\\right);" +
                $"\\sin{{\\alpha}}=\\frac{{{StringSqrt(product.ScalarProduct(product))}}}{{{StringSqrt(A.ScalarProduct(A))}*{StringSqrt(B.ScalarProduct(B))}}}\\approx {Math.Round(Math.Sqrt((float)product.ScalarProduct(product) / A.ScalarProduct(A) / B.ScalarProduct(B)), 5)}" +
                $";S={StringSqrt(product.ScalarProduct(product))}\\approx {Math.Round(Math.Sqrt(product.ScalarProduct(product)), 5)}");
        }
    }
}
