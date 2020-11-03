using System;
using System.Text;

namespace Lesson003_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть 2 числа та знак арифметичної операції між ними:");
            double operand1 = double.Parse(Console.ReadLine());
            double operand2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 + operand2}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 - operand2}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 * operand2}");
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                            Console.WriteLine("Помилка! Ділення на 0");
                        else
                            Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 / operand2}");
                        break;
                    }
                case "%":
                    {
                        if (operand2 == 0)
                            Console.WriteLine("Помилка! Ділення на 0");
                        else
                            Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 % operand2}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Помилка при введенні знаку операції!");
                        break;
                    }
            }
        }
    }
}
