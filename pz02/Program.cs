namespace pz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // создаем бесконечный цикл
            {
                double b, c, d, e; // вводим все переменные
                Console.Write("Введите значение a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите значение b:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Введите значение с:");
                c = double.Parse(Console.ReadLine());

                if (b == 0) // проверяем чтобы знаменатель не был равен нулю
                {
                    Console.WriteLine("Значение числа b не может равняться нулю. Введите корректное значение");
                    b = double.Parse(Console.ReadLine());
                }

                if (a == c) // проверяем чтобы знаменатель не был равен нулю
                {
                    Console.WriteLine("Значения чисел а и с не может совпадать");
                    Console.Write("Введите значение b:");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение с:");
                    c = double.Parse(Console.ReadLine());
                }

                if (a < 0)
                    c = a - b * Math.Pow(a, 3) / b;
                else
                    c = a * b - 10;


                if (c <= 5)
                    d = Math.Sin(2 * a) + 2 * c;
                else
                    d = Math.Pow(Math.Cos((a - b) / (c - a)), 2);

                e = (2 * b + 3 * d - 11 * a * c) / 10;

                Console.WriteLine($"Значение c ={Math.Round(c, 2)}");  //  выводим все значения и округляем до второй цифры после запятой
                Console.WriteLine($"Значение d ={Math.Round(d, 2)}");
                Console.WriteLine($"Значение e ={Math.Round(e, 2)}");


                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}