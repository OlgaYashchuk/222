internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число   ");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(X % 100 / 10);
    }
}