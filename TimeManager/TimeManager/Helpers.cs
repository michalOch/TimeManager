using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public static class Helpers
    {
        public static void ShowPresences()
        {
            Console.WriteLine("The values of the Presence are:");
            foreach (Presence val in Enum.GetValues(typeof(Presence)))
            {
                if(val != Presence.Undefined)
                {
                    Console.WriteLine($"{(int)val}: {val}");
                }              
            }
            Console.WriteLine("--------------------------------------------------\n");
        }

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
                var stringValue = GetStringValue(message);
                double.TryParse(stringValue, out value);

            } while (value <= 0);
            return value;
        }

        public static int GetIntNumber(string message)
        {
            int value = 0;
            do
            {
                var stringValue = GetStringValue(message);
                int.TryParse(stringValue, out value);
            } while (value <= 0);
            return value;
        }

        public static DateTime GetDate(string message)
        {
            DateTime dateTime;
            do
            {
                var stringValue = GetStringValue(message);
                DateTime.TryParse(stringValue, out dateTime);
            } while (dateTime == null);
            return dateTime;
        }
    }
}
