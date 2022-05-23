using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_70 : Task1_2_58
    {
        public Task1_2_70()
        {
            matrix = new Determinants.Matrix(5, 5);
        }

        public override string GetDescription()
        {
            return "Пользуясь теоремой Лапласа, вычислить определители:";
        }
    }
}
