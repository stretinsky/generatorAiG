using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task1_2_68 : Task1_2_58
    {
        public Task1_2_68()
        {
            matrix = new Determinants.Matrix(4, 7);
        }
        public override string GetDescription()
        {
            return "Вычислить определители 4-го порядка методом эффективного по-нижения порядка:";
        }
    }
}
