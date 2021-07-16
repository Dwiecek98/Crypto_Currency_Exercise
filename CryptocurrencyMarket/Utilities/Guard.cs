using System;

namespace CryptocurrencyMarket.Utilities
{
    public static class Guard
    {
        public static void IsNotNull<T>(T obj, string nameOfParameter) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameOfParameter);
            }
        }

        public static void IsNotNullOrEmpty(string str, string nameOfParameter)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException(nameOfParameter);
            }
        }
    }
}
