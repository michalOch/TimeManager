using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public static class Helpers
    {
        public static string GetStringValue(string message)
        {
            string value = string.Empty;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(value));

            return value;
        }

        public static double GetDoubleNumber(string message)
        {
            double value = 0.0;
            do
            {
                GetStringValue(message);
                double.TryParse(message, out value);

            } while (value <= 0);
            return value;
        }

        public static double GetIntNumber(string message)
        {
            int value = 0;
            do
            {
                GetStringValue(message);
                int.TryParse(message, out value);
            } while (value <= 0);
            return value;
        }
    }
}
