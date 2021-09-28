using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2
{
    
    class Program
    {
        static int score;
        static int health;

        
        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("------HUD-------");
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Score = " + score);
            Console.WriteLine("----------------");
        }

        static void Pont(int pont)
        {
            score = score + pont;
        }

        static void TakeDamage(int damage)
        {
            health = health + damage;
        }
        
        static void Main(string[] args)
        {


            

            Console.WriteLine("Name: Mario");


            score = 0;
            health = 10;

            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.WriteLine("Mario killed a Goomba and got 10 ponts");
            Console.ReadKey(true);
            Pont(10);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.WriteLine("Mario killed a fat Goomba and got 30 ponts");
            Console.ReadKey(true);
            Pont(30);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.WriteLine("Mario was hit by a Koopa and was damage by 5hp and lost 5 ponts");
            Console.ReadKey(true);
            TakeDamage(-5);
            Pont(-5);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.WriteLine("Mario eat some food and got 3 health and 3 ponts");
            Console.ReadKey(true);
            Pont(3);
            TakeDamage(3);
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.WriteLine("Mario want to bed");
            Console.ReadKey(true);
        }
    }
}
