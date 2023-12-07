namespace pz_14;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите путь к первому файлу:");
        string filePath1 = Console.ReadLine();
        Console.WriteLine("Введите путь ко второму файлу:");
        string filePath2 = Console.ReadLine();
        Console.WriteLine("Введите путь к файлу для записи результата:");
        string outputFilePath = Console.ReadLine();

        MergeFiles(filePath1, filePath2, outputFilePath);

        Console.WriteLine("Слияние выполнено успешно!");
    }

    static void MergeFiles(string filePath1, string filePath2, string outputFilePath)
    {
        string[] lines1 = File.ReadAllLines(filePath1);
        string[] lines2 = File.ReadAllLines(filePath2);

        using (StreamWriter sw = new StreamWriter(outputFilePath))
        {
            for (int i = 0; i < Math.Max(lines1.Length, lines2.Length); i++)
            {
                if (i < lines1.Length)
                {
                    sw.WriteLine(lines1[i]);
                }
                if (i < lines2.Length)
                {
                    sw.WriteLine(lines2[i]);
                }
            }
        }
    }
}
