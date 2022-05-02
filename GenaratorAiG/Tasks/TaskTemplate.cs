using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public abstract class TaskTemplate
    {
        //Будет показано в конструкторе КР
        public string Name { get; protected set; }
        //Условие задачи. Чтобы показать, где будет находиться формула, используйте разделительный знак $
        public string Description { get; protected set; }
        protected List<string> taskLatex = new List<string>();
        public List<string> GetTaskLatex() 
        {
            return new List<string>(taskLatex);
        }
        public string AnswerLatex { get; protected set; }
        protected string Expression(int coefficient, string variable)//лютый хардкод, если сможете сделать красивее - будет хорошо
        {
            if (coefficient == 0) return "";
            if (variable.Equals("+") && coefficient > 0) return "+" + coefficient;
            if (variable.Equals("+") && coefficient < 0) return coefficient.ToString();
            if (coefficient == -1) return "-" + variable.Replace("+", "");
            if (variable.Contains("+"))
            {
                variable = variable.Replace("+", "");
                if (coefficient == 1) return "+" + variable;
                if (coefficient > 0) return "+" + coefficient + variable;
                return coefficient + variable;
            }
            else
            {
                if (coefficient == 1) return variable;
                if (coefficient > 0) return coefficient + variable;
                return coefficient + variable;
            }
        }
    }
}
