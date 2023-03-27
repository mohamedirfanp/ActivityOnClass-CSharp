using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{
    public class OOPS_Concepts
    {
        public void method1()
        {
            Test test = new Test();
            test.method2();
            Console.WriteLine("Called from OOPS_CONCEPT CLASS");
        }

        private class Test
        {
            public void method2()
            {
                Console.WriteLine("Triggered from Test Class");
            }
        }

    }
    public class Inheritance
    {
        internal void MaxSpeed(int speed)
        {
            int MaxSpeed = speed;
            Console.WriteLine(MaxSpeed);

        }
        public void ABS()
        {
            Console.WriteLine("ABS is applied");
        }
    }

    public class Volvo : Inheritance
    {
        public void Test()
        {
            Console.WriteLine("In Volvo car");
        }
        public void ABS()
        {
            Console.WriteLine("ADvanced Volvo aBS");
        }


    }
    public class VolvoSports : Volvo
    {
        public void Sportmethod()
        {
            Console.WriteLine("This is sport mode");
        }
    }


    // Aggregations

    public class Marks
    {
        internal int total_marks;
        float percentage;
        string grade;
        internal int no_subjects;

        public Marks(int total_marks, int no_subjects)
        {
            this.total_marks = total_marks;
            this.no_subjects = no_subjects;
        }


        public void CalcPercentage()
        {
            percentage = (total_marks / no_subjects);
            Console.WriteLine("Percentage : " + percentage);
        }
        public void FindGrade()
        {
            if (percentage < 60)
            {
                grade = "F";
            }
            else if (percentage >= 60 && percentage <= 80) { grade = "B"; }
            else
            {
                grade = "A";
            }

            Console.WriteLine("Grade : "+ grade);


        }

    }

    public class Student
    {
        string name;
        int age;
        int rollno;
        int dept_id;
        Marks mark;
        // Aggragation ->  The process of defining a class as an entity reference by another class
        public Student(string name, int age, int rollno, int dept_id, Marks mark)
        {
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.dept_id = dept_id;
            this.mark = mark;
        }

        public void display()
        {
            Console.WriteLine($"Name : {name}\nAge : {age}\nRoll_no : {rollno}\nDept_id : {dept_id}");
            Console.WriteLine($"Total_Marks : {this.mark.total_marks}\nNo of Subjects : {this.mark.no_subjects}");
            this.mark.CalcPercentage();
            this.mark.FindGrade();
        }

    }


    public interface InterfaceClass
    {
        public void calc(int a, int b);

        public void display(string name)
        {
            Console.WriteLine(name);
        }
    }

    public class Interface_EX : InterfaceClass 
    { 
        
        public void calc(int a, int b)
        {
            Console.WriteLine("A + B = " + (a+b));
        }
    }


}
