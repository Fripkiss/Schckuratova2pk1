namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());

            RootsCount(a, b, c);
        }
        static void RootsCount(double a, double b, double c)
        {
            if (a != 0)
            {
                double d;
                d = Math.Pow(b, 2) - 4 * a * c;

                if (d == 0)
                {
                    Console.WriteLine("Один корень");
                }
                if (d > 0)
                {
                    Console.WriteLine("Два корня");
                }
                if (d < 0)
                {
                    Console.WriteLine("Корней нет");
                }
            }
            else
            {
                Console.WriteLine("а не может быть равно нулю");
            }
        }
    }
}