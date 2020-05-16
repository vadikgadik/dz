using System;

namespace DZ19
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionArray rs = new ActionArray();
            Console.WriteLine("Введите количество эл. массива");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] ArrayNum1 = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                ArrayNum1[i] = rnd.Next(1,100);
            }
            rs.WriteArray(ArrayNum1);
            rs.ReplacementArray(ref ArrayNum1);
            rs.WriteArray(ArrayNum1);
            Console.ReadKey();
        }
    }
}
