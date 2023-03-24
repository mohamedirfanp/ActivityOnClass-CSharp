using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.TaskOnClass._24_03_2023
{
    internal class TaskProblem3
    {

        //Question : Write a C# Sharp program to check if a string 'ok' appears in a given string. If it appears return a string without 'ok' otherwise return the original string.


        public string CheckString(string original_string)
        {
            if(original_string.Contains("ok"))
            {

                // First Approach
                int index = original_string.IndexOf("ok");
                string modified_string = original_string.Substring(0, index) + original_string.Substring(index+2);

                //Second Approach
                //string modified_string = original_string.Replace("ok", "");


                return CheckString(modified_string);
            }
            else
            {
                return original_string;
            }
        }


    }
}
