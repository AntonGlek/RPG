using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   public class Log
    {
       public static void Update(List<Charecter> AllCharecters)
       {
           Console.Clear();
           Console.WriteLine("-------------");
           Console.WriteLine("Ваша тима");
           Console.WriteLine("Хп Паладина" + AllCharecters[0].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Шамана" + AllCharecters[1].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Жреца" + AllCharecters[2].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Разбойника" + AllCharecters[3].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Тима врага.");
           Console.WriteLine("Хп Паладина" + AllCharecters[4].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Шамана" + AllCharecters[5].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Жреца" + AllCharecters[6].Hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Разбойника" + AllCharecters[7].Hp);

       }
    }
}
