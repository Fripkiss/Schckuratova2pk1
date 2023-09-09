namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим переменные а b с            ;
            Console.WriteLine("Введите переменную a");
            double a = double.Parse(Console.ReadLine()); 
            if (a < 0) // проверка на недопустимые значения a
            {
                Console.WriteLine("Недопустимое значение, введите снова корректное число");
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите переменную b"); double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную c");
            double c = double.Parse(Console.ReadLine()); 
            if (c == 0) // проверка на недопустимые значения c
            {
                Console.WriteLine("Недопустимое значение, введите снова корректное число");
                c = double.Parse(Console.ReadLine());
            }
            // разбиваем пример на части и решаем по отдельности 
            double num1 = Math.Pow(a * (Math.Abs(a * Math.Pow(c, 2) - Math.Pow(b, 3))), 1 / 5); double num2 = Math.Log10(3) * c;
            double num3 = (Math.Exp(3 * c) + Math.Pow(c, 2)) / Math.Sin(2) * c; double num4 = Math.Pow(10, -3) * Math.Sqrt(2157 * a);
            double result = num1 + num2 - num3 - num4;
            Console.WriteLine("Ваш результат: " + result); // выводим результат        }
        }
    }
