using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_58
    {
        protected Matrix matrix { get; set; }

        #region Constructor
        public Task1_2_58()
        {
            matrix = new Matrix(2, 13);
        }
        #endregion

        public virtual string GetDescription()
        {
            return "Вычислить определители второго порядка:";
        }
        public string GetCondition()
        {
            return matrix.GetLatex();
        }
        public string GetAnswer()
        {
            return matrix.GetDeterminant().ToString();
        }
    }
}
