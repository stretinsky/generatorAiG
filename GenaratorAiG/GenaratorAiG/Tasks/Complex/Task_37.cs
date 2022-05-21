using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    class Task_37
    {
        string description = "Выполнить деление с остатком, найти частное от деления q(x) и остаток r(x) :";
        string condition, answer="алабама";
        public Task_37()
        {
            Random rnd = new Random();
            int n = rnd.Next(3, 5);
            int[] index_big = new int[n+1];
            int[] index_small = new int[3];

            for (int i = 0;i < n+1; i++)
            {
                index_big[i] = rnd.Next(-10, 10);
                if(i==0)
                {
                    if(index_big[i] > 0)
                        condition += $" {index_big[i]}";
                    else
                        condition += $" - {Math.Abs(index_big[i])}";
                }
                else
                {
                    if(i==1)
                    {
                        if (index_big[i] > 0)
                            condition += $" {index_big[i]}x";
                        else
                            condition += $" - {Math.Abs(index_big[i])}x";
                    }
                    else
                    {
                        if (index_big[i] > 0)
                            condition += $" + {index_big[i]}x^{i}";
                        else
                            condition += $" - {Math.Abs(index_big[i])}x^{i}";
                    }
                    
                }
            }
            condition += "\\:\\:\\:\\:\\:\\:\\:\\:Na\\:\\:\\:\\:\\:\\:\\:";
            for (int i = 0; i < 3; i++)
            {
                index_small[i] = rnd.Next(-10, 10);
                if (i == 0)
                {
                    if (index_big[i] > 0)
                        condition += $" {index_big[i]}";
                    else
                        condition += $" - {Math.Abs(index_big[i])}";
                }
                else
                {
                    if (i == 1)
                    {
                        if (index_big[i] > 0)
                            condition += $" + {index_big[i]}x";
                        else
                            condition += $" - {Math.Abs(index_big[i])}x";
                    }
                    else
                    {
                        if (index_big[i] > 0)
                            condition += $" + {index_big[i]}x^{i}";
                        else
                            condition += $" - {Math.Abs(index_big[i])}x^{i}";
                    }

                }
            }



        }
        public string GetDescription()
        {
            return description;
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
