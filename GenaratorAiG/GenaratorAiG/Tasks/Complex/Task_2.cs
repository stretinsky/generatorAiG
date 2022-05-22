using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    internal class Task_2
    {
        string description = "Вычислить i^n, где n– натуральное число";
        string result = "";
        public Task_2()
        {

        }
        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return description;
        }
        public string GetAnswer()
        {
            result += "i = \\Bigg{ 1; если n=   4k; \n -i; если n=  4k1; \n -1; еслиn=  4k2; \n i; если n= 4k; где k– произвольное натуральное число. ";
            return result;
        }
    }

}

