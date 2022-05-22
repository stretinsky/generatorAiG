using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaratorAiG.Tasks.Complex
{
    internal class Task_3
    {
        string description = "Представитьzв алгебраической форме";
        private int o, t, f, four, five, six, seven;
        private int o1, t1, f1, four1, five1, six1, seven1;
        private int index;
        double a1;
        //private double[] trigonometry = new double[] { Math.PI / 3, Math.PI / 4, Math.PI / 5, Math.PI / 6, Math.PI / 7, Math.PI / 8, Math.PI / 9, Math.PI / 10 };
        private int[] array_f = new int[] { 173, 100, 72, 57, 48, 41, 36, 32 };
        double i = Math.Sqrt(-1);

        public class Complex
        {
            Complex(int a, int b)
            {
                int imaginary = a;
                int real = b;
            }
        }



        public Task_3()
        {
            Random rnd = new Random();
            o = rnd.Next(-100, 100);
            t = rnd.Next(-100, 100);
            f = rnd.Next(-100, 100);
            four = rnd.Next(-100, 100);
            five = rnd.Next(-100, 100);
            six = rnd.Next(-100, 100);
            seven = rnd.Next(-100, 100);



            o1 = rnd.Next(-100, 100);
            t1 = rnd.Next(-100, 100);
            f1 = rnd.Next(-100, 100);
            four1 = rnd.Next(-100, 100);
            five1 = rnd.Next(-100, 100);
            six1 = rnd.Next(-100, 100);
            seven1 = rnd.Next(-100, 100);






            Complex operator +(const Complex &c);
            Complex operator *(const Complex &c);
            Complex operator -(const Complex &c);
            Complex operator / (const Complex &c);
            bool operator == (const Complex &c);

            const Complex& operator = (const Complex &c)
            {
                comp.a = c.comp.a;
                comp.b = c.comp.b;
                return *this;
            }

            Complex Complex::operator +(const Complex &c)
            {
                Complex d;
                d.comp.a = comp.a + c.comp.a;
                d.comp.b = comp.b + c.comp.b;
                return d;
            }
            Complex Complex::operator *(const Complex &c)
            {
                Complex t;
                t.comp.a = comp.a * c.comp.a - comp.b * c.comp.b;
                t.comp.b = comp.a * c.comp.b + comp.b * c.comp.a;
                return t;
            }
            Complex Complex::operator / (const Complex &c)
            {
                Complex t;
                t.comp.a = (comp.a * c.comp.a + comp.b * c.comp.b) / (comp.a * comp.a + comp.b * comp.b);
                t.comp.b = (comp.b * c.comp.a - comp.a * c.comp.b) / (comp.a * comp.a + comp.b * comp.b);
                return t;
            }
            Complex Complex::operator -(const Complex &c)
           {
                Complex y;
                y.comp.a = comp.a - c.comp.a;
                y.comp.b = comp.b - c.comp.b;
                return y;
            }
            bool Complex::operator == (const Complex &c)
            {
                if ((comp.a == c.comp.a) && (comp.b == c.comp.b))
                    return true;
                return false;
            }
            Complex Complex::conj()
            {
                comp.a = comp.a;
                comp.b = -comp.b;
                return *this;
            }
            void Complex::Display()
            {
                if (comp.b >= 0)
                    cout << comp.a << "+" << comp.b << "i\n";
                else
                    cout << comp.a << comp.b << "i\n";
            }
            Complex Complex::Read()
            {
                double x, y;
                cout << "Действительнвая часть: ";
                cin >> x;
                cout << "Мнимая часть:        : ";
                cin >> y;
                Complex A = Complex(x, y);
                return A;
            }
            //-----------------------------------------------------------
            void execute()
            {
                cout << " Задание: \n";
                cout << " Реализовать класс Complex для работы с комплексными числами.\n";
                cout << " Комплексное число представляются парой действительных чисел (a, b), где\n";
                cout << "     a — действительная часть, b — мнимая часть. \n";
                cout << " Реализовать операции:\n";
                cout << " - сложения\n";
                cout << " - вычитания\n";
                cout << " - умножения\n";
                cout << " - деления\n";
            }
            int chois()
            {
                int chois_1;
                cout << "     Операции комплексными числами\n";
                cout << " 1 - Сложение\n";
                cout << " 2 - Вычитание\n ";
                cout << " 3 - Умножение\n";
                cout << " 4 - Деление\n";
                cout << " 5 - Сравнение\n";
                cout << " 6 - Сопреженное число\n";
                cout << " 0 - Выход\n\n";
                cout << "\n Выберите действие : \n";
                cin >> chois_1;
                while ((chois_1 < 0) || chois_1 >)
                {
                    cout << "     !!!Не корректные данные!!!\n";
                    cout << " Ведите заново : ";
                    cin >> chois_1;
                }
                return chois_1;
            }
            void choise()
            {
                switch (chois())
                {
                    case 1:
                        {
                            Complex a, b;
                            cout << "Первое число:\n";
                            a = a.Read();
                            cout << "Второе число:\n";
                            b = b.Read();
                            Complex c = a + b;
                            c.Display();
                            break;
                        }
                    case 2:
                        {
                            Complex a, b;
                            cout << "Первое число:\n";
                            a = a.Read();
                            cout << "Второе число:\n";
                            b = b.Read();
                            Complex c = a - b;
                            c.Display();
                            break;
                        }
                    case 3:
                        {
                            Complex a, b;
                            cout << "Первое число:\n";
                            a = a.Read();
                            cout << "Второе число:\n";
                            b = b.Read();
                            Complex c = a * b;
                            c.Display();
                            break;
                        }
                    case 4:
                        {
                            Complex a, b;
                            cout << "Первое число:\n";
                            a = a.Read();
                            cout << "Второе число:\n";
                            b = b.Read();
                            Complex c = a / b;
                            c.Display();
                            break;
                        }
                    case 5:
                        {
                            Complex a, b;
                            cout << "Первое число:\n";
                            a = a.Read();
                            cout << "Второе число:\n";
                            b = b.Read();
                            if (a == b)
                                cout << "Колексные числа равны\n";
                            else cout << "Коплексные числа не равны\n";
                            break;
                        }
                    case 6:
                        {
                            Complex a;
                            cout << "Комплексное число : \n";
                            a = a.Read();
                            cout << "Комплексное число : ";
                            a.Display();
                            Complex c = a.conj();
                            cout << "\nСопреженное комплексное число :";
                            c.Display();
                            break;
                        }
                    default: exit(0);
                }
                system("pause");
                system("cls");
                choise();

            }
            //-----------------------------------------------------------







            a = ((o * Math.Pow(i, o1) + t * Math.Pow(i, t1)) / (f * Math.Pow(i, f1))) - ((five * Math.Pow(i, five1) + six * Math.Pow(i, six1)) / ((seven * Math.Pow(i, seven1) - four * Math.Pow(i, four1))));






        }
        public string GetDescription()
        {
            return description;
        }
        public string GetCondition()
        {
            return $"z = [({o} * i ^ {o1} + {t} * i ^ {t1}) / ({f} * i ^ {f1})] - [ ({five} * i ^ {five1} + {six} * i ^ {six1}) / ({seven} * i ^ {seven1} - {four} * i ^ {four1} ] ";
        }
        public string GetAnswer()
        {
            return $"{a}";
        }
    }
}
