using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{
    internal class Day5_27_03_2023_
    {
        enum days { Monday, Tuesday};

        public static void Main(string[] args)
        {
            //    OOPS_Concepts oops = new OOPS_Concepts();
            //    oops.method1();


            //    // Inheritance
            //    var Volvo = new VolvoSports();
            //    Volvo.MaxSpeed(40);
            //    Volvo.ABS();


            //    // Calling Method Overloading
            //    OverLoading("irfan", days.Monday);
            //    OverLoading("irfan", 21);
            //}


            //// Method Overloading
            //static private void OverLoading(string name, days day)
            //{
            //    Console.WriteLine("Hi "+ name + " " + day);
            //    Console.WriteLine(day.GetType());

            //}
            //static private void OverLoading(string name, int age)
            //{
            //    Console.WriteLine("Hi {0},I'm {1} years old",name, age);

            //}

            // Aggregation Concept
            //Marks mark = new Marks(300, 5);
            //Student stu = new Student("irfan", 21, 123, 901, mark);
            //stu.display();


            // File Handling
            FileHandling fileHandling = new FileHandling();
            //fileHandling.FileStreamClass();
            //fileHandling.StreamWriterClass();
            fileHandling.TextStreamClass();
            // fileIO
            // Directory IO


        }
    }

}

