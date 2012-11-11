// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   The program containing the delays
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CookieBakery
{
    using System;
    using System.Threading;

    /// <summary>
    /// The program containing the delays
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The delay between baking each cookie in milliseconds.
        /// </summary>
        private const int DelayBakeCookie = 667;

        /// <summary>
        /// The delay between attempting to grab a cookie in milliseconds.
        /// </summary>
        private const int DelayGrabCookie = 1000;

        /// <summary>
        /// The main method. Starts one thread per person, and keeps track
        /// of the program's progress by keeping the main thread occupied.
        /// Gives feedback and keeps the console alive by listening for
        /// key press when the program is finished.
        /// </summary>
        private static void Main()
        {
            ParameterizedThreadStart parameterizedThreadStart = GrabCookies;

            new Thread(parameterizedThreadStart).Start(new Person("Fred"));
            new Thread(parameterizedThreadStart).Start(new Person("Ted"));
            new Thread(parameterizedThreadStart).Start(new Person("Greg"));

            new Thread(BakeCookies).Start();

            // Keeps the main thread occupied while the program is running
            while (Bakery.IsDailyQuotaNotSold)
            {
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("All out of cookies for today!");

            Console.ReadKey();
        }

        /// <summary>
        /// Lets the bakery bake cookies with the predefined delay between
        /// each cookie until the daily quota of cookies (as defined in
        /// Bakery.cs) has been baked.
        /// </summary>
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

        /// <summary>
        /// Makes sure the passed object is an instance of the Person DTO,
        /// and lets the customer attempts grabbing cookies with the predefined
        /// delay between each grab until the daily quota of cookies (as defined
        /// in Bakery.cs) has been sold.
        /// </summary>
        /// <param name="obj">The customer</param>
        private static void GrabCookies(object obj)
        {
            if (!(obj is Person))
            {
                Console.WriteLine("That's not a real person!");
                return;
            }

            Person customer = (Person)obj;

            while (Bakery.IsDailyQuotaNotSold)
            {
                Thread.Sleep(DelayGrabCookie);
                Bakery.SellCookieTo(customer);
            }
        }
    }
}
