using System;

namespace AlgorithmExamples
{
    public class Examples
    {
        static void Main(string[] args)
        {
            //GenericAlgorithms.Fizzbuzz();
            //GenericAlgorithms.Fibonacci();
            //GenericAlgorithms.PrimeNumber();
            //GenericAlgorithms.Palindrome();
            //GenericAlgorithms.StringToInt();
            //GenericAlgorithms.VolumeOfCylinder();
            //SortingAlgorithms.BubbleSort();
            //SortingAlgorithms.InsertionSort();

            Startup();
        }

        static void Startup()
        {
            Console.WriteLine("Please type the number of the algorithm you want to run");
            Console.WriteLine("1)Fizzbuzz");
            Console.WriteLine("2)Fibonacci");
            Console.WriteLine("3)Prime Number");
            Console.WriteLine("4)Palindrome Checker");
            Console.WriteLine("5)String To Int");
            Console.WriteLine("6)Volume of Cylinder");
            Console.WriteLine("7)Bubble Sort");
            Console.WriteLine("8)Insertion Sort");
            //Console.WriteLine("Enter 'Q' to Quit");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    GenericAlgorithms.Fizzbuzz();
                    break;
                case 2:
                    GenericAlgorithms.Fibonacci();
                    break;
                case 3:
                    GenericAlgorithms.PrimeNumber();
                    break;
                case 4:
                    GenericAlgorithms.Palindrome();
                    break;
                case 5:
                    GenericAlgorithms.StringToInt();
                    break;
                case 6:
                    GenericAlgorithms.VolumeOfCylinder();
                    break;
                case 7:
                    SortingAlgorithms.BubbleSort();
                    break;
                case 8:
                    SortingAlgorithms.InsertionSort();
                    break;
                //case 'Q':
                    //break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number please select a valid algorithm");
                    Startup();
                    break;
            }

        }


        

        

        
    }
}
