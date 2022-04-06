﻿namespace FizzBuzzTesting
{
    public class FizzBuzz
    {
        public string DoFizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FizzBuzz";
            }
            
            if (n % 3 == 0)
            {
                return "Fizz";
            }

            if (n % 5 == 0)
            {
                return "Buzz";
            }

            return n.ToString();
        }
    }
}