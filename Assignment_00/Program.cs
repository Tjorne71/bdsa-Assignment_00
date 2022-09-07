using System;
namespace Assignment_00;
    public class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter Year:");
            string input = Console.ReadLine();
            while (ValidateInput(input)) {
                Console.WriteLine("Enter Year as numeric value like xxxx and the year should be past 1582");
                input = Console.ReadLine();
            }
            if (IsLeapYear(input)) {
                Console.WriteLine("Yay");
                return;
            }
            Console.WriteLine("Nay");
            return;
        }

        public static bool IsLeapYear(int year) 
        {
            if(year%4 != 0 || (year % 100 == 0 && year % 400 != 0))
            {
                return false;
            }
            return true;
        }

        public static bool IsLeapYear(string yearString) 
        {
            int year;
            int.TryParse(yearString, out year);
            return IsLeapYear(year);
        }

        public static bool ValidateInput(string input) 
        {
            return !int.TryParse(input, out int temp) || temp < 1582;
        }
    }

