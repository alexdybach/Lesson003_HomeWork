using System;
using System.Text;

namespace Lesson003_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 14)
                Console.WriteLine("Число попадає на проміжок [0-14]");
            else if (number >= 15 && number <= 35)
                Console.WriteLine("Число попадає на проміжок [15-35]");
            else
                if (number >= 36 && number <= 50)
                Console.WriteLine("Число попадає на проміжок [36-50]");
            else
                if (number >= 51 && number <= 100)
                Console.WriteLine("Число попадає на проміжок [51-100]");
            else
                Console.WriteLine("Число не попадає на проміжок [0-100]");
        }
    }
}
