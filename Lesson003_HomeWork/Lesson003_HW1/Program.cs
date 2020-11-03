using System;
using System.Text;

namespace Lesson003_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // family = сім'я ,sister = сестра ,brother = брат ,child = дитина ,home = дім ,room = кімната ,window = вікно ,door = двері ,table = стіл ,book = книга
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string family = "сім'я", sister = "сестра", brother = "брат", child = "дитина", home = "дім", room = "кімната", window = "вікно", door = "двері", table = "стіл", book = "книга";

            Console.WriteLine("Введіть слово українською для отримання його перекладу на англійську:  (введення лише нижнім регістром!)");
            string word = Console.ReadLine();


            ///         НЕ ПРАЦЮЄ!!!


            if (word == family)
                Console.WriteLine($"{family} = family");

            else if (word == sister)
                Console.WriteLine($"{sister} = sister");

            else if (word == brother)
                Console.WriteLine($"{brother} = brother");

            else if (word == child)
                Console.WriteLine($"{child} = child");

            else if (word == home)
                Console.WriteLine($"{home} = home");

            else if (word == room)
                Console.WriteLine($"{room} = room");

            else if (word == window)
                Console.WriteLine($"{window} = window");

            else if (word == door)
                Console.WriteLine($"{door} = door");

            else if (word == table)
                Console.WriteLine($"{table} = table");

            else if (word == book)
                Console.WriteLine($"{book} = book");

            else
                Console.WriteLine("Цього слова немає!");

            /*
            switch (word)
            {
                case "family":
                    {
                        Console.WriteLine($"{family} = family");
                        break;
                    }
                case "сестра":
                    {
                        Console.WriteLine($"{sister} = sister");
                        break;
                    }
                case "брат":
                    {
                        Console.WriteLine($"{brother} = brother");
                        break;
                    }
                case "дитина":
                    {
                        Console.WriteLine($"{child} = child");
                        break;
                    }
                case "дім":
                    {
                        Console.WriteLine($"{home} = home");
                        break;
                    }
                case "кімната":
                    {
                        Console.WriteLine($"{room} = room");
                        break;
                    }
                case "вікно":
                    {
                        Console.WriteLine($"{window} = window");
                        break;
                    }
                case "двері":
                    {
                        Console.WriteLine($"{door} = door");
                        break;
                    }
                case "стіл":
                    {
                        Console.WriteLine($"{table} = table");
                        break;
                    }
                case "книга":
                    {
                        Console.WriteLine($"{book} = book");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Цього слова немає!");
                        break;
                    }
            }*/
        }
    }
}
