using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heath_Karter_Queues
{
    internal class Game
    {
        // Maximum number of players allowed in the game
        public int MaxPlayers { get; set; }

        // Number of players currently in the game
        public int CurrentPlayers { get; set; }

        // Constructor to initialize max players and current players
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        // Method to remove one player from the game
        public void KickPlayer()
        {
            CurrentPlayers--; // Decrease the number of current players by 1
        }

        // Method to check if players are waiting in the queue and move them into the game
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // Only add players if the game is not full
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0) // Check if the queue has players
                {
                    playerQueue.Dequeue(); // Remove the first player from the queue
                    CurrentPlayers++;     // Increase current players as one joined
                }
                else
                {
                    // If the queue is empty, inform the user
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
