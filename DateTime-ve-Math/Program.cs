using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_ve_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));  //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday


            Console.WriteLine(DateTime.Now.ToString("mm"));   //4
            Console.WriteLine(DateTime.Now.ToString("mmm"));  //Apr
            Console.WriteLine(DateTime.Now.ToString("mmmm")); //April

            Console.WriteLine(DateTime.Now.ToString("yy"));   //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021


            Console.WriteLine("************ Math Kütüphanesi ***************");

            Console.WriteLine(Math.Abs(-1));
            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(60));

            Console.WriteLine(Math.Ceiling(2.3)); //bir üst tam sayıya yuvarlar
            Console.WriteLine(Math.Round(2.3));   //en yakın tam sayıya yuvarlar
            Console.WriteLine(Math.Round(2.7));
            Console.WriteLine(Math.Floor(2.7));   //bir alt tam sayıya yuvarlar

            Console.WriteLine(Math.Pow(3,4));  //3 üzeri 4 ü verir
            Console.WriteLine(Math.Sqrt(9));   //karekökü verir
            Console.WriteLine(Math.Log(9));    //9 un e tabanındaki logaritmik karşılığını verir
            Console.WriteLine(Math.Exp(3));    // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10)); // 10 un 10 tabanında logaritmik karşılığını veir




        }
    }
}
