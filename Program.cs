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
            Console.WriteLine("Health = " + health);


        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("met2");

            score = 0;
            health = 100;

            ShowHUD();
            TakeDamage(5);
            ShowHUD();

            Console.ReadKey(true);
        }
    }
}
