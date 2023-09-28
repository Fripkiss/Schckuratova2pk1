namespace pz_06;
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] arr = new char[10];

        Console.WriteLine("Введите 10 символов для заполнения массива: ");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
        Console.WriteLine();

        char maxElement = GetMaxElement(arr);
        Console.WriteLine("Максимальный элемент массива - " + maxElement);

        Array.Sort(arr);
        Console.WriteLine("Элементы массива в порядке возрастания: ");
        foreach (char element in arr)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine();
    }

    static char GetMaxElement(char[] arr)
    {
        char max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}