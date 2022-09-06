using System;
namespace Assignment_00;
    public class Program
    {
        public static void Main(string[] args) {}

        public static bool IsLeapYear(int x) 
        {
            if(x%4 != 0 || (x % 100 == 0 && x % 400 != 0))
            {
                return false;
            }
            return true;
        }
    }

