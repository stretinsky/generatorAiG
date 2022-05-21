using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks
{
    public class Task
    {
        public string Description { get; protected set; }
        public string GetDescription()
        {
            return Description;
        }
        protected List<string> taskLatex = new List<string>();
        public List<string> GetCondition()
        {
            return new List<string>(taskLatex);
        }
        public string AnswerLatex { get; protected set; }
        public string GetAnswer()
        {
            return AnswerLatex;
        }

        protected string Expression(string rawEquation)
        {
            bool hasStart = false;
            string[] parts = rawEquation.Split('+');
            StringBuilder equation = new StringBuilder();
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
                if (parts[i][0].Equals('0')) continue;
                if (parts[i][0].Equals('-'))
                {
                    hasStart = true;
                    if (parts[i][1].Equals('1') && parts[i].Length > 2 && !"1234567890".Contains(parts[i][2]))
                        equation.Append("-" + parts[i].Substring(2));
                    else
                        equation.Append("-" + parts[i].Substring(1));
                }
                else
                {
                    if (hasStart)
                        equation.Append('+');
                    else
                        hasStart = true;
                    if (parts[i][0].Equals('1') && parts[i].Length > 1 && !"1234567890".Contains(parts[i][1]))
                        equation.Append(parts[i].Substring(1));
                    else
                        equation.Append(parts[i]);
                }
            }
            return equation.ToString();
        }
        protected string StringSqrt(int number)
        {
            double a = Math.Sqrt(number);
            if ((int)a == a)
            {
                return ((int)Math.Sqrt(number)).ToString();
            }
            return $"\\sqrt{{{number}}}";
        }
    }
}
