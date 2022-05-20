using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_90
    {
        string description = "Найти неизвестные коэффиценты уравнения, удовлетворяющего условиями:";
        Random rnd = new Random();
        int[,] system = new int[3, 2];
        int[,] inter = new int[2, 2];
        string result = "";
        List<int> repeat = new List<int>();
        int a,b,c;

        public Task_90()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        system[i, j] = rnd.Next(-5, 5);
                    }
                    while (repeat.Contains(system[i, j]) || system[i, j] == 0);

                    repeat.Add(system[i, j]);
                }
            }

            inter[0, 0] = (int)(Math.Pow(system[0, 0], 2) - Math.Pow(system[1, 0], 2));
            inter[0, 1] = system[0, 0] - system[1, 0];

            inter[1, 0] = (int)(Math.Pow(system[0, 0], 2) - Math.Pow(system[2, 0], 2));
            inter[1, 1] = system[0, 0] - system[2, 0];

            if ((inter[0, 0] < 0 & inter[1, 0] > 0) || (inter[0, 0] > 0 & inter[1, 0] < 0))
                b = (system[0, 1] * inter[1, 0] + system[1, 1] * inter[0, 0]) / (inter[0, 1] + inter[1, 1]);
            else
                b = (system[0, 1] * inter[1, 0] - system[1, 1] * inter[0, 0]) / (inter[0, 1] - inter[1, 1]);
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetCondition()
        {
            return $"f(x) = ax^2+bx+c \\\\ f({system[0, 0]}) = {system[0, 1]}, f({system[1, 0]}) = {system[1, 1]}, f({system[2, 0]}) = {system[2, 1]}";
        }

        public string GetAnswer()
        {
            result += "\\cases{";
            result += $"{system[0, 0]}^2a + {system[0, 0]}b + c = {system[0, 1]} \\\\";
            result += $"{system[1, 0]}^2a + {system[1, 0]}b + c = {system[1, 1]} \\\\";
            result += $"{system[2, 0]}^2a + {system[2, 0]}b + c = {system[2, 1]}";
            result += "}";
            result += $"\\\\ b = {b} \\\\ {inter[0, 0]} - {inter[0, 1]} / {inter[1, 0]} - {inter[1,1]}";
            return result;
        }
    }
}
