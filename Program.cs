using System;
using NUnit.Framework;
using static Nunit.CalculatorTests;

namespace Nunit
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    
        public class StringProcessor
        {
            public int GetStringLength(string input)
            {
                if (input == null)
                    throw new ArgumentNullException(nameof(input), "Input string cannot be null");

                return input.Length;
            }
        } 
        
}



