﻿using System;
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
            Console.WriteLine("-------------");
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Score = " + score);
            Console.WriteLine("-------------");
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
            Console.ReadKey(true);
            Console.WriteLine("Mario killed a Goomba");
            Console.ReadKey(true);
            Pont(10);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Mario killed a fat Goomba");
            Console.ReadKey(true);
            Pont(30);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Mario was hit by a Koopa");
            Console.ReadKey(true);
            TakeDamage(-5);
            Pont(-5);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Mario eat some food");
            Console.ReadKey(true);
            Pont(3);
            TakeDamage(3);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Mario want to bed");
            Console.ReadKey(true);
        }
    }
}
