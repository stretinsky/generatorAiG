using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Analytic_geometry
{
    class Task_158 : Task
    {
        Random random = new Random();
        public Task_158(int n)
        {
            Description = "Привести к нормальному виду уравнения следующих плоскостей:\n";
            for (int i = 0; i < n; i++) Description += "$";
            GenerateTask(n);
        }
        public Task_158()
        {
            Description = "Привести к нормальному виду уравнения следующих плоскостей:\n";
            for (int i = 0; i < 5; i++) Description += "$";
            GenerateTask(5);
        }
        public void GenerateTask(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = random.Next(-15, 15), y = random.Next(-15, 15), z = random.Next(-15, 15), d = random.Next(-15, 15);
                while (d == 0) d = random.Next(-15, 15);
                taskLatex.Add(letters[i] + ")" + Expression($"{x}x+{y}y+{z}z+{d}") + "=0;");

                int normFctr = x * x + y * y + z * z;
                if (d < 0)
                {
                    string equation = "";
                    if (x > 0) equation += letters[i] + ")" + $"\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    else equation += letters[i] + ")" + $"-\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    if (y > 0) equation += $"+\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    else equation += $"-\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    if (z > 0) equation += $"+\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    else equation += $"-\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    equation += $"-\\sqrt{{{BuildFraction(d * d, normFctr)}}}";
                    AnswerLatex += Expression(equation + "\\\\");
                }
                else 
                {
                    string equation = "";
                    if (x > 0) equation += letters[i] + ")" + $"-\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    else equation += letters[i] + ")" + $"\\sqrt{{{BuildFraction(x * x, normFctr)}}}x";
                    if (y > 0) equation += $"-\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    else equation += $"+\\sqrt{{{BuildFraction(y * y, normFctr)}}}y";
                    if (z > 0) equation += $"-\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    else equation += $"+\\sqrt{{{BuildFraction(z * z, normFctr)}}}z";
                    equation += $"-\\sqrt{{{BuildFraction(d * d, normFctr)}}}";
                    AnswerLatex += Expression(equation + "\\\\");
                }
            }
        }
    }
}
