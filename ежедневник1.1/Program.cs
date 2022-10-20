using System.Data.SqlTypes;
namespace ежедневник1._1
{
    public class Program
    {

        static DateTime data1 = DateTime.Today;
        static void Main(string[] args)
        {
            Console.Write("Сегодня:");
            Console.WriteLine(data1);
            DayInfo day1 = new DayInfo();
            day1.Day = 4;
            day1.Month = 10;
            day1.Zametka = "Пойти похавать в 5.23";
            day1.Opisanie = "Не ну это надо)";
            DayInfo.DaysInfo.Add(day1);
            DayInfo day2 = new DayInfo();
            day2.Day = 23;
            day2.Month = 10;
            day2.Zametka = "Поиграть в кс";
            day2.Opisanie = "Месяц не играл, чёт не то";
            DayInfo.DaysInfo.Add(day2);
            DayInfo day3 = new DayInfo();
            day3.Day = 16;
            day3.Month = 10;
            day3.Zametka = "Поменять постельное белье";
            day3.Opisanie = "Чет лень";
            DayInfo.DaysInfo.Add(day3);
            DayInfo day4 = new DayInfo();
            day4.Day = 7;
            day4.Month = 10;
            day4.Zametka = "Завтра в шарагу в 6 вставать";
            day4.Opisanie = "А оно надо?";
            DayInfo.DaysInfo.Add(day4);
            DayInfo day5 = new DayInfo();
            day5.Day = 26;
            day5.Month = 10;
            day5.Zametka = "Сделать практическую по философии";
            day5.Opisanie = "Надо сегодня сдать, а я ни че не монимаю что там написано";
            DayInfo.DaysInfo.Add(day5);
            while(true)
            {
                Days();
                ConsoleKeyInfo clavisha = Console.ReadKey();
            }
        }
        static int[] Days()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.DownArrow)
            { 
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.Write("Выбрана дата:");
                    Console.WriteLine(data1.AddDays(1));
                    data1 = data1.AddDays(1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Console.Write("Выбрана дата:");
                    Console.WriteLine(data1.AddDays(-1));
                    data1 = data1.AddDays(-1);
                }
            }
            return Days();
        }
       static int[] Strelki()
        {
            Console.SetCursorPosition(0, 1);
            int position = 1;
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                Console.Clear();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
            return Strelki();
        }
        private static void Zametki()
        {
            Console.WriteLine("Вы выбрали: ");
            Console.WriteLine(data1);
            foreach (var item in DayInfo.DaysInfo) ;
            {
                if (item.Day == data1.Day)
                {

                }    
            }
        }
    }
}