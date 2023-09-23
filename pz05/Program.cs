

namespace pz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            if (n >= 0)
            {
                bool isEven = false;
                if (n % 2 == 0)
                {
                    isEven = true;
                }
                if (isEven == true)
                {
                    m += 1;
                }
                int sum = 0;
                int i = m;
                while (i <= (m * 2))
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                    i++;
                }
                Console.WriteLine($"Сумма всех нечётных чисел в диапазоне от {m} до {m * 2}: {sum}");
            }
            else
            {
                Console.WriteLine("Вы ввели отрицательное число!");
            }
        }
    }
}