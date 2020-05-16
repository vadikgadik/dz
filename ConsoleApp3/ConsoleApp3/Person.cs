using System;

namespace ConsoleApp3
{

    class Person
    {

        private int Day { get; set; }
        private int Year { get; set; }
        private int Month { get; set; }
        private int Age { get; set; }

        private string ZodiakZnak { get; set; }

        /// <summary>
        /// Конструктор класса Человек
        /// </summary>
        public Person ()
        {
            var currentYear = DateTime.Now.Year;
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Введите дату своего рождения в формате ДД.ММ.ГГГГ");
                string date = Console.ReadLine();
                string[] dates = date.Split('.', ' ', ',', '/', '\\');
                if (dates.GetLength(0) != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите дату рождения по указанному формату");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Day = Convert.ToInt32(dates[0]);
                Month = Convert.ToInt32(dates[1]);
                Year = Convert.ToInt32(dates[2]);
                Age = currentYear - Year;
                if (Day > 0 && Day < 32 && Month > 0 && Month < 13 && Age > 0 && Age < 150)
                {
                    check = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Упс, чото не то!!!\nПопробуйте ещё раз");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }

        /// <summary>
        /// Определение знака зодиака
        /// </summary>
        public void Zodiac_Sign()
        {
            if ((Day >= 21 && Month == 3) || (Day <= 20 && Month == 4)) ZodiakZnak = "Ваш знак зодиака Овен";
            if ((Day >= 21 && Month == 4) || (Day <= 20 && Month == 5)) ZodiakZnak = "Ваш знак зодиака Телец";
            if ((Day >= 21 && Month == 5) || (Day <= 21 && Month == 6)) ZodiakZnak = "Ваш знак зодиака Близнецы";
            if ((Day >= 22 && Month == 6) || (Day <= 22 && Month == 7)) ZodiakZnak = "Ваш знак зодиака рак";
            if ((Day >= 23 && Month == 7) || (Day <= 23 && Month == 8)) ZodiakZnak = "Ваш знак зодиака лев";
            if ((Day >= 24 && Month == 8) || (Day <= 23 && Month == 9)) ZodiakZnak = "Ваш знак зодиака дева";
            if ((Day >= 24 && Month == 9) || (Day <= 23 && Month == 10)) ZodiakZnak = "Ваш знак зодиака весы";
            if ((Day >= 24 && Month == 10) || (Day <= 22 && Month == 11)) ZodiakZnak = "Ваш знак зодиака скорпион";
            if ((Day >= 23 && Month == 11) || (Day <= 21 && Month == 12)) ZodiakZnak = "Ваш знак зодиака стрелец";
            if ((Day >= 22 && Month == 12) || (Day <= 20 && Month == 1)) ZodiakZnak = "Ваш знак зодиака козерог";
            if ((Day >= 21 && Month == 1) || (Day <= 18 && Month == 2)) ZodiakZnak = "Ваш знак зодиака водолей";
            else ZodiakZnak = "Ваш знак зодиака рыбы";
            Console.WriteLine(ZodiakZnak);
        }

        /// <summary>
        /// Определение високосного года
        /// </summary>
        public void LeapYear()
        {
            if (Year % 4 == 0)
            {
                Console.WriteLine("Вы родились в високосный год");
            }
            else
            {
                Console.WriteLine("Вы родились в невисокосный год");
            }
        }

        /// <summary>
        /// Определение Чегото там китайский календать
        /// </summary>
        public void Calendar()
        {
            switch (Year % 12)
            {
                case 1: Console.WriteLine("Вы родились в год курицы");
                    break;
                case 2:
                    Console.WriteLine("Вы родились в год собаки");
                    break;
                case 3:
                    Console.WriteLine("Вы родились в год свиньи");
                    break;
                case 4:
                    Console.WriteLine("Вы родились в год мыши");
                    break;
                case 5:
                    Console.WriteLine("Вы родились в год коровы");
                    break;
                case 6:
                    Console.WriteLine("Вы родились в год тигра");
                    break;
                case 7:
                    Console.WriteLine("Вы родились в год заяца");
                    break;
                case 8:
                    Console.WriteLine("Вы родились в год улитки");
                    break;
                case 9:
                    Console.WriteLine("Вы родились в год змеи");
                    break;
                case 10:
                    Console.WriteLine("Вы родились в год лошади");
                    break;
                case 11:
                    Console.WriteLine("Вы родились в год овцы");
                    break;
                case 12:
                    Console.WriteLine("Вы родились в год обезьяны");
                    break;
            }
        }
    }
}
