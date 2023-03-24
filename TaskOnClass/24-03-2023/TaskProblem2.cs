using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.TaskOnClass._24_03_2023
{
    internal class TaskProblem2
    {

        // Question : Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.

        public void Mains()
        {
            Console.Write("Enter the string : ");
            string userInput = Console.ReadLine();
            AppendLastChar(userInput);
        }


        public void AppendLastChar(string original_string)
        {
            char last_char = original_string.Last<char>();
            string modified_string = last_char + original_string + last_char;
            Console.WriteLine("The modified string : "+ modified_string);

        }



    }
}
