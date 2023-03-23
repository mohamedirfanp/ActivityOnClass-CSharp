using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp
{
    internal class TaskProblem3
    {
        public static void Mains(String[] args)
        {
            // Question : Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

            // Array Creation using the method in the TaskProblem.cs -> ArrayClass
            ArrayClass arrayClass1 = new ArrayClass();
            arrayClass1.ArrayCreation();
            int[] array1 = arrayClass1.ReturnArray();

            ArrayClass arrayClass2 = new ArrayClass();
            arrayClass2.ArrayCreation();
            int[] array2 = arrayClass2.ReturnArray();
            int[] mergerArray = ArrayMerger(array1, array2);
            Console.WriteLine("The Merged Array : ");

            foreach (int element in mergerArray)
            {
                Console.Write(element + " ");
            }


        }

        public static int[] ArrayMerger(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length *2 ];



            // Sort the Both Arrays
            Array.Sort(array1);
            Array.Sort(array2);

            int idx1 = 0, idx2 = 0, idx = 0;
            int length_array1 = array1.Length;
            int length_array2 = array2.Length;


            while(idx1 < length_array1 && idx2 < length_array2)
            {
                if (array1[idx1] <= array2[idx2])
                {
                    result[idx] = array1[idx1];
                    idx1++;
                    idx++;
                }
                else {
                    result[idx] = array2[idx2];
                    idx2++;
                    idx++;
                }
            }
            if (idx1 < length_array1)
            {
                for (int i = idx1; i < length_array1; i++)
                {
                    result[i] = array1[i];
                }
            }
            else
            {
                for (int i = idx2; i < length_array2; i++)
                {
                    result[idx] = array2[i];
                    idx++;
                }
            }


            return result;
        }
    }
    
}
