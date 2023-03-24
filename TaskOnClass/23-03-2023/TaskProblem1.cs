using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp
{
	internal class TaskProblem_23_02_2023_
	{

		public static void Mains(String[] args)
		{
			int hero_total_bullet = 10;
			int villian_total_bullet = 10;
			int hero_bullet_number = 1;
			int villian_bullet_number = 1;
			string hero_ = "HERO";
			string villian_ = "VILLIAN";

			while (hero_total_bullet  > 0 && villian_total_bullet > 0)
			{
				Console.WriteLine("The Bullet Number of {0} : {1}",hero_,hero_bullet_number);
				hero_bullet_number++;
				hero_total_bullet--;
				Console.WriteLine("The Bullet Number of {0} : {1}", villian_, villian_bullet_number);
				villian_bullet_number = villian_bullet_number + 3;
				villian_total_bullet = villian_total_bullet - 3;
			}

			if (hero_total_bullet > 0)
				Console.WriteLine("Hero Wins");
			else
				Console.WriteLine("Villian Wins");


		}
	}
}
