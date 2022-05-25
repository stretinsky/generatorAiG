using System;
using LinearAlgebraAndCo;

namespace GenaratorAiG.Tasks.Complex
{
    public class Task_4 : Task
    {
        public Task_4(Random random)
        {
            Description = "Найти действительные значения x и y, при которых комплексные числа являются\n$сопряженными\n$равны.";

            int x1 = random.Next(-10, 10), x2 = random.Next(-10, 10),
                y1 = random.Next(-10, 10), y2 = random.Next(-10, 10);
            answerLatex.Add($"a)\\;\\;\\;(x={x1},{x2};y={y1},{y2})");

            Polynomial real = new Polynomial();
            real.SetRoots(x1, x2);
            int[] r = real.GetIntCoefficients();
            Polynomial im = new Polynomial();
            im.SetRoots(y1, y2);
            int[] i = im.GetIntCoefficients();

            int a0 = random.Next(-2, 2), a1 = random.Next(-6, 6), a2 = random.Next(-6, 6),
                b0 = random.Next(-2, 2), b1 = random.Next(-6, 6), b2 = random.Next(-6, 6);

            string taskA = "a)\\;\\;\\;z_1=" + Expression($"{a0}x^2+{a1}x+{a2}+{b0}y^2i+{b1}yi+{b2}i") +
                ",\\;\\;\\;z_2=" +
                Expression($"{a0 - r[2]}x^2+{a1 - r[1]}x+{a2 - r[0]}+{i[2] - b0}y^2i+{i[1] - b1}yi+{i[0] - b2}i");

            x1 = random.Next(-10, 10); x2 = random.Next(-10, 10);
            y1 = random.Next(-10, 10); y2 = random.Next(-10, 10);
            answerLatex.Add($"b)\\;\\;\\;(x={x1},{x2};y={y1},{y2})");

            real = new Polynomial();
            real.SetRoots(x1, x2);
            r = real.GetIntCoefficients();
            im = new Polynomial();
            im.SetRoots(y1, y2);
            i = im.GetIntCoefficients();

            a0 = random.Next(-2, 2); a1 = random.Next(-6, 6); a2 = random.Next(-6, 6);
            b0 = random.Next(-2, 2); b1 = random.Next(-6, 6); b2 = random.Next(-6, 6);

            string taskB = "b)\\;\\;\\;z_1=" + Expression($"{a0}x^2+{a1}x+{a2}+{b0}y^2i+{b1}yi+{b2}i") +
                ",\\;\\;\\;z_2=" +
                Expression($"{a0 - r[2]}x^2+{a1 - r[1]}x+{a2 - r[0]}+{b0 - i[2]}y^2i+{b1 - i[1]}yi+{b2 - i[0]}i");

            taskLatex.Add(taskA);
            taskLatex.Add(taskB);
        }
    }
}
