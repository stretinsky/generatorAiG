using System;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_158 : Task
    {
        public Task_158(int n, Random random)
        {
            Description = "Привести к нормальному виду уравнения следующих плоскостей:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n, random);
        }
        public Task_158(Random random)
        {
            Description = "Привести к нормальному виду уравнения следующих плоскостей:\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5, random);
        }
        public void GenerateTask(int n, Random random)
        {
            for (int i = 0; i < n; i++)
            {
                int x = random.Next(-15, 15), y = random.Next(-15, 15), z = random.Next(-15, 15), d = random.Next(-15, 15);
                while (d == 0) d = random.Next(-15, 15);
                taskLatex.Add(letters[i] + ")" + Expression($"{x}x+{y}y+{z}z+{d}") + "=0;");

                int normFctr = x * x + y * y + z * z;
                string equation = "";
                if (d < 0)
                {
                    if (x > 0) equation += letters[i] + ")" + $"\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    else equation += letters[i] + ")" + $"-\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    if (y > 0) equation += $"+\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    else equation += $"-\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    if (z > 0) equation += $"+\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    else equation += $"-\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    
                }
                else
                {
                    if (x > 0) equation += letters[i] + ")" + $"-\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    else equation += letters[i] + ")" + $"\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    if (y > 0) equation += $"-\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    else equation += $"+\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    if (z > 0) equation += $"-\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    else equation += $"+\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                }
                equation += $"-\\sqrt{{{BuildFraction(d * d, normFctr)}}};";
                answerLatex.Add(Expression(equation));
            }
        }
    }
}