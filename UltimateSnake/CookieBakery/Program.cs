using System;
using System.Diagnostics;
using System.Threading;

namespace CookieBakery
{
    public static class Program
    {
        private const int DelayBakeCookie = 2;
        private const int DelayGrabCookie = 3;

        private static void Main(string[] args)
        {
            // Begin the day
            ParameterizedThreadStart parameterizedThreadStart = GrabCookies;

            new Thread(parameterizedThreadStart).Start(new Person("Fred"));
            new Thread(parameterizedThreadStart).Start(new Person("Ted"));
            new Thread(parameterizedThreadStart).Start(new Person("Greg"));

            new Thread(BakeCookies).Start();

            // monitor progress and listen for key press so the console won't close
            while (Bakery.IsDailyQuotaNotSold)
            {
                // Keep the main thread occupied
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("All out of cookies for today!");

            Console.ReadKey();
        }

        private static void GrabCookies(Object obj)
        {
            if (!(obj is Person))
            {
                Console.WriteLine("That's not a real person!");
                return;
            }

            Person customer = (Person) obj;

            while (Bakery.IsDailyQuotaNotSold)
            {
                Thread.Sleep(DelayGrabCookie);
                Bakery.SellCookieTo(customer);
            }
        }

        private static void BakeCookies()
        {
            while (Bakery.IsDailyQuotaNotBaked)
            {
                Thread.Sleep(DelayBakeCookie);
                Bakery.BakeCookie();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Daily quota of cookies has been baked.");
        }
    }
}
