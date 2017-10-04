using System;

namespace AlgorithmExamples
{
    class Examples
    {
        static void Main(string[] args)
        {
            // Fizzbuzz
            // if divisible by 3 log fizz, if 5 log buzz if both log fizzbuzz
            Console.WriteLine("Please enter a number for Fizzbuzz:");
            int length = Convert.ToInt32(Console.ReadLine());
            
            for(var i = 1; i < length; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Fizzbuzz");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }

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
                        if(i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(isPrime);
            }

            // Palindrome Checker
            // Checks to see if word is a palindrome
            Console.WriteLine("\nPlease enter a word to check if it is a palindrome:");
            string word = Console.ReadLine();
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
