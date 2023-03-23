using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp;


namespace MyFirstApp
{
    internal class main
    {
        public static void Mains()
        {
            Console.WriteLine("Welcome to Console App");
            Console.WriteLine("--------MENU-------");
            string menu = "1. Calculator\n2. String Manipulation\n3. Exit or enter q";
            Console.WriteLine(menu);
            MyFirstApp.calculator calculator = new MyFirstApp.calculator();
            MyFirstApp.StringManipulation stringManipulation = new MyFirstApp.StringManipulation();
            Console.Write("Enter the number of the operation : ");      
            string choosen = Console.ReadLine();
            switch(choosen)
            {
                case "1":
                    calculator.Mains();
                    Mains();
                    break;
                case "2":
                    stringManipulation.String_Main();
                    Mains();
                    break;
                case "3" or "q":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Incorrect Options");
                    break;
            }
        }

    }
}
