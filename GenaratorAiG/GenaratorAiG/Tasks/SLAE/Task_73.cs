using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.SLAE
{
    internal class Task_73: ITask
    {
        string description = "Найти линейные комбинации матрицы:";
        int[,] matrixA, matrixB, resultM;
        Random rnd = new Random();
        int length, choice, indexA, indexB;
        string condition, result;
        int[] zero = new int[1] { 0 };

        public Task_73()
        {
            length = rnd.Next(3, 5);
            matrixA = new int[3, length];
            matrixB = new int[3, length];
            resultM = new int[3, length];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    do
                    {
                        matrixA[i, j] = rnd.Next(-10, 10);
                    }
                    while (matrixA[i, j] == 0);

                    do
                    {
                        matrixB[i, j] = rnd.Next(-10, 10);
                    }
                    while (matrixB[i, j] == 0);
                }
            }

            if (length != 3)
                choice = 2;
            else
                choice = rnd.Next(3); //0,1 и 2

            indexA = rnd.Next(2, 6);
            indexB = rnd.Next(2, 6);
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            switch (choice)
            {
                case 0:
                    {
                        condition += $"{indexA}A - {indexB}B - \\lambda E, ";

                        //Матрица А
                        condition += $"A = \\pmatrix{{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                condition += matrixA[i, j] + " & ";
                            }

                            if (i == 2)
                                continue;

                            condition += "\\\\";
                        }
                        condition += "}, ";

                        //Матрица B
                        condition += $"B = \\pmatrix{{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                condition += matrixB[i, j] + " & ";
                            }

                            if (i == 2)
                                continue;

                            condition += "\\\\";
                        }
                        condition += "}, ";

                        return condition;
                    }
                case 1:
                    {
                        condition += $"{indexA}A - \\lambda E, ";

                        //Матрица А
                        condition += $"A = \\pmatrix{{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                condition += matrixA[i, j] + " & ";
                            }

                            if (i == 2)
                                continue;

                            condition += "\\\\";
                        }
                        condition += "}, ";

                        return condition;
                    }
                case 2:
                    {
                        condition += $"{indexA}A - {indexB}B, ";

                        //Матрица А
                        condition += $"A = \\pmatrix{{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                condition += matrixA[i, j] + " & ";
                            }

                            if (i == 2)
                                continue;

                            condition += "\\\\";
                        }
                        condition += "}, ";

                        //Матрица B
                        condition += $"B = \\pmatrix{{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                condition += matrixB[i, j] + " & ";
                            }

                            if (i == 2)
                                continue;

                            condition += "\\\\";
                        }
                        condition += "}, ";

                        return condition;
                    }
                default:
                    {
                        Console.WriteLine("Сработал блок default в методе GetCondition (Task_73)");
                        break;
                    }
            }

            return "Ошибка в методе GetCondition (Task_73)";
        }
        public string GetAnswer()
        {
            switch (choice)
            {
                case 0:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                resultM[i, j] = indexA * matrixA[i, j] - indexB * matrixB[i, j];
                            }
                        }

                        result += "\\pmatrix{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                result += resultM[i, j];

                                if (i == j)
                                    result += "-\\lambda";

                                if (j == length - 1)
                                    continue;

                                result += " & ";
                            }

                            if (i == 2)
                                continue;

                            result += "\\\\";
                        }
                        result += "}";

                        return result;
                    }
                case 1:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                resultM[i, j] = indexA * matrixA[i, j];
                            }
                        }

                        result += "\\pmatrix{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                result += resultM[i, j];

                                if (i == j)
                                    result += "-\\lambda";

                                if (j == length - 1)
                                    continue;

                                result += " & ";
                            }

                            if (i == 2)
                                continue;

                            result += "\\\\";
                        }
                        result += "}";

                        return result;
                    }
                case 2:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                resultM[i, j] = indexA * matrixA[i, j] - indexB * matrixB[i, j];
                            }
                        }

                        result += "\\pmatrix{";
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < length; j++)
                            {
                                result += resultM[i, j];

                                if (j == length - 1)
                                    continue;

                                result += " & ";
                            }

                            if (i == 2)
                                continue;

                            result += "\\\\";
                        }
                        result += "}";

                        return result;
                    }
                default:
                    {
                        Console.WriteLine("Сработал блок default в методе GetAnswer (Task_73)");
                        break;
                    }
            }

            return "Ошибка в методе GetAnswer (Task_73)";
        }
    }
}
