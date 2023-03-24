using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp
{
	internal class TaskProblem4
	{
		public static void Mains(string[] args)
		{
			// Question : Write a program in C# Sharp to separate odd and even integers in separate arrays

			ArrayClass arrayClass = new ArrayClass();
			arrayClass.ArrayCreation();
			int[] array = arrayClass.ReturnArray();

			separateArray(array);

		}

		public static void separateArray(int[] array)
		{
			List<int> odd = new List<int>();
			List<int> even = new List<int>();
			foreach (int element in array)
			{
				if(element%2 == 0)
					even.Add(element);
				else
					odd.Add(element);
			}
            Console.WriteLine(" The odd element in the Array : ");
            foreach (int element in odd)
			{
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The even element in the Array : ");
			foreach(int element in even)
			{
                Console.Write(element + " ");
            }
        }
	}
}
