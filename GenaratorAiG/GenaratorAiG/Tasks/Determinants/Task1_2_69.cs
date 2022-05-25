﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_69 : Task1_2_58
    {
        public Task1_2_69(Random random) : base(random)
        {
            matrix = new Matrix(5, 5, random);
        }
        public override string GetDescription()
        {
            return "Вычислить определители 5-го порядка методом эффективного по-нижения порядка:";
        }
    }
}
