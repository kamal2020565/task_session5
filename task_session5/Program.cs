using System;
using System.ComponentModel;

namespace task_session5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
           string oper = "";
            do
            {
                Console.WriteLine("P - PRINT NUMBERS".ToUpper());
                Console.WriteLine("A - ADD NUMBER".ToUpper());
                Console.WriteLine("M - DISPLAY MEAN OF THE NUMBERS".ToUpper());
                Console.WriteLine("S - DISPLAY THE SMALLEST NUMBER".ToUpper());
                Console.WriteLine("L - DISPLAY THE LARGEST NUMBER".ToUpper());
                Console.WriteLine("F - FIND NUMBER".ToUpper());
                Console.WriteLine("C - CLEAR THE WHOLE LIST".ToUpper());
                Console.WriteLine("Q - QUIT".ToUpper());
                Console.Write("PLEASE SELECT AN OPERATION: ");
                oper = Console.ReadLine();
                switch (oper)
                {
                    case "p":
                        if (numbers.Count <= 0)
                        {
                            Console.WriteLine("the list is empty".ToUpper());
                        }
                        else { Console.WriteLine("\nCurrent Numbers: " + string.Join(", ", numbers)); }

                        break;
                    case "a":
                        int add = 0;
                        do
                        
                        {
                            Console.WriteLine("please enter number to add list   or x  to exit:   ");
                            add = Convert.ToInt32(Console.ReadLine());
                            numbers.Add(add);
                            Console.WriteLine("");

                        }
                        while (add!='x');
                        break;
                      

                    case "m":
                        if (numbers.Count == 0)
                            Console.WriteLine("List is empty!");
                        else
                            Console.WriteLine("Mean: " + (numbers.Average()));
                        break;
                    case "s":
                        int Samll_Number = numbers[0];

                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] < Samll_Number)
                            {
                                Samll_Number = numbers[i];
                            }
                        }
                        Console.WriteLine($"small number is:{ Samll_Number}");
                        break;
                    case "l":
                        int Large_Number = numbers[0];

                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] > Large_Number)
                            {
                                Large_Number = numbers[i];
                            }
                        }
                        Console.WriteLine($"Maximum number is: {Large_Number}");
                        break;
                        

                
               
                    

                    
                case "f":
                    Console.Write("Enter number to find: ");
                    if (int.TryParse(Console.ReadLine(), out int search))
                        Console.WriteLine("Number found: " + numbers.Contains(search));
                    else
                        Console.WriteLine("Invalid number!");
                    break;
                case "c":
                    numbers.Clear();
                    Console.WriteLine("List cleared!");
                    break;
                case "q":
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
                }
                Console.WriteLine();
            } while (oper != "q");

        }
    }
}
