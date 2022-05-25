using System;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_60 : Task1_2_58
    {
        public Task1_2_60(Random random) : base(random)
        {
            matrix = new Matrix(3, 8, random);
        }

        public override string GetDescription()
        {
            return "Вычислить определители третьего порядка:";
        }
    }
}
