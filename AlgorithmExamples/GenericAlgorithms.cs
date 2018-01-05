using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples
{
    public static class GenericAlgorithms
    {
        public static void Fizzbuzz()
        {
            // Fizzbuzz
            // if divisible by 3 log fizz, if 5 log buzz if both log fizzbuzz
            Console.WriteLine("Please enter a number for Fizzbuzz:");
            int length = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i < length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Fizzbuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
        }

        public static void Fibonacci()
        {
            // Fibonacci
            // Starts at zero and adds each number to itself 
            Console.WriteLine("\nPlease Enter a Number for Fibonacci:");
            int a = 0, b = 1, c = 0;
            int fibLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (var i = 0; i < fibLength; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }

        public static void PrimeNumber()
        {
            // Prime Number
            // Checks to see if number is prime
            Console.WriteLine("\nPlease Enter a Number To Check if Prime:");
            int prime = Convert.ToInt32(Console.ReadLine());
            for (var i = 2; i <= prime; i++)
            {
                var isPrime = true;
                for (var j = 2; j <= i; j++)
                {
                    if (i != j)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(isPrime);
            }
        }

        public static void Palindrome()
        {
            // Palindrome Checker
            // Checks to see if word is a palindrome

            // Asks for word to check
            Console.WriteLine("\nPlease enter a word to check if it is a palindrome:");
            // Saves that word to word variable
            string word = Console.ReadLine();
            // Need to reverse string
            // Turn string into char array
            char[] charArray = word.ToCharArray();
            // Reverse the array
            Array.Reverse(charArray);
            // Turn array into string
            string reversedWord = new string(charArray);

            // Then check if string is equal to reversed string
            if (reversedWord == word)
            {
                Console.WriteLine("{0} is a palindrome", word);
            }
            else
            {
                Console.WriteLine(word + " is not a palindrome");
            }
            Console.ReadLine();
        }

        public static void VolumeOfCylinder()
        {
            // Formula to find Volume of a cylinder
            // Volume = pi * radius^2 * height

            Console.WriteLine("Please input the radius of the cylinder");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the height of the cylinder");
            double height = Convert.ToDouble(Console.ReadLine());


            double pi = 3.14159265358979;
            double result;

            result = pi * (radius * radius) * height;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
