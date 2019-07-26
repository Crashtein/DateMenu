using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1) Calculate Today");
                Console.WriteLine("2) Initialize Today");
                Console.WriteLine("3) Calculate for specified day");
                Console.WriteLine("4) Calculate for specified hour");
                Console.WriteLine("5) Refresh calculations for specified day");
                Console.WriteLine("9) Exit program");
                Console.WriteLine("0) Help");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Input command number:");
                var input = Console.ReadLine();
                if (input != null)
                {
                    switch (input)
                    {
                        case "1":
                            //calcToday
                            CalcToday();
                            break;
                        case "2":
                            //initToday
                            InitToday();
                            break;
                        case "3":
                            //calcDay
                            Console.WriteLine("Day(1-31): ");
                            var day = Console.ReadLine();
                            int iday = Int32.Parse(day);
                            Console.WriteLine("Month(1-12): ");
                            var month = Console.ReadLine();
                            int imonth = Int32.Parse(month);
                            Console.WriteLine("Year(>2000): ");
                            var year = Console.ReadLine();
                            int iyear = Int32.Parse(year);
                            if (0 < iday && iday < 32 && 0 < imonth && imonth < 13 && 2000 < iyear)
                            {
                                DateTime calcDate = new DateTime(iyear, imonth, iday);
                                CalcDay(calcDate);
                            }
                            else
                            {
                                Console.WriteLine("Wrong date format, try again!");
                            }
                            break;
                        case "4":
                            //calcHour
                            Console.WriteLine("Hour(0-23): ");
                            var hour = Console.ReadLine();
                            int ihour = Int32.Parse(hour);
                            Console.WriteLine("Minute(00-59): ");
                            var min = Console.ReadLine();
                            int imin = Int32.Parse(min);
                            if (-1 < ihour && ihour < 24 && -1 < imin && imin < 60)
                            {
                                DateTime calcHour = DateTime.Now;
                                TimeSpan ts = new TimeSpan(ihour, imin, 0);
                                calcHour = calcHour.Date + ts;
                                CalcHour(calcHour);
                            }
                            else
                            {
                                Console.WriteLine("Wrong time format, try again!");
                            }
                                
                            break;
                        case "5":
                            //refreshWykForHour
                            Console.WriteLine("Day(1-31): ");
                            var refday = Console.ReadLine();
                            int irefday = Int32.Parse(refday);
                            Console.WriteLine("Month(1-12): ");
                            var refmonth = Console.ReadLine();
                            int irefmonth = Int32.Parse(refmonth);
                            Console.WriteLine("Year(>2000): ");
                            var refyear = Console.ReadLine();
                            int irefyear = Int32.Parse(refyear);
                            Console.WriteLine("Hour(0-23): ");
                            var refhour = Console.ReadLine();
                            int irefhour = Int32.Parse(refhour);
                            Console.WriteLine("Minute(00-59): ");
                            var refmin = Console.ReadLine();
                            int irefmin = Int32.Parse(refmin);
                            if (0 < irefday && irefday < 32 && 0 < irefmonth && irefmonth < 13 && 2000 < irefyear && -1 < irefhour && irefhour < 24 && -1 < irefmin && irefmin < 60)
                            {
                                DateTime refDate = new DateTime(irefyear, irefmonth, irefday,irefhour,irefmin,0);
                                RefreshWykForHour(refDate);
                            }
                            else
                            {
                                Console.WriteLine("Wrong date format, try again!");
                            }
                            break;
                        case "9":
                            repeat = false;
                            Console.WriteLine("Shutting down...");
                            break;
                        case "0":
                            //help
                            Help();
                            break;
                        default:
                            //do sth
                            Console.WriteLine("There is no choosen option! Input correct one!");
                            break;

                    }
                }
                if (repeat)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }
        }
        static void CalcToday()
        {
            DateTime dDay = DateTime.Now;
            Console.WriteLine("Calculating for Today" + dDay.ToString("dddd, dd MMMM yyyy") + "...");
        }

        static void InitToday()
        {
            DateTime dDay = DateTime.Now;
            Console.WriteLine("Initializing from Today" + dDay.ToString("dddd, dd MMMM yyyy") + "...");
        }
        static void CalcDay(DateTime calcDate)
        {
            Console.WriteLine("Calculating for day: " + calcDate.ToString("dddd, dd MMMM yyyy") + "...");
        }
        static void CalcHour(DateTime calcHour)
        {
            Console.WriteLine("Calculating for time: " + calcHour.ToString("HH:mm") + "...");
        }
        static void RefreshWykForHour(DateTime refDate)
        {
            Console.WriteLine("Recalculating data for day: " + refDate + "...");
        }
        static void Help()
        {
            Console.WriteLine("No Help for Today... Sorry...");
        }
    }
}
