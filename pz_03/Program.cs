namespace pz_03;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите скорость ветра: ");
        int speed = Convert.ToInt32(Console.ReadLine());
        int value = speed >= 1 && speed <= 4 ? 1 : speed >= 5 && speed <= 10 ? 2 :
            speed >= 11 && speed <= 18 ? 3 : 4;
        switch (value)
        {
            case 1:
                Console.WriteLine("Слабый ветер.");
                break;
            case 2:
                Console.WriteLine("Умеренный ветер.");
                break;
            case 3:
                Console.WriteLine("Сильный ветер.");
                break;
            case 4:
                Console.WriteLine("Ураган.");
                break;

        }
}
