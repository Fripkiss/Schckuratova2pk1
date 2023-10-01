namespace pz_07;
class Program
static void Main(string[] args)
{
    int[,] arr = new int[8, 8];
    Random random = new Random();

    // Заполнение массива рандомными числами в диапазоне [-50, 50]
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            arr[i, j] = random.Next(-50, 51);
        }
    }
    Console.WriteLine("Матрица arr[8,8]:");
    PrintMatrix(arr);

    Console.WriteLine("\nПобочная диагональ матрицы:");
    int[] diagonal = new int[8];
    for (int t = 0; t < 8; t++)
    {
        diagonal[t] = arr[t, 7 - t];
        Console.Write(diagonal[t] + " ");
    }

    int maxElement = diagonal[0];
    int maxIndex = 0;
    for (int k = 1; k < 8; k++)
    {
        if (diagonal[k] > maxElement)
        {
            maxElement = diagonal[k];
            maxIndex = k;
        }
    }

    Console.WriteLine();
    Console.WriteLine("\nМаксимальный элемент побочной диагонали: " + maxElement);
    Console.WriteLine("\nИндексы максимального элемента: (" + maxIndex + ", " + (7 - maxIndex) + ")");
}

static void PrintMatrix(int[,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write(matrix[x, n] + " ");
        }
        Console.WriteLine();
    }
}
    }
}