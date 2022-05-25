using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Determinants
{
    public class Matrix
    {
        private double[][] matrix;
        private int dimension;
        private IEnumerable<string> rows
        {
            get
            {
                for (int i = 0; i < dimension; i++)
                {
                    yield return string.Join(@" & ", this[i]);
                }
            }
        }

        public Matrix(int dimension, int maxNumber, Random rnd)
        {
            matrix = new double[dimension][];
            this.dimension = dimension;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new double[dimension];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rnd.Next(maxNumber + 1) * Math.Pow(-1, rnd.Next(2));
                }
            }
        }

        public int GetDeterminant()
        {
            double det = 1;
            const double EPS = 1E-9;
            double[][] a = new double[dimension][];
            for (int i = 0; i < matrix.Length; i++)
            {
                a[i] = matrix[i].ToArray();
            }
            double[][] b = new double[1][];
            b[0] = new double[dimension];
            //проходим по строкам
            for (int i = 0; i < dimension; ++i)
            {
                //присваиваем k номер строки
                int k = i;
                //идем по строке от i+1 до конца
                for (int j = i + 1; j < dimension; ++j)
                    //проверяем
                    if (Math.Abs(a[j][i]) > Math.Abs(a[k][i]))
                        //если равенство выполняется то k присваиваем j
                        k = j;
                //если равенство выполняется то определитель приравниваем 0 и выходим из программы
                if (Math.Abs(a[k][i]) < EPS)
                {
                    det = 0;
                    break;
                }
                //меняем местами a[i] и a[k]
                b[0] = a[i];
                a[i] = a[k];
                a[k] = b[0];
                //если i не равно k
                if (i != k)
                    //то меняем знак определителя
                    det = -det;
                //умножаем det на элемент a[i][i]
                det *= a[i][i];
                //идем по строке от i+1 до конца
                for (int j = i + 1; j < dimension; ++j)
                    //каждый элемент делим на a[i][i]
                    a[i][j] /= a[i][i];
                //идем по столбцам
                for (int j = 0; j < dimension; ++j)
                    //проверяем
                    if ((j != i) && (Math.Abs(a[j][i]) > EPS))
                        //если да, то идем по k от i+1
                        for (k = i + 1; k < dimension; ++k)
                            a[j][k] -= a[i][k] * a[j][i];
            }
            return (int)Math.Round(det);
        }
        public string GetLatex()
        {
            return @"\left|\matrix{" + string.Join(@"\\", rows) + @"}\right|";
        }
        public int this[int i, int j]
        {
            get
            {
                return (int)Math.Round(matrix[i][j]);
            }
            set
            {
                matrix[i][j] = value;
            }
        }
        public IEnumerable<int> this[int i]
        {
            get
            {
                foreach (float value in matrix[i])
                {
                    yield return (int)Math.Round(value);
                }
            }
        }
    }    
}

