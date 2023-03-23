using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
	internal class calculator
	{
		public static void Mains()
		{

			Console.WriteLine("Hi Welcome to Calculator!!!");
			calc();
		}

		public static void calc()
		{
			string menu = "1. Add \n2. Subtract \n3. Multiply \n4. Divide\n5. Exit or enter q";
			Console.WriteLine("----------MEMU-----------");
			Console.WriteLine(menu);
			Console.WriteLine("-------------------------");
			Console.Write("Enter the number to perform operation: ");
			string choosen = Console.ReadLine();
			switch (choosen)
			{
				case "1":
					addition();
					break;

				case "2":
					substraction();
					break;
				case "3":
					multiplication();
					break;
				case "4":
					division();
					break;
				case "5" or "q":
					Console.WriteLine("Exiting....");
					return;
				default:
					Console.WriteLine("Entered wrong options");
					calc();
					break;
			}

		}
		public static void addition()
		{
			Console.WriteLine("-----------Addition-------------");
			string num1,num2;
			Console.Write("Enter the first number : ");
			num1 = Console.ReadLine();
			Console.Write("Enter the second number : ");
			num2 = Console.ReadLine();
			try
			{
				int result = int.Parse(num1) + int.Parse(num2);
				Console.WriteLine("Result of {0} + {1} = {2}", num1, num2, result);
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR : Enter Only Numberic Values");
			}
			catch(Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				calc();
			}
		}

		public static void substraction()
		{
			Console.WriteLine("----------Subtraction---------");
			string num1,num2;
			Console.Write("Enter the first number : ");
			num1 = Console.ReadLine();
			Console.Write("Enter the second number : ");
			num2 = Console.ReadLine();
			try
			{
				int result = int.Parse(num1) - int.Parse(num2);
				Console.WriteLine("Result of {0} - {1} = {2}", num1, num2, result);
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR : Enter Only Numberic Values");
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				calc();
			}
		}
		public static void multiplication()
		{
			Console.WriteLine("----------Multiplication---------");
			string num1, num2;
			Console.Write("Enter the first number : ");
			num1 = Console.ReadLine();
			Console.Write("Enter the second number : ");
			num2 = Console.ReadLine();
			try
			{
				int result = int.Parse(num1) * int.Parse(num2);
				Console.WriteLine("Result of {0} * {1} = {2}", num1, num2, result);
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR : Enter Only Numberic Values");
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				calc();
			}
		}
		public static void division()
		{
			Console.WriteLine("----------Division---------");
			string num1, num2;
			Console.Write("Enter the first number : ");
			num1 = Console.ReadLine();
			Console.Write("Enter the second number : ");
			num2 = Console.ReadLine();
			try
			{
				int result = int.Parse(num1) / int.Parse(num2);
				Console.WriteLine("Result of {0} / {1} = {2}", num1, num2, result);
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR : Enter Only Numberic Values");
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				calc();
			}
		}

	}
}
