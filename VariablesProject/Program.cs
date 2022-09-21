using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*studio name (OPTIONAL)
            game title
            score
            health
            shield (OPTIONAL)
            lives
            score multiplier (REQUIRED due to complexity)
            (add your own?)*/

            string gameTitle;
            gameTitle = "The Amazing Shooter";

            string studioName;
            studioName = "Nathans Studios";
            Console.WriteLine(studioName + " Presents " + gameTitle);
            Console.WriteLine();

            int score;
            score = 0;
            Console.WriteLine("Your score is " + score);
            Console.WriteLine();

            Console.WriteLine("Enemy killed!");
            Console.WriteLine();

            int pointsOnKill;
            pointsOnKill = 10;
            score = score + pointsOnKill;
            Console.WriteLine("Your score is " + score);
            Console.WriteLine();

            int health;
            health = 100;
            /*Console.WriteLine("Health: " + health);
            Console.WriteLine();*/

            int shield;
            shield = 75;
            Console.WriteLine("Health " + health + "|"  + " Shields: " + shield);
            Console.WriteLine();

            Console.WriteLine("Damage Recieved!");
            Console.WriteLine("25 Damage taken!");
            Console.WriteLine();

            int enemyDamage;
            enemyDamage = 25;
            shield = shield - enemyDamage;
            Console.WriteLine("Health " + health + "|" + " Shields: " + shield);
            Console.WriteLine();

            int lives;
            lives = 3;
            Console.WriteLine("Lives left: " + lives);
            Console.WriteLine();

            Console.WriteLine("You Have Died");
            Console.WriteLine();

            lives --;
            Console.WriteLine("Lives left: " + lives);
            Console.WriteLine();

            int ammoInMagazine;
            ammoInMagazine = 30;
            Console.WriteLine("Ammo Count: " + ammoInMagazine);
            Console.WriteLine();
            Console.WriteLine("You opened fire on the enemy!");
            ammoInMagazine -= 15;
            Console.WriteLine("Ammo Count: " + ammoInMagazine);

            Console.WriteLine("The Enemy landed a hit!");
            Console.WriteLine("25 Damage taken!");
            Console.WriteLine();
            shield = shield - enemyDamage;
            Console.WriteLine("Health " + health + "|" + " Shields: " + shield);

            int scoreMultiplyer;
            scoreMultiplyer = 2;
            Console.WriteLine("You picked up a 2x multiplyer");
            Console.WriteLine();
            Console.WriteLine("Enemy killed!");
            Console.WriteLine();
            score = score + pointsOnKill * scoreMultiplyer;
            Console.WriteLine("Your score is " + score);

            Console.ReadKey(true);
        }
    }
}
