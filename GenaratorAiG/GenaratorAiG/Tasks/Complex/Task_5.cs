using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    struct number
    {
       public int a;
       public int b;
    }
    class Task_5
    {
        number x, y, z;
        string desciption = "Найти действительные x и y из уравнений:", condition = "", answer = "";
        public Task_5()
        {
            Random rnd = new Random();
            x.a = rnd.Next(-10, 10);
            x.b = rnd.Next(-10, 10);
            y.a = rnd.Next(-10, 10);
            y.b = rnd.Next(-10, 10);
            z.a = rnd.Next(-10, 10);
            z.b = rnd.Next(-10, 10);
            condition = $"({x.a}" + (x.b > 0 ? $" + {x.b}i" : $" - {Math.Abs(x.b)}i)x") + $" + ({y.a}" + (y.b > 0 ? $" + {y.b}i" : $" - {Math.Abs(y.b)}i)y") + $" = {z.a}" + (z.b > 0 ? $" + {z.b}i" : $" - {Math.Abs(z.b)}i") ;
            answer += $"({x.a}x" + (y.a > 0? $" + {y.a}y": $" - {Math.Abs(y.a)}y") + (z.a > 0 ? $" + {z.a}" : $" - {Math.Abs(z.a)})");
            answer += $" + ({x.b}x" + (y.b > 0 ? $" + {y.b}y" : $" - {Math.Abs(y.b)}y") + (z.b > 0 ? $" + {z.b}" : $" - {Math.Abs(z.b)})i");
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
