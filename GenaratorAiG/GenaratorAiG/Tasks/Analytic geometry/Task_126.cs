using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    struct Point
    {
        public int x;
        public int y;
        public int z;
    }
    class Task_126: ITask
    {
        Point A, B, C, D;
        string desciption = "Проверить, что точки A, B, C, D лежат в одной плоскости", condition = "", answer = "";
        public Task_126()
        {
            Random rnd = new Random();
            A.x = rnd.Next(-10, 10);
            A.y = rnd.Next(-10, 10);
            A.z = rnd.Next(-10, 10);
            B.x = rnd.Next(-10, 10);
            B.y = rnd.Next(-10, 10);
            B.z = rnd.Next(-10, 10);
            C.x = rnd.Next(-10, 10);
            C.y = rnd.Next(-10, 10);
            C.z = rnd.Next(-10, 10);
            D.x = rnd.Next(-10, 10);
            D.y = rnd.Next(-10, 10);
            D.z = rnd.Next(-10, 10);
            int a, b, c, d, e, f, g, h, i;
            a = B.x - A.x;
            b = B.y - A.y;
            c = B.z - A.z;
            d = C.x - A.x;
            e = C.y - A.y;
            f = C.z - A.z;
            g = D.x - A.x;
            h = D.y - A.y;
            i = D.z - A.z;
            //condition = $"\\pmatrix{{{a} & {b} & {c} \\\\ {d} & {e} & {f} \\\\ {g} & {h} & {i} }}";
            condition = $"A({A.x},{A.y},{A.z}) \\: B({B.x},{B.y},{B.z}) \\: C({C.x},{C.y},{C.z}) \\: D({D.x},{D.y},{D.z}) \\:";
            int det = a * e * i + g * b * f + d * h * c - c * e * g - d * b * i - h * a * f;
            if (det == 0)
                answer = "YES";
            else
                answer = "NO";

        }
        public string GetDescription()
        {
            return desciption;
        }
        public string GetCondition()
        {
            return condition;
        }
        public string GetAnswer()
        {
            return answer;
        }
    }
}
