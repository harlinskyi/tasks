using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///            // #77 вычисляет частное двух чисел
            ///            Console.WriteLine("[1] Введите число: ");
            ///            int num1 = Convert.ToInt32(Console.ReadLine());
            ///            Console.WriteLine("[2] Введите делитель: ");
            ///            int num2 = Convert.ToInt32(Console.ReadLine());
            ///            if (num2 <= 0 || num2 > num1)
            ///            {
            ///         Console.WriteLine("Делитель не может быть: меньше или равно 0, больше деленного.");
            ///            }
            ///            else
            ///            {
            ///         int result = num1 / num2;
            ///         Console.WriteLine($"{num1} / {num2} = {result}");
            ///            }

            ///      // #78 вычисляет частное двух чисел
            ///      Console.WriteLine("[1] Введите радиус кольца (см): ");
            ///      double num1 = Convert.ToDouble(Console.ReadLine());
            ///      Console.WriteLine("[2] Введите радиус отверстия (см): ");
            ///      double num2 = Convert.ToDouble(Console.ReadLine());
            ///      if (num2 > num1)
            ///      {
            ///          Console.WriteLine("Ошибка! Радиус отверстия не может быть больше радиуса кольца.");
            ///      }
            ///      else
            ///      {
            ///          double result = 2 * 3.14 * (num1 - num2);
            ///          Console.WriteLine($"Площадь кольца: {result}");
            ///      }

            ///      // #79 переводит время из минут и секунд в секунды
            /// Console.WriteLine("Введите время (минут.секунд): ");
            /// double num1 = Convert.ToDouble(Console.ReadLine());

            ///      // #80 проверяет, является ли год високосным
            /// Console.WriteLine("Введите год, например 2000, и нажмите <Enter>");
            /// int year = Convert.ToInt32(Console.ReadLine());
            /// if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
            /// {
            ///     Console.WriteLine("Обычный");
            /// }
            /// else {
            ///     Console.WriteLine("Високосный");
            /// }

            /// // #81 у вычисления сопротивления электрической цепи
            /// 
            /// Console.WriteLine("Введите исходные данные");
            /// Console.Write("Величина первого сопротивления (Ом): ");
            /// double num1 = Convert.ToInt32(Console.ReadLine());
            /// Console.Write("Величина второго сопротивления (Ом): ");
            /// double num2 = Convert.ToInt32(Console.ReadLine());
            /// Console.Write("Тип соединения (1 — последовательное, 2 — параллельное): ");
            /// double num3 = Convert.ToInt32(Console.ReadLine());
            /// if (num3 == 1)
            /// {
            ///     double result = num1 + num2:;
            ///     Console.WriteLine($"Сопротивление цепи: {result} Ом");
            /// }
            /// if (num3 == 2)
            /// {
            ///     double result = (num1 * num2) / (num1 + num2);
            ///     Console.WriteLine($"Сопротивление цепи: {result} Ом");
            /// }

            /// // #105 которая выводит таблицу квадратов первых десяти целых положительных чисел
            /// Console.WriteLine("Таблица квадратов.");
            /// Console.WriteLine("-----------------");
            /// Console.WriteLine("Число\tКвадрат.");
            /// for (int i = 1; i <= 10; i++)
            /// {
            ///     Console.WriteLine($"{i}\t{i*i}");
            /// }
            /// Console.WriteLine("-----------------");
            /// 

            /// // #106 выводит таблицу квадратов первых пяти целых положительных нечетных чисел
            /// Console.WriteLine("Таблица квадратов.");
            /// Console.WriteLine("-----------------");
            /// Console.WriteLine("Число\tКвадрат.");
            /// for (int i = 1; i <= 10; i++)
            /// {
            ///     if (i % 2 != 0)
            ///     {
            ///         Console.WriteLine($"{i}\t{i * i}");
            ///     }
            /// }
            /// Console.WriteLine("-----------------");

            /// // #107 вычисляет сумму первых пцелых положительных целых чисел
            /// Console.WriteLine("Вычисление суммы положительных чисел.");
            /// Console.Write("Введите количество суммируемых чисел: ");
            /// int num1 = Convert.ToInt32(Console.ReadLine());
            /// int result = 0;
            /// for (int i = 1; i <= num1; i++)
            /// {
            ///     result += i;
            /// }
            /// Console.WriteLine($"Сумма первых {num1} положительных чисел равна {result}");

            /// // #108 которая вычисляет сумму первых n целых положительных четных целых чисел
            /// Console.WriteLine("Вычисление суммы четных положительных чисел.");
            /// Console.Write("Введите количество суммируемых чисел: ");
            /// int num1 = Convert.ToInt32(Console.ReadLine());
            /// int result = 0;
            /// for (int i = 1; i <= num1*2; i++)
            /// {
            ///     if (i % 2 == 0)
            ///     {
            ///         result += i;
            ///     }
            /// }
            /// Console.WriteLine($"Сумма первых {num1} положительных четных чисел равна {result}");

            /// // #143 вводит с клавиатуры одномерный массив из 5 целых чисел
            /// Console.WriteLine("Ввод массива целых чисел.");
            /// Console.WriteLine("После ввода каждого числа нажмите <Enter>");
            /// Console.Write("Количество елементов массива?: ");
            /// int countZero = 0;
            /// int countArray = Convert.ToInt32(Console.ReadLine());
            /// for (int i = 1; i <= countArray;i++)
            /// {
            ///     Console.Write($"а[{i}]: ");
            ///     int tmp = Convert.ToInt32(Console.ReadLine());
            ///     if (tmp == 0)
            ///     {
            ///         countZero += 1;
            ///     }
            /// }
            /// Console.WriteLine($"В массиве {countZero} ненулевых элемента");

        }
    }
}
