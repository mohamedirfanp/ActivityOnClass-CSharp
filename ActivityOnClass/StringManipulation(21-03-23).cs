using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFirstApp
{
	internal class StringManipulation
	{
		public void String_Main()
		{
			Console.WriteLine("Hello! Welcome to String Manipulation");
			StringMan();
		}
		public void StringMan()
		{
			string menu = "1. Cancentation\n2. Intepolation\n3. Comparsion\n4. Deletion\n5. Exit or enter q";
			Console.WriteLine("------------MENU------------");
			Console.WriteLine(menu);
			Console.WriteLine("----------------------------");
			Console.Write("Enter the number of the operation : ");
			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					cancentation();
					break;
				case "2":
					intepolation();
					break;
				case "3":
					comparison();
					break;
				case "4":
					deletion();
					break;
				case "5" or "q":
					Console.WriteLine("Exiting.....");
					return;
				default:
					Console.WriteLine("Entered Incorrect Options");
					StringMan();
					break;
			}
		}
		public void cancentation()
		{
			Console.WriteLine("-----------Cancentation-------------");
			string FirstString, SecondString;
			Console.Write("Enter the first string : ");
			FirstString = Console.ReadLine();
			Console.Write("Enter the second string : ");
			SecondString = Console.ReadLine();
			try
			{
				//string result = FirstString + SecondString;
				string result	= string.Concat(FirstString, SecondString);
				Console.WriteLine("Result of Cancentation of two string {0},{1} :  {2}", FirstString, SecondString, result);
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				StringMan();
			}
		}
		public void intepolation()
		{
			Console.WriteLine("-----------Intepolation-------------");
			string String, InsertString;
			Console.Write("Enter the string : ");
			String = Console.ReadLine();
			Console.Write("Enter the string to be insisted : ");
			InsertString = Console.ReadLine();
			try
			{
				string result = $"{String} \"the inserted string\" {InsertString}";

				Console.WriteLine("Result of Intepolation of two string {0},{1} :  {2}", String, InsertString, result);
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				StringMan();
			}
		}
		public void comparison()
		{
			Console.WriteLine("-----------Comparison-------------");
			string FirstString, SecondString;
			Console.Write("Enter the first string : ");
			FirstString = Console.ReadLine();
			Console.Write("Enter the second string : ");
			SecondString = Console.ReadLine();
			try
			{
				string result = FirstString.Equals(SecondString) ? "Equals" : "Not Equals";
				Console.WriteLine("Result of Comparison of two string {0},{1} :  {2}", FirstString, SecondString, result);
			}
			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				StringMan();
			}
		}
		public void deletion()
		{
			Console.WriteLine("-----------Deletion-------------"); 
			string String, DeleteString;
			Console.Write("Enter the string : ");
			String = Console.ReadLine();
			Console.Write("Enter the string to be deleted : ");
			DeleteString = Console.ReadLine();
			try
			{
				int startIndex = String.IndexOf(DeleteString);
				int endIndex = startIndex + DeleteString.Length;
				string result = String.Substring(0, startIndex) + String.Substring(endIndex+1);
				Console.WriteLine("Result of Deletion of two string {0},{1} :  {2}", String, DeleteString, result);
			}

			catch (Exception) { Console.WriteLine("ERROR : Unknown Error Occured"); }
			finally
			{
				Console.WriteLine("---------------------------");
				StringMan();
			}
		}
	}
}
