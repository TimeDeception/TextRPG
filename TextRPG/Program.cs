using System;
using System.Collections.Generic;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {   
            string className;
            bool Alive = true;
            //This is the Main game loop.
            while (Alive)
            {
                Console.WriteLine("What is your player name?:");
                string playerName = Console.ReadLine()!;

                className = Player.chooseClass();
                //Creating a player object/instance, probably not neccissary but who is gonna stop me?!
                Player player1 = new Player(playerName,className);
                Console.WriteLine("Your name is " + playerName + " and you are " + className);
                //Prints the stats of the player- see player.cs for more details.
                player1.GetStats();
                //prints out the inventory of the player- still a work in progress.
                player1.ShowInventory();
                //Ends the loop, only a temporary measure untill I impliment player death or other loss conditions.
                Alive = false;
            }
        } 
    }
}