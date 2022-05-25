using System;
using System.Collections.Generic;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Task1_2_58: ITask
    {
        protected Matrix matrix { get; set; }
        #region Constructor
        public Task1_2_58(Random random)
        {
            matrix = new Matrix(2, 13, random);
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
        public List<string> GetAnswer()
        {
            List<string> listResult = new List<string>();
            listResult.Add(matrix.GetDeterminant().ToString());
            return listResult;
        }
    }
}
