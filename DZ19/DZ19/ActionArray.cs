using System;

namespace DZ19
{
    class ActionArray
    {
        public void WriteArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
        
        public void ReplacementArray(ref int[] array)
        {
            Console.WriteLine("\nВведите Значения которые хотите заменить");
            int znach1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите на что вы хотите заменить выбранное значение");
            int znach2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] == znach1)
                {
                    array[i] = znach2;
                    count++;
                }
            }
            Console.WriteLine($"Количество заменённых символов = {count}");
        }
    }
}
