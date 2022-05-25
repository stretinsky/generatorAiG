using System;
namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_118 : Task
    {
        public Task_118(Random random)
        {
            Description = "Упростите выражение:\n$$$";
            int[] pm = new int[] { -1, 1 };
            int a0 = pm[random.Next(0, 2)] * random.Next(1, 5), b0 = pm[random.Next(0, 2)] * random.Next(1, 5), c0 = pm[random.Next(0, 2)] * random.Next(1, 5),
                a1 = pm[random.Next(0, 2)] * random.Next(1, 5), b1 = pm[random.Next(0, 2)] * random.Next(1, 5), c1 = pm[random.Next(0, 2)] * random.Next(1, 5);
            taskLatex.Add("a)\\left["+ Expression($"{a0}\\vec{{a}}+{b0}\\vec{{b}},") 
                + Expression($"{a1}\\vec{{a}}+{b1}\\vec{{b}}\\right];"));
            answerLatex.Add($"a){a0 * b1 - a1 * b0}\\left[\\vec{{a}},\\vec{{b}}\\right];");
            a0 = pm[random.Next(0, 2)] * random.Next(1, 5);
            a1 = pm[random.Next(0, 2)] * random.Next(1, 5);
            b0 = pm[random.Next(0, 2)] * random.Next(1, 5);
            b1 = pm[random.Next(0, 2)] * random.Next(1, 5);
            taskLatex.Add("b)\\left[" + Expression($"{a0}\\vec{{a}}+{b0}\\vec{{b}},") 
                + Expression($"{a1}\\vec{{a}}+{b1}\\vec{{b}}\\right];"));
            answerLatex.Add($"b){a0 * b1 - a1 * b0}\\left[\\vec{{a}},\\vec{{b}}\\right];");
            a0 = pm[random.Next(0, 2)] * random.Next(1, 5);
            a1 = pm[random.Next(0, 2)] * random.Next(1, 5);
            b0 = pm[random.Next(0, 2)] * random.Next(1, 5);
            b1 = pm[random.Next(0, 2)] * random.Next(1, 5);
            taskLatex.Add("c)\\left[" + Expression($"{a0}\\vec{{a}}+{b0}\\vec{{b}}+{c0}\\vec{{c}},") 
                + Expression($"{a1}\\vec{{a}}+{b1}\\vec{{b}}+{c1}\\vec{{c}}\\right]"));
            answerLatex.Add($"c)" + Expression($"{a0 * b1 - a1 * b0}\\left[\\vec{{a}},\\vec{{b}}\\right]+" +
                $"{a0 * c1 - a1 * c0}\\left[\\vec{{a}},\\vec{{c}}\\right]+" +
                $"{b0 * c1 - b1 * c0}\\left[\\vec{{b}},\\vec{{c}}\\right]"));
        }
    }
}
