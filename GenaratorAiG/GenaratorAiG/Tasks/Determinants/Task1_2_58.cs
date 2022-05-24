using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_58: ITask
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
        public List<string> GetCondition()
        {
            string condition = matrix.GetLatex();
            List<string> formules = new List<string>();
            formules.Add(condition);
            return formules;
        }
        public string GetAnswer()
        {
            return matrix.GetDeterminant().ToString();
        }
    }
}
