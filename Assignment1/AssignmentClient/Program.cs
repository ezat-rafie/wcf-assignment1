using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice = "0";
            while (!choice.Equals("6"))
            {
                Console.Clear();
                Console.WriteLine("WCF Assignment 1");
                Console.WriteLine("");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Reverse a String");
                Console.WriteLine("4. Print HTML Tag");
                Console.WriteLine("5. Sort 5 Numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter number: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.CheckPrimeNumber(n1));
                        Console.WriteLine("Press any key to go back to menu...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Enter number: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("The sum of digits is: " + client.SumOfDigits(n2));
                        Console.WriteLine("Press any key to go back to menu...");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Enter string: ");
                        string input = Console.ReadLine();
                        Console.WriteLine("The reverse is: " + client.ReverseString(input));
                        Console.WriteLine("Press any key to go back to menu...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Enter tag: ");
                        string tag = Console.ReadLine();
                        Console.Write("Enter data: ");
                        string data = Console.ReadLine();
                        Console.WriteLine("The HTML tag is: " + client.PrintTag(tag, data));
                        Console.WriteLine("Press any key to go back to menu...");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Enter numbers (comma separated): ");
                        string numbers = Console.ReadLine();
                        int[] ints = Array.ConvertAll(numbers.Split(','), int.Parse);
                        Console.Write("Enter sort type: ");
                        string sortType = Console.ReadLine();
                        Console.WriteLine("The sorted array is: " + String.Join(",", client.SortNumbers(sortType,ints).Select(x => x.ToString()).ToArray()));
                        Console.WriteLine("Press any key to go back to menu...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
