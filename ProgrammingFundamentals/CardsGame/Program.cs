using System;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var player2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var p1CardsCount = player1.Count;
            var p2CardsCount = player2.Count;

            while(p1CardsCount > 0 && p2CardsCount > 0)
            {
                if(player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if(player2[0] > player1[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                    player2.RemoveAt(0);
                    player1.RemoveAt(0);
                }
                else if(player1[0] == player2[0])
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }

                p1CardsCount = player1.Count;
                p2CardsCount = player2.Count;
            }

            if(p1CardsCount > p2CardsCount)
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }

            if(p2CardsCount > p1CardsCount)
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
        }
    }
}
