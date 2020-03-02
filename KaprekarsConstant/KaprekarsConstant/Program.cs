using System;
using System.Linq;
namespace KaprekarsConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4 digit number with at least two distinct numbers: ");
            Console.WriteLine("\n\nIt took " + KaprekarsConstant(Convert.ToInt32(Console.ReadLine())) + " turns to reach kaprekars constant.");
            Console.ReadLine();
        }

        static int KaprekarsConstant(int input)
        {
            int numOfTurns = 0;
            int difference = input;
            while (difference != 6174)
            {
                difference = SubstractAscendingDescending(difference);
                numOfTurns++;
                Console.WriteLine(difference + "\nPress Enter to continue");
                Console.ReadLine();
            }
            



            return numOfTurns;
            
        }

        static int SubstractAscendingDescending(int input)
        {

            string stringInput = input.ToString();
            int ascending = Convert.ToInt32(SortAscending(stringInput, false));
            int descending = Convert.ToInt32(SortAscending(stringInput, true));
            int difference = 0;
            if (ascending > descending)
            {
                difference = ascending - descending;
            }
            else
            {
                difference = descending - ascending;
            }

            return difference;
        }


        static string SortAscending(string number, bool reverse)
        {

            char[] charArray = number.ToCharArray();
            
            Array.Sort(charArray);
            if (reverse)
            {
                charArray = charArray.Reverse().ToArray();
            }
            string temp = new string(charArray);
            return temp;
        }
    }
}
