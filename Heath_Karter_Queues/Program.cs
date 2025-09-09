using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;





namespace Heath_Karter_Queues

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(1000, "mmSix");
            Player p2 = new Player(1000, "xXAwesomenessXx");
            Player p3 = new Player(1000, "Get Good");
            Player p4 = new Player(1000, "ZombieSlaya");

            p1.JoinGame(myGame, waitingToJoinQ); 
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("players in da Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);


            Console.WriteLine("/nPlayers in da Q:");
            foreach (Player player in waitingToJoinQ) 
            {
                Console.WriteLine(player);
            }
        }
    }
}
