using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquationProgram
{
    public class QuadEquation
    {
        public static void Main(string[] args)
        {
            (float a, float b, float c) = ReadInput();
            Solve(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите Enter.");
            Console.ReadKey();
        }

        public static (float, float, float) ReadInput()
        {
            //Объявляем переменные и вводим для них значения
            Console.Write("Введите а: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите c: ");
            float c = Convert.ToSingle(Console.ReadLine());

            return (a, b, c);
        }

        public static (float, float) Solve(float a, float b, float c)
        {
            //Определяем тип уравнения и решаем его
            if (c == 0 || b == 0)
            {
                if (c == 0)
                {
                    float x1 = 0;
                    float x2 = -b / a;

                    Console.WriteLine();
                    Console.WriteLine("x1 = " + Math.Round(x1, 2) + "; " + "x2 = " + Math.Round(x2, 2) + ";"); //Выводим корни в консоль
                    return (x1, x2);
                }
                else
                {
                    Console.WriteLine();
                    float x1 = Convert.ToSingle(Math.Sqrt(-c / a));
                    float x2 = Convert.ToSingle(-Math.Sqrt(-c / a));
                    Console.WriteLine("x1 = " + Math.Round(x1, 2) + "; " + "x2 = " + Math.Round(x2, 2) + ";"); //Выводим корни в консоль
                    return (x1, x2);
                }
            }

            else
            {
                //Находим дискриминант
                float d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Корней нет.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Дискриминант = " + d);
                    Console.WriteLine();
                    float x1 = (-b - Convert.ToSingle(Math.Sqrt(d))) / 2 * a;
                    float x2 = (-b + Convert.ToSingle(Math.Sqrt(d))) / 2 * a;
                    Console.WriteLine("x1 = " + Math.Round(x1, 2) + "; " + "x2 = " + Math.Round(x2, 2) + ";"); //Выводим корни в консоль
                    return (x1, x2);
                }
            }
            return (0, 0);
        }
    }
}
