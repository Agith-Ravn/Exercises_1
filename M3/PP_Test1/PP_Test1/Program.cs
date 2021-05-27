using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

    }

    public class DiceGame
    {
        public void Test()
        {
            // int = nummer datatype, altså en "lagringsplass" for tall
            // Vi kaller lagringsplassen "playerRandomNum" og enemyRandomNum
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            // Random nummer generator som kalles for "random"
            Random random = new Random();

            //For loop 10x
            for (int i = 0; i < 10; i++)
            {
                //Sier at du skal taste noe 10x
                Console.WriteLine("Press any key to roll the dice.");

                //leser det du skriver inn 
                Console.ReadKey();

                //playerRandomNum variable får et tilfeldig nummer mellom 1 og 7 -> Skriver ut tallet
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);

                //Skriver ut ... > Liten pause på 1 sek
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                //enemyRandomNum variable får et tilfeldig nummer mellom 1 og 7 -> Skriver ut tallet
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            //Hvis playerPoints er mindre enn enemyPoints -> Skriv ut YouLose ellers "Its a draw"
            Console.WriteLine(playerPoints < enemyPoints ? "You Lose" : "its a draw");
            Console.ReadKey();
        }
    }
}
