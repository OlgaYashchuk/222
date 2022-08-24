internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите порядковый номер дня недели  ");
        int day = Convert.ToInt32(Console.ReadLine());
          
        if (day <= 5)
        {
            Console.WriteLine("нет");
        }

        else
        {
            if(day<=7)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("в неделе 7 дней!");
            }
        }
    }
}