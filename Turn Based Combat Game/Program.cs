using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 50;
            int enemyHP = 30;

            int playerAttack = 5;
            int enemyAttack = 8;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                // player's turn
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP: " + playerHP + ", Enemy HP: " + enemyHP);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string move = Console.ReadLine()!;
                if (move == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack. Enemy takes " + playerAttack + " damage!");
                }
                else if (move == "h")
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " HP!");
                }
                else
                {
                    Console.WriteLine("Invalid move. Player skips turn!");
                }

                // enemy's turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP: " + playerHP + ", Enemy HP: " + enemyHP);

                    int enemyMove = random.Next(0, 2);

                    if (enemyMove == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attack. Player takes " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " HP!");
                    }
                }
            }

            if (playerHP > 0)
            {
                Console.WriteLine("Congratulations, you win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}