using System;

namespace Практическая_10
{
    class Program
    {

        static void zad13()
        {
            try
            {


                Console.WriteLine("Введите число сотрудников");
                int sotr = Convert.ToInt32(Console.ReadLine());

                int[,] mas = new int[sotr, 12];

                Random rm = new Random();

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {

                        mas[i, j] = rm.Next(100, 200);
                        Console.Write("{0} ", mas[i, j]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Введите номер сотрудника");
                int numbers = Convert.ToInt32(Console.ReadLine());

                if (numbers > sotr && numbers <= 0)
                    Console.WriteLine("Такого сотрудника нет");
                int sum = 0;

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        sum += mas[i, j];

                    }

                }

                Console.WriteLine($"Сумма за все {sum}");
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }
            }

        static void zad14()
        {

            int[,] mas = new int[0,0];
        }
        static void Main(string[] args)
            {
            zad13();
            zad14();
        }

        
    }
}