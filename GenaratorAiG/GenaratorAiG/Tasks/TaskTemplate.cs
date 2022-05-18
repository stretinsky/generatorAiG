using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG
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
        protected string Expression(string rawEquation)
        {
            bool hasStart = false;
            string[] parts = rawEquation.Split('+');
            StringBuilder equation = new StringBuilder();
            foreach(string part in parts)
            {
                if (part[0].Equals('0')) continue;
                if (part[0].Equals('-'))
                {
                    hasStart = true;
                    if (part[1].Equals('1') && part.Length > 2 && !"1234567890".Contains(part[2]))
                        equation.Append("-" + part.Substring(2));
                    else
                        equation.Append("-" + part.Substring(1));
                }
                else
                {
                    if (hasStart)
                        equation.Append('+');
                    else 
                        hasStart = true;
                    if (part[0].Equals('1') && part.Length > 1 && !"1234567890".Contains(part[1]))
                        equation.Append(part.Substring(1));
                    else
                        equation.Append(part);
                }
            }
            return equation.ToString();
        }
    }
}
