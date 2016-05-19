
using System;
using System.Collections.Generic;
// using System.Text.RegularExpressions;

namespace p01_ReverseNumbersWithAStack
{
    public class ReverseNumbersStack
    {
        public static void Main()
        {
            // begin
            Stack<int> numbers = new Stack<int>();

            string inputLine = Console.ReadLine();
            // string newStrstr = Regex.Replace(inputLine, " {2,}", " ");
            string[] inputLineStr = inputLine.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // pushing the elements
            for (int i = 0; i < inputLineStr.Length; i++)
            {
                numbers.Push(Convert.ToInt32(inputLineStr[i]));
            }

            while (numbers.Count != 0)
            {
                Console.Write(numbers.Pop());
                if (numbers.Count > 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
