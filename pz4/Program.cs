namespace pz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Задание №1");
            for (int i = 30; i <= 150; i += 15)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //задание 2
            Console.WriteLine("Задание №2");
            int count1;
            char c;
            for (c = 'н', count1 = 0; count1 < 5; count1++, c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //задание 3
            Console.Write("Задание №3");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                    Console.Write('#');
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //задание 4
            Console.Write("Задание №4");
            int count = 0;
            Console.WriteLine();
            for (int i = -500; i <= -200; i++)
            {

                if (i % 18 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Количество чисел кратных 18: {count}");

            Console.WriteLine();

            //задание 5
            Console.WriteLine("Задание №5");
            int a, b;

            for (a = 0, b = 35; b - a > 3; a++, b--)
            {
                Console.WriteLine(a + " " + b);
            }

            Console.WriteLine(a + " " + b);

        }
    }
}