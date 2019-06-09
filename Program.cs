using System;

namespace Epam_Task5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите скобочную последовательность с клавиатуры");
            var brackets = Console.ReadLine();
            var checker = new BracketsChecker();
            foreach (var ch in brackets)
            {
                checker.Put(ch);
            }
            if (checker.Balanced)
            {
                Console.WriteLine("Верная скобочная последовательность");
            }
            else
            {
                Console.WriteLine("Неверная скобочная последовательность");
            }
        }
    }
}