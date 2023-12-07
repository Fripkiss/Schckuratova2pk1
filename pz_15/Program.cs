namespace pz_15;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите путь к каталогу:");
        string directoryPath = Console.ReadLine();

        DirectoryInfo directory = new DirectoryInfo(directoryPath);
        FileInfo[] files = directory.GetFiles();

        Console.WriteLine("Список файлов в каталоге:");
        foreach (FileInfo file in files)
        {
            Console.WriteLine(file.Name);
        }

        Console.WriteLine();
        Console.WriteLine("Введите первое имя файла:");
        string fileName1 = Console.ReadLine();
        Console.WriteLine("Введите второе имя файла:");
        string fileName2 = Console.ReadLine();

        CompareFiles(Path.Combine(directoryPath, fileName1), Path.Combine(directoryPath, fileName2));
    }

    static void CompareFiles(string filePath1, string filePath2)
    {
        string content1 = File.ReadAllText(filePath1);
        string content2 = File.ReadAllText(filePath2);

        if (content1 == content2)
        {
            Console.WriteLine("Содержимое файлов идентично.");
        }
        else
        {
            Console.WriteLine("Содержимое файлов не идентично.");
        }
    }
}
