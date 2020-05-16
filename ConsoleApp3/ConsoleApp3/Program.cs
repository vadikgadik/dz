using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            var user = new Person();
            Action del = new Action(user.Zodiac_Sign);
            del += new Action(user.LeapYear);
            del += new Action(user.Calendar);
            del();
            Console.ReadKey();
        }
    }
}
