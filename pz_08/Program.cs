using System;

namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 и 2");
            Console.WriteLine();
            Random random = new Random();
            double[][] arr = new double[10][]; // создаем двумерный массив вещественных чисел размером 10
            for (int i = 0; i < arr.Length; i++) // генерируем массив
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[j] = new double[random.Next(2, 31)]; // задаем случайный размер для каждого элемента массива
                }
            }

            Console.WriteLine();
            double rndNum;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    rndNum = random.NextDouble() * (100 - 0) + 0; // генерируем случайное вещественное число от 0 до 100
                    arr[i][j] = rndNum;
                    Console.Write(arr[i][j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();

            double[] lastNum = new double[10]; // создаем массив для хранения последнего числа каждого элемента массива arr


            for (int i = 0; i < lastNum.Length; i++)
            {
                lastNum[i] = arr[i][^1]; // присваиваем последнее число каждого элемента массива arr соответствующему элементу массива lastNum
                Console.Write(lastNum[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine();

            for (int i = 0; i < lastNum.Length; i++)
            {
                lastNum[i] = arr[i].Max(); // присваиваем элементу массива lastNum максимальное значение из элементов каждого элемента массива arr
                Console.Write(lastNum[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                double b = arr[i][0]; // сохраняем первое число каждого элемента массива arr в переменную b
                double c = arr[i].Max(); // находим максимальное значение в каждом элементе массива arr и сохраняем его в переменную c
                int n = Array.IndexOf(arr[i], c); // находим индекс максимального значения в каждом элементе массива arr и сохраняем его в переменную n
                arr[i][0] = c; // присваиваем первому элементу каждого элемента массива arr значение c
                arr[i][n] = b; // присваиваем элементу массива arr по индексу n значение b
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " "); // выводим элемент массива arr на консоль
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++) // Реверс каждой строки массива
            {
                Array.Reverse(arr[i]);
            }


            for (int i = 0; i < arr.Length; i++) // Вывод массива после реверса
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Задание 7");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                double average = sum / arr[i].Length;
                Console.WriteLine($"Среднее значение в строке {i + 1}: {average}");
            }


        }
    }
}