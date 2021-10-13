using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryExpressions
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new Ship { ID = 1, X = 0, Y = 0, CurrentHP = 50, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship { ID = 2, X = 4, Y = 2, CurrentHP = 75, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship { ID = 3, X = 9, Y = 3, CurrentHP =  0, MaxHP = 100, PlayerID = 2 });
            gameObjects.Add(new Ship { ID = 4, X = 0, Y = 0, CurrentHP = 100, MaxHP = 100, PlayerID = 3 });

            List<Player> players = new List<Player>();
            players.Add(new Player {ID = 1, UserName = "Player 1", TeamColor = "Red" });
            players.Add(new Player {ID = 2, UserName = "Player 2", TeamColor = "Blue" });

            IEnumerable<GameObject> aliveObjects = from o in gameObjects // All queries start with a from clause
                where o.CurrentHP > 0 // A where clause is used to filter elements in a collection based on some condition
                select o; // A query must end with a select clause (or a group clause)

            foreach (GameObject o in aliveObjects)
            {
                Console.WriteLine($"Player {o.ID} is alive");
            }
            
            // Challenge 1 - A collection of game objects that have full health

            IEnumerable<GameObject> fullHealth = from o in gameObjects
                where o.CurrentHP >= 100
                select o;

            foreach (GameObject o in fullHealth)
            {
                Console.WriteLine("There is a player with full health");
            }
            
            // Challenge 2 - A collection of the IDs of all game objects that have full health

            IEnumerable<int> fullHealthID = from o in gameObjects
                where o.CurrentHP >= 100
                select o.ID;

            foreach (int o in fullHealthID)
            {
                Console.WriteLine($"Player ID with full health: Player {o}");
            }
            
            // Challenge 3 - Rewrite the query 'aliveObjects' without using any LINQ methods or keywords

            foreach (var obj in aliveObjects)
            {
                if (obj.CurrentHP > 0)
                {
                    Console.WriteLine($"Player {obj.ID} is alive");
                }
            }
        }
    }
}