using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.TaskOnClass._24_03_2023
{
    internal class TaskProblem1
    {
        // Question : Write a C# Sharp program to exchange the first and last characters in a given string and return the new string
        public void Mains()
        {
            string original_string;
            Console.Write("Enter the string : ");
            original_string = Console.ReadLine();
            Console.WriteLine("The exchanged string : " + Exchange(original_string));
            
        }


        public string Exchange(string original_string)
        {
            char first_letter, last_letter;
            Console.Write("Enter the first letter to be changed : ");
            first_letter = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the last letter to be changed : ");
            last_letter = Convert.ToChar(Console.ReadLine());

            string exchanged_string = original_string;

            exchanged_string = exchanged_string.Replace(original_string[0], first_letter);
            exchanged_string = exchanged_string.Replace(original_string[original_string.Length - 1], last_letter);

            return exchanged_string;


        }
    }
}
