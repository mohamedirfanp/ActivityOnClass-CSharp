using System.Globalization;

namespace ConsoleApp1
{
	internal class Program
	{
		// global members
		string name;
		int age;
		float grade;

		// Constructor
		public Program()
		{
			Console.WriteLine("Hi from Default Constructor");
		}

		public Program(string name, int age, float grade)
		{
            Console.WriteLine("Hi from Parameterized Constructor");
            this.name = name;
			this.age = age;
			this.grade = grade;
		}

		public void display()
		{
            Console.WriteLine("Name : {0}\nAge : {1}\nGrade : {2}", this.name,this.age, this.grade);
        }

		// Destructor which is automatically
		~Program()
		{
            Console.WriteLine("Inside The Destructor");

        }


		public enum Days
		{
			monday, tuesday, wednesday, thursday, friday, saturday, sunday
		}
		static void Mains(string[] args)
		{
            //string name = Console.ReadLine();
            //string exp = $"this is pancake Tuesday , welcome {name} have fun";

            //Console.WriteLine(exp);
            /* string a = "A";
			string b = "a";
			bool result = a.Equals(b,StringComparison.OrdinalIgnoreCase);
			Console.WriteLine(result);
			*/

            // 1D Array
            /*
			int[] ints = { 1, 2, 3 };
			float[] fl = new float[2];
			Array.ForEach(ints, i => { Console.WriteLine(i); });

			int[] arr1 = new int[3];
			arr1[0] = 1;
			foreach(int i in arr1)
			{
                Console.WriteLine(i);
            }

			fl[0] = 2.3f;
			for(int i = 0; i < 3; i++)
			{
				Console.WriteLine(fl[i]);
            }

			// 2D Array 
			int[,] arr =
			{
				{ 1, 2},
				{ 3, 4},
				{ 5, 6}
			};
			int i, j;
			for(i = 0; i < arr.GetLength(0);  i++)
			{
                for (j=0;j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
			// Multi Dimensional   (one row, 2d array)
			int[,,] arr3d = new int[1, 3, 2]
			{
				{ {1,2}, {3,4}, {5,6} }
			};
			for(int i = 0; i<arr3d.GetLength(0);i++)
			{
				for(int j = 0; j< arr3d.GetLength(1);j++)
				{
					for(int k=0;k < arr3d.GetLength(2);k++)
					{
						Console.Write(arr3d[i,j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

			// jagged Array
			// need to implement

			// struct keyword
			AreaOfRectangle rectangle = new AreaOfRectangle();
			rectangle.length = 10;
			rectangle.breadth = 20;
			rectangle.height = 30;

			rectangle.Area();

			//Enum keyword
			//int mon = (int) Days.monday;
			//         Console.WriteLine(mon);

			//string singlevalue = Enum.GetName(typeof(Days), 3);
			//         Console.WriteLine(singlevalue);

			//         foreach (string day in Enum.GetNames<Days>())
			//{
			//             Console.WriteLine(day);
			//         }

			*/

            // Calling the Default Constructor
            //Program DefaultConstructor = new Program();

            //// Calling the parameterized Constructor
            //Program parameterizedConstructor = new Program("mdi", 20,9.2f);

            //parameterizedConstructor.display();


            /*int age = Convert.ToInt32(Console.ReadLine());

			try
			{
				CheckAge(age);
			}
			catch(AgeLimitException e)
			{
                Console.WriteLine(e.Message);
            }*/

            // Calling Generic Data Class
            // GenericDataClass<string> genericStringClass = new GenericDataClass<string>("Hi");
            // GenericDataClass<int> genericIntClass = new GenericDataClass<int>(10);

            // Calling Generic Method Clas
            // GenericMethodClass<string> genericMethodClass = new GenericMethodClass<string>();
            // genericMethodClass.CallGenericMethod("String Something");
            // genericMethodClass.CallGenericMethod(24);


            // Calling Collection Class 
            CollectionClass  collectionClass = new CollectionClass();
			// 1. List
			//collectionClass.ListMethod();
			// 2. HashSet
			//collectionClass.HashSetMethod();
			// 3. SortedSet
			//collectionClass.SortedSetMethod();
			// 4. Stack
			//collectionClass.StackMethod();



        }
		public struct AreaOfRectangle
		{
			public int length;
			public int breadth;
			public int height;

			public void Area()
			{
                Console.WriteLine((this.length + this.breadth + this.height)/3);
            }
		}


		//Exception Handling
		// Built-in Exception
		public void builtInException()
		{
			int a = 10;
			int b = 0;
			try
			{ 
				int c = a / b;
			}
			catch (DivideByZeroException de)
			{
                Console.WriteLine("ERROR : " + de.Message);
            }
			catch(Exception e)
			{
                Console.WriteLine("ERROR : "+ e.Message);
            }
			finally
			{
                Console.WriteLine("Finally block is called");

            }

		}

		//User Defined Exception
		public class AgeLimitException:Exception
		{
			public AgeLimitException(string message):base(message)
			{
			}
		}

        /// <summary>
        /// Function to Checking the Age of the user.
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="AgeLimitException"></exception>
        public static void CheckAge(int age)
		{
			if(age < 18)
			{
				throw new AgeLimitException("You should atleast 18 years old");
			}
		}

	}

	// Activity in the Collections
	class CollectionClass
	{

		public void ListMethod()
		{										// One way of adding item in the list
			var ListDemo = new List<string>() { "hi", "hello", "hello" };
			ListDemo.Add("hello1");
			ListDemo.Add("hello2");
            ListDemo.ForEach(x => { Console.Write(x + ","); });
            ListDemo.Remove("hello");
            Console.WriteLine();
            ListDemo.ForEach(x => { Console.Write(x + ","); });
        }

		public void HashSetMethod()
		{
			var HasSetDemo = new HashSet<int>() { 1, 2 , 3};
			HasSetDemo.Add(2);
			foreach(int item in HasSetDemo)
			{
                Console.WriteLine(item);
            };
		}

		public void SortedSetMethod()
		{
			var SortedSetDemo = new SortedSet<int>() { 5, 9, 0, 2, 4 };
			foreach(int item in SortedSetDemo)
			{
                Console.Write(item + " ");
            }
		}
		public void StackMethod()
		{
			Stack<string> stack_ = new Stack<string>();
			stack_.Push("A");
			stack_.Push("B");
			stack_.Push("C");

            Console.WriteLine("Elements in Stack using Pop : ");
            while (stack_.Count > 0)
			{
                Console.WriteLine("Peer elemenet : " + stack_.Peek() + " || "+"Pop Element: " + stack_.Pop() );	 
            }
		}
        public void QueueMethod()
        {
            Queue<string> queue_ = new Queue<string>();
            queue_.Enqueue("A");
            queue_.Enqueue("B");
            queue_.Enqueue("C");

            Console.WriteLine("Elements in Queue using dequeue : ");
            while (queue_.Count > 0)
            {
                Console.WriteLine("Peer elemenet : " + queue_.Peek() + " || " + "Dequeue Element: " + queue_.Dequeue());
            }
        }

    }


	//Generic Data Class
	class GenericDataClass<T>
	{
		public GenericDataClass(T message)
		{
            Console.WriteLine(message);
        }
	}

	// Generic Method Class
	class GenericMethodClass<T>
	{
		public void CallGenericMethod<T>(T message)
		{
            Console.WriteLine(message);

        }
	}

}
