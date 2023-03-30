using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{
	delegate int DelegateForSum(int a, int b); // Delegate Signature
	delegate void Print();

	//delegate T DelegateForSum<T>(T param1, T param2); // Generic Delegate dont support multicasting

	delegate void LambdaFunction(string msg);

	delegate int MathOperation(int num1, int num2);

	internal class Day6_23_03_2023_
	{
		public static void Mains(string[] args)
		{
			// delegate
			//DelegateForSum d = Addition;

			//// Generic Delegate 
			////DelegateForSum<int> d = Addition;

			//d += Subtraction; // multicasting delegate

			////Console.WriteLine(d.DynamicInvoke(10,20));
			//d.Invoke(30,40);


			//d(20,10);


			//Delegate[] arr = d.GetInvocationList();

			////foreach(DelegateForSum<T> a in arr)
			////{
			////    Console.WriteLine(a(3,7));
			////}
			//d -= Subtraction;

			// Another Way of declaring the Delegates.
			//MathOperation d1 = Addition;
			//MathOperation d2 = Subtraction;
			//MathOperation d = d1 + d2;

			//Delegate[] arr = d.GetInvocationList();
			//foreach (var item in arr)
			//{
			//    Console.WriteLine(item.DynamicInvoke(50,10));
			//}

			// Anonymous Method Implementation
			//DelegateForSum dAdd = delegate(int a, int b) { return a + b; };
			//Console.WriteLine(dAdd(10, 20));

			//Print print = delegate() { Console.WriteLine("Helo"); };

			//print.Invoke();

			// Lambda Function Implementation
			//LambdaFunction printMessage = (msg) =>
			//{
			//    Console.WriteLine("the Message from Lambda Method : " + msg);
			//};

			//printMessage("Hello");

			// Lambda Function Examples for using sorted
			//List<int> L1 = new List<int>() { 1, 2, 3, 10, 4, 5, 6, 7, 8, 15 };
			//List<int> DivisibleBy5 = L1.FindAll(n => n % 5 == 0);
			//List<string> S1 = new List<string>() { "abc", "dfg", "asd", "qwe" };

			//List<string> ContainsA = S1.OrderBy(s => s).ToList();

			//foreach (string s in ContainsA)
			//{
			//    Console.WriteLine(s);
			//}

			// Lambda function Examples
			//List<Student> students_list = new List<Student>()
			//{
			//	new Student() {Name = "test1", Id = 1, Dept = "cse", Age = 17},
			//	new Student() {Name = "test2", Id = 2, Dept = "ece", Age = 22},
			//	new Student() {Name = "test3", Id = 3, Dept = "it", Age = 20},
			//};

			//// Sort using CompareTo
			//students_list.Sort((s1,s2) => s1.Age.CompareTo(s2.Age)); 

			//// Sort not using 
			//students_list.Sort((s1,s2) => s1.Age - s2.Age);


			//foreach(Student student in students_list)
			//{
			//             Console.WriteLine(student.Name + " " + student.Id + " " + student.Dept + " "+student.Age);
			//         }
			int[] numbers = { 1, 2, 3, 4 };
			var count = (int num) =>
			{
				if (num % 2 == 0)
					return 1;
				return 0;
			};
            Console.WriteLine("The Number is divisible by 2 : {0}",CalcCount(numbers,count));

        }

		static int CalcCount(int[] numbers, Func<int,int> count)
		{
			int c = 0;
			foreach (int num in numbers)
			{
				c += count(num);
			}
			return c;
		}


        struct Student
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Dept { get; set; }
			public int Age { get; set; }
		}
		static int Addition(int a, int b)
		{
			//Console.WriteLine(a + b);
			return a + b;
		}

		static int Subtraction(int a, int b)
		{
			//Console.WriteLine(a- b);
			return a - b;
		}

	}
}
