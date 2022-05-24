using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_60 : Task1_2_58, ITask
    {
        public Task1_2_60()
        {
            matrix = new Matrix(3, 8);
        }

        public override string GetDescription()
        {
            return "Вычислить определители третьего порядка:";
        }
    }
}
