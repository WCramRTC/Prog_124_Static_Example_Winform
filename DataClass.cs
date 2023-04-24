using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Static_Example_Winform
{
    // Using a Data class for a single location for all of your information
    internal static class DataClass
    {
        // All classes will have access to this single shared list
        public static List<Player> _players;

        // STATIC CONSTRUCTOR
        // is always private and cannot be called on its own
        // Is called when ANYthing inside of the class is called
        // Run before initiating object is called

        static DataClass() {
            // Initalizes a list on first list call
            _players = new List<Player>();
            // Preload to add a player
            _players.Add(new Player("Will", 57));

        } // static class

        // Static method that can be used to interact with the static class
        public static void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public static void RemovePlayer(Player player)
        {
            _players.Remove(player);
        }
    }
}
