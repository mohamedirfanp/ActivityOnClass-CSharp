using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp
{
    internal class TaskProblem2
    {
        public static void Mains(String[] args)
        {
            // Question : Write a program in C# Sharp to count a total number of duplicate elements in an array.
            ArrayClass arrayClass = new ArrayClass();
            arrayClass.ArrayCreation();
            arrayClass.CountDuplicate();

        }
    }

    class ArrayClass
    {
        int[] IntegerArray;

        public void ArrayCreation()
        {
            // User Input Array
            Console.Write("Enter the Size of the Array : ");
            int sizeofarray = Convert.ToInt32(Console.ReadLine());
            IntegerArray = new int[sizeofarray];
            int userInput = 0;
            int idx = 0;
            while(idx < sizeofarray) 
            {
                Console.Write("Enter the number to be insisted in the Array : ");
                userInput = Convert.ToInt32(Console.ReadLine());
                IntegerArray[idx] = userInput ;
                idx++;
            }
            return;
        }
        public void CountDuplicate()
        {
            int result = 0;
            Array.Sort<int>(IntegerArray);
            for (int i = 0; i< IntegerArray.Length - 1;i++)
            {
                if(IntegerArray[i] == IntegerArray[i+1])
                {
                    result++;
                }
            }
            Console.WriteLine(result == 0 ? "NO Duplicate Found" : $"The total Count of Duplicate Elements : {result}");
        }

        public int[] ReturnArray()
        {
            return IntegerArray;
        }



    }


}
