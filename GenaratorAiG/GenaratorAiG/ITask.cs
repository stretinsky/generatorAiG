using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG
{
    internal interface ITask
    {
        string GetDescription();

        List<string> GetCondition();

        string GetAnswer();
    }
}
