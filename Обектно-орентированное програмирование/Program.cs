using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в RPG игру. Нажмите энтр для продолжения.");
            Console.ReadLine();
            Charecter p1 = new Paladin(800, 400, 80);
            Charecter s1 = new Shaman(500, 700, 50);
            Charecter pr1 = new Priest(00, 900, 30);
            Charecter r1 = new Rogue(350, 500, 100);
            Charecter p2 = new Paladin(800, 400, 80);
            Charecter s2 = new Shaman(500, 700, 50);
            Charecter pr2 = new Priest(400, 900, 30);
            Charecter r2 = new Rogue(350, 500, 100);       
            List<Charecter> AllCharecters = new List<Charecter>();
            AllCharecters.Add(p1);
            AllCharecters.Add(s1);
            AllCharecters.Add(pr1);
            AllCharecters.Add(r1);
            AllCharecters.Add(p2);
            AllCharecters.Add(s2);
            AllCharecters.Add(pr2);
            AllCharecters.Add(r2);


            Console.WriteLine("Ваш ход.");
            Console.WriteLine("Выберите персонажа(1-Паладин, 2-Шаман, 3-Жрец, 4-Вор).");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    {
                        Charecter target = p2;
                    }
                    break;
                case "2":
                        {
                            Charecter target = s2;
                        }
                        break;
                case "3":
                        {
                            Charecter target = pr2;
                        }
                        break;
                case "4":
                        {
                            Charecter target = r2;
                        }
                        break;
            }
            Console.WriteLine("Выберите персонажа, которого хотите атаковать(1-Паладин, 2-Шаман, 3-Жрец, 4-Вор).");
            switch (s)
            {
                case "1":
                    {
                        p1.Attack();
                    }
                    break;
                case "2":
                    {
                        s1.Attack();
                    }
                    break;
                case "3":
                    {
                        pr1.Attack();
                    }
                    break;
                case "4":
                    {
                        r1.Attack();
                    }
                    break;

                    Random r = new Random();
                    int random = r.Next(1, 6);
                    int random2 = r.Next(1, 6);
                    switch (random)
                    {
                        case 1:
                            {
                             Charecter    target = p2;
                            }
                            break;
                        case 2:
                            {
                                Charecter target = s2;
                            }
                            break;
                        case 3:
                            {
                                Charecter target = pr2;
                            }
                            break;
                        case 4:
                            {
                                Charecter target = r2;
                            }
                            break;
                    }  
            }
        }

    }
}
