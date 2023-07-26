using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Calculator
{
  //  internal class Program
    
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("***********Factorial_Calculator***********");
    //        int inputNum = int.Parse(Console.ReadLine());
    //        List<int> nunmsList = new List<int>();
    //        for (int i = inputNum; i>0; i--)
    //        {
    //            nunmsList.Add(i);
               
    //        }
    //        //int[] numbersArray = nunmsList.ToArray();
    //        //int result = MultiplyArrayElements(numbersArray);
    //        int result = MultiplyArrayElements(nunmsList);
    //        Console.WriteLine("Factorial of " + inputNum + " is: " + result);
         
    //        Console.ReadLine();

    //    }
    //    static int MultiplyArrayElements(List<int> List)
    //    {
    //        int result = 1;

    //        for (int i = 0; i < List.Count; i++)
    //        {
    //            result *= List[i];
    //        }

    //        return result;
        
  
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***********Factorial_Calculator***********");
                int inputNum;

                // Get user input and handle invalid input
                while (true)
                {
                    Console.Write("Enter a positive integer: ");
                    if (int.TryParse(Console.ReadLine(), out inputNum) && inputNum > 0)
                    {
                        break; // Valid input, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a positive integer.");
                    }
                }

                List<int> numbersList = new List<int>();
                for (int i = inputNum; i > 0; i--)
                {
                    numbersList.Add(i);
                }

                int result = MultiplyArrayElements(numbersList); // Pass the List<int> directly
                Console.WriteLine("Factorial of " + inputNum + " is: " + result);
                Console.ReadLine();
            }

            static int MultiplyArrayElements(List<int> list)
            {
                int result = 1;

                for (int i = 0; i < list.Count; i++)
                {
                    result *= list[i];
                }

                return result;
            }

        }
}





