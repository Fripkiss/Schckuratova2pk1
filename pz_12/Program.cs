namespace pz_12;
class Program
{
    static void Main(string[] args)
    {
        // Ввод числа с клавиатуры
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            // Вызов метода для расчета степеней и получение массива результатов
            int[] results = CalculatePowers(inputNumber);

            // Вывод результатов
            Console.WriteLine($"Число: {inputNumber}");
            Console.WriteLine($"2-я степень: {results[0]}");
            Console.WriteLine($"3-я степень: {results[1]}");
            Console.WriteLine($"4-я степень: {results[2]}");
            Console.WriteLine($"5-я степень: {results[3]}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целочисленное значение.");
        }
    }

    static int[] CalculatePowers(int number)
    {
        // Инициализация массива для хранения результатов
        int[] powers = new int[4];

        // Вычисление и сохранение результатов в массив
        powers[0] = (int)Math.Pow(number, 2);
        powers[1] = (int)Math.Pow(number, 3);
        powers[2] = (int)Math.Pow(number, 4);
        powers[3] = (int)Math.Pow(number, 5);

        // Возврат массива результатов
        return powers;
    }
}
