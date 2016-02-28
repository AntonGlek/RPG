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
           Console.WriteLine("Хп Паладина" + AllCharecters[0].hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп Шамана" + AllCharecters[1].hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп " + AllCharecters[2].hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Хп " + AllCharecters[3].hp);
           Console.WriteLine("-------------");
           Console.WriteLine("Тима врага.");
           Console.WriteLine("Хп " + AllCharecters[4].hp);
           Console.Clear();
           Console.WriteLine("-------------");
           Console.WriteLine("Тима врага.");
           Console.WriteLine("Хп " + AllCharecters[5].hp);
           Console.Clear();
           Console.WriteLine("-------------");
           Console.WriteLine("Тима врага.");
           Console.WriteLine("Хп " + AllCharecters[6].hp);
           Console.Clear();
           Console.WriteLine("-------------");
           Console.WriteLine("Тима врага.");
           Console.WriteLine("Хп Паладина" + AllCharecters[7].hp);

       }
    }
}
