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
            int total_bullet = 10;
            int hero_bullet_number = 1;
            int villian_bullet_number = 1;
            string hero_ = "HERO";
            string villian_ = "VILLIAN";

            while (total_bullet  > 0)
            {
                Console.WriteLine("The Bullet Number of {0} : {1}",hero_,hero_bullet_number);
                hero_bullet_number++;

                total_bullet--;

            }
            total_bullet = 10;
            while(total_bullet > 0)
            {
                Console.WriteLine("The Bullet Number of {0} : {1}", villian_, villian_bullet_number);
                villian_bullet_number = villian_bullet_number + 3;
                total_bullet = total_bullet - (3);
            }

            Console.WriteLine("The Bullet Number of Hero : {0}",hero_bullet_number);
            Console.WriteLine("The Bullet Number of Villian : {0}",villian_bullet_number);

            Console.WriteLine("Total Bullet Fired by {0} : {1}",hero_,hero_bullet_number);
            Console.WriteLine("Total Bullet Fired by {0} : {1}",villian_,villian_bullet_number - 1);


        }
    }
}
