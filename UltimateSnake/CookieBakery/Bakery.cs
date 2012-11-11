using System;
using System.Collections.Generic;

namespace CookieBakery
{
    public static class Bakery
    {
        private static readonly List<Cookie> Cookies = new List<Cookie>();

        private const short DailyQuota = 50;
        private static int cookiesSold;
 
        /// <summary>
        /// Gets whether the daily quota of cookies has been baked.
        /// </summary>
        public static bool IsDailyQuotaNotBaked
        {
            get { return Cookies.Count < DailyQuota; }
        }

        /// <summary>
        /// Gets whether the daily quota of cookies has been sold.
        /// </summary>
        public static bool IsDailyQuotaNotSold
        {
            get { return cookiesSold < DailyQuota; }
        }

        /// <summary>
        /// "Bakes" a cookie by adding a new cookie to the list and printing a
        /// message indicating how many cookies are now in the list.
        /// 
        /// The factory pattern could potentially be useful here if there were several
        /// cookie types, but makes no sense in this case. Creating a static class with
        /// a pre-initialised cookie and accessing that instead of running through
        /// the constructor for every "baked" cookie makes no difference to performance.
        /// 
        /// Printing happens before adding a cookie to the list because the bool
        /// properties will (rightfully) indicate that there is at least one cookie
        /// up for grabs, and the "cookie grabbers" may grab the cookie before
        /// it has made its presence known through the console.
        /// 
        /// Locking the list here makes no difference when it comes to performance,
        /// as long as there are time restrictions. Without the time restrictions,
        /// the lock makes the program take approximately three times longer to complete.
        /// </summary>
        public static void BakeCookie()
        {
            // TODO: Why not lock just the cookie?
            lock (Cookies)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bakery has baked cookie #" + (Cookies.Count + 1));
                Cookies.Add(new Cookie());
            }
        }

        /// <summary>
        /// "Sells" a cookie to the customer by incrementing the number of cookies
        /// sold. An alternate solution could be to remove the cookie from the list
        /// (or use a Queue or Stack and Push/Pop), and instead keep track of how many
        /// cookies have been baked.
        /// 
        /// Printing happens before "selling" the cookie (incrementing the number of
        /// sold cookies) because the bool properties 
        /// 
        /// Makes sure each cookie can only be sold once by locking the list.
        /// </summary>
        /// <param name="customer">The customer attempting to grab the cookie.</param>
        public static void SellCookieTo(Person customer)
        {
            // TODO: Explain what happens and why things happen in this order
            // TODO: Why not lock just the cookie?
            lock (Cookies)
            {
            // Can't sell cookies that don't exist
                if (Cookies.Count <= cookiesSold)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\tNo cookie for " + customer.Name);
                    return;
                }

                // Printing and THEN updating so Program's "monitor" won't mistakenly
                // "think" all cookies have been sold until the line has been printed
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(customer.Name + " grabbed cookie #" + (cookiesSold++ + 1));
            }
        }

        /// <summary>
        /// Solely intended for increased readability.
        /// </summary>
        private sealed class Cookie {}
    }
}