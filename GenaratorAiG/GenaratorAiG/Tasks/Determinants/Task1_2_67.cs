using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_67 : Task1_2_58
    {
        public Task1_2_67(Random random) : base(random)
        {
            matrix = new Matrix(4, 7, random);
        }
        public override string GetDescription()
        {
            return "Вычислить определители четвертого порядка, пользуясь теоремой о разложении:";
        }
    }
}
