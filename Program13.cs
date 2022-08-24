// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Введите число   ");
        int X = Convert.ToInt32(Console.ReadLine());
        string XText  = Convert.ToString(X);
          if (XText.Length > 2)
           {
             Console.WriteLine(XText[2]);
             }
           else 
           {
            Console.WriteLine("третьей цифры нет");
           }
