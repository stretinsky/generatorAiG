using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks
{
    public class Task : ITask
    {
        protected string letters = "abcdefghijklmnopqrstuvwxyz";
        public string Description { get; protected set; }
        public string GetDescription()
        {
            return Description;
        }
        protected List<string> taskLatex = new List<string>();
        protected List<string> answerLatex = new List<string>();
        public List<string> GetCondition()
        {
            return new List<string>(taskLatex);
        }
        public List<string> GetAnswer()
        {
            return new List<string>(answerLatex);
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
        protected int[] ReduceFraction(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            if (a == 0) return new int[] { a, b };
            bool isPositive = false;
            if ((float)a / b > 0) isPositive = true;

            if (a < 0) a = -a;
            if (b < 0) b = -b;
            int m = a, n = b;
            while (m != n)
            {
                if (m > n)
                    m -= n;
                else
                    n -= m;
            }
            a /= n;
            b /= n;
            if (isPositive) return new int[] { a, b };
            return new int[] { -a, b };
        }
        protected string BuildFraction(int[] numerator, int[] denominator)
        {
            int numProduct = 1, denProduct = 1;
            foreach (int n in numerator)
                numProduct *= n;
            foreach (int n in denominator)
                denProduct *= n;
            int[] fraction = ReduceFraction(numProduct, denProduct);
            if (fraction[1] == 1)
            {
                return fraction[0].ToString();
            }
            else if (fraction[0] == 0) return "0";
            return $"\\frac{{{fraction[0]}}}{{{fraction[1]}}}";
        }
        protected string BuildFraction(int numerator, int denominator)
        {
            return BuildFraction(new int[] { numerator }, new int[] { denominator });
        }
    }
}
