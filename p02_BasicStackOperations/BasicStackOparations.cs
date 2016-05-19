using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_BasicStackOperations
{
    public class BasicStackOparations
    {
        public static void Main()
        {
            // begin
            Stack<int> intNumbersStack = new Stack<int>();
            // reading data from console
            int[] numbers = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int amountOfElementsToPush = numbers[0];     // amount of elements in the stack
            int amountOfElementsToPop = numbers[1];      // elements to pop
            int elementToCheck = numbers[2];             // check if exist

            // input elements and push them to the stack
            // reading from console
            numbers = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //pushing elements
            for (int i = 0; i < amountOfElementsToPush; i++)
            {
                intNumbersStack.Push(numbers[i]);
            }

            // pop elements
            for (int i = 0; i < amountOfElementsToPop; i++)
            {
                intNumbersStack.Pop();
            }

            // printing the result
            if (intNumbersStack.Count == 0)
            {
                Console.WriteLine("0");     // stack is empty
            }
            else
            {
                if (intNumbersStack.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    // must print the smallest element
                    Console.WriteLine(intNumbersStack.Min());
                }
            }

        }
    }
}
