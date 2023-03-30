using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{

	delegate void PrintFunction();

	internal class Day7_29_03_2023_
	{
		static string path = "C:\\Users\\HP\\Documents\\Classes\\C#\\ActivityOnClassInCSharp\\ActivityOnClass\\FileHandlingEx\\file.txt";

		public string PathFile { 
			get
			{
				return path;
			} 
		}

		public static FileStream file = new FileStream(path,FileMode.OpenOrCreate);
		public static StreamWriter streamWriter = new StreamWriter(file);


		public static void Mains(string[] args)
		{
			Day7_29_03_2023_ day7 = new Day7_29_03_2023_();
			//day7.BuiltInDelegates();
			//day7.AsyncConcepts();
			day7.method1();
			day7.method2();
			day7.method3();
			Console.ReadLine();
		}

		public void BuiltInDelegates()
		{
			// Built-in delegates
			// Action
			Action<string> Print = (string msg) => Console.WriteLine(msg);
			Print("called from Action builtin Function.");

			// Func Delegates
			Func<int, int, int> Addition = delegate (int x, int y) { return x + y; };

			Console.WriteLine(Addition.Invoke(1, 2));

			// Predicate Delegates
			Predicate<string> predicate = (string msg) => {  return msg.Equals(msg.ToUpper()); };
			Console.WriteLine(predicate.Invoke("hello"));

			ValueTuple<int,int> v = (2, 1);

			Predicate<ValueTuple<int,int>> pd1 = delegate (ValueTuple<int,int> v)
			{
				return v.Item1 > v.Item2;
			};

			Console.WriteLine(pd1.Invoke(v));

			// Recursion
			Func<int, int> func = null;
			func = (x) =>
			{
				if (x == 0 || x == 1)
					return 1;
				else
					return x * func(x - 1);
			};   
			Console.WriteLine(func(5));

			List<int> list = new List<int>() { 10, 2, 20, 20 };
			// Passing the list to Predicate
			Predicate<List<int>> checkifGreaterThanFive = (list) => list.All((a) => a > 5);
			Console.WriteLine("The Predicate : "+" " + checkifGreaterThanFive.Invoke(list));

		}


		// Async concept
		public async Task AsyncConcepts()
		{
			Task<int> task1 = ReturnNumber();
			await Console.Out.WriteLineAsync(Convert.ToChar(task1.Result));

			FirstMethod();
			SecondMethod();


		}
		
		async private void FirstMethod()
		{
			Console.WriteLine("Method 1 is started");
			await Task.Delay(1000);
			Console.WriteLine("Method 1 is ended");
		}

		async private Task<int> ReturnNumber()
		{
			return 68;
		}

		private void SecondMethod()
		{
			Console.WriteLine("Method 2 is started");
			Console.WriteLine("Method 2 is ended");
		}


		
		async public Task method1()
		{
			Task.Run(() =>
			{
				Console.WriteLine("The file is Open in method 1");
				

			});


			await Task.Delay(1000);
			streamWriter.Close();
			file.Close();
		}
		public void method2()
		{
			Console.WriteLine("Call from method 2");

		}

		async public Task method3()
		{
			streamWriter.Write("Some msg from method3");
			
			Console.WriteLine("File is writtten in Method 3");

			
			
		}

	}


}
