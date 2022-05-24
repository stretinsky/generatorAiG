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

        string GetCondition();

        string GetAnswer();
    }
}
