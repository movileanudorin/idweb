using System.Collections.Generic;

namespace BlazorApp3.Server
{
    public static class CurrencyManager
    {
        public static List<string> Currencies { get; }

        static CurrencyManager()
        {
            Currencies = new List<string>
            {
                "EUR",
                "USD",
                "MDL",
                "EC",
                "BTC"
            };
        }
    }
}
