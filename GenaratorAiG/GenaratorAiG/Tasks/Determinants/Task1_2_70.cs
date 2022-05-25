using System;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_70 : Task1_2_58
    {
        public Task1_2_70(Random random) : base(random)
        {
            matrix = new Matrix(5, 5, random);
        }

        public override string GetDescription()
        {
            return "Пользуясь теоремой Лапласа, вычислить определители:";
        }
    }
}
