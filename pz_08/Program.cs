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
            int[][] arr = new int[10][]; // создаем двумерный массив целых чисел размером 10
            for (int i = 0; i < arr.Length; i++) // генерируем массив
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[j] = new int[random.Next(2, 31)]; // задаем случайный размер для каждого элемента массива
                }
            }

            Console.WriteLine();
            int rndNum;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    rndNum = random.Next(0, 101); // генерируем случайное целое число от 0 до 100
                    arr[i][j] = rndNum;
                    Console.Write(arr[i][j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();

            int[] lastNum = new int[10]; // создаем массив для хранения последнего числа каждого элемента массива arr

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
                int b = arr[i][0]; // сохраняем первое число каждого элемента массива arr в переменную b
                int c = arr[i].Max(); // находим максимальное значение в каждом элементе массива arr и сохраняем его в переменную c
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
                int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                double average = (double)sum / arr[i].Length;
                Console.WriteLine($"Среднее значение в строке {i + 1}: {average}");
            }





        }
    }
}