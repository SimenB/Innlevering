// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bakery.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Simulates a cookie bakery.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CookieBakery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Simulates a cookie bakery.
    /// </summary>
    public static class Bakery
    {
        /// <summary>
        /// The amount of cookies to bake per day. Value as defined by the assignment.
        /// </summary>
        private const short DailyQuota = 12;

        /// <summary>
        /// The list of cookies.
        /// </summary>
        private static readonly List<Cookie> BakedCookies = new List<Cookie>();

        /// <summary>
        /// The amount of cookies that have been sold.
        /// </summary>
        private static int cookiesSold;

        /// <summary>
        /// Gets a value indicating whether the daily quota of cookies has been baked.
        /// </summary>
        public static bool IsDailyQuotaNotBaked
        {
            get { return BakedCookies.Count < DailyQuota; }
        }

        /// <summary>
        /// Gets a value indicating whether the daily quota of cookies has been sold.
        /// </summary>
        public static bool IsDailyQuotaNotSold
        {
            get { return cookiesSold < DailyQuota; }
        }

        /// <summary>
        /// "Bakes" a cookie by adding a new cookie to the list and prints a
        /// message indicating how many cookies are now in the list.
        /// </summary>
        public static void BakeCookie()
        {
            lock (BakedCookies)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bakery has baked cookie #{0}", BakedCookies.Count + 1);
                BakedCookies.Add(new Cookie());
            }
        }

        /// <summary>
        /// "Sells" a cookie to the customer by incrementing the number of cookies
        /// sold. Makes sure each cookie can only be sold once by locking the list.
        /// </summary>
        /// <param name="customer">The customer attempting to grab the cookie.</param>
        public static void SellCookieTo(Person customer)
        {
            lock (BakedCookies)
            {
                // Can't sell cookies that don't exist
                if (BakedCookies.Count <= cookiesSold)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\tNo cookie for {0}", customer.Name);
                    return;
                }

                // Printing and THEN updating so Program's "monitor" won't mistakenly
                // "think" all cookies have been sold until the line has been printed
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(customer.Name + " grabbed cookie #{0}", ++cookiesSold);
            }
        }

        /// <summary>
        /// Solely intended for increased readability.
        /// </summary>
        private sealed class Cookie
        {
        }
    }
}