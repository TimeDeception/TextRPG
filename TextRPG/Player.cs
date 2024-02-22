using System;
public class Player
    {
        public string Name;
        public string PlayerClass;
        //Creates an empty array for the player stats- may be changed to add more stats.
        public static int[] Stats = new int[5];
        //An array the pairs with the player stats giving them a name.
         private static string[] statNames = {"HP", "STA", "STR", "MANA", "DEX"};
         //A list for the inventory so that I can add items to it without worrying about the limit that arrays have.
        private List <string> Inventory = new List<string>();
        //Creates a player class that can create objects or instances of the player.
        public Player(string name,string playerclass)
        {
            Name = name;
            PlayerClass = playerclass;
        }
        
        private static void setStats(int[] newStats)
        {
            if (newStats.Length == Stats.Length)
            {
                Array.Copy(newStats, Stats, Stats.Length);
            }
            else
            {
                Console.WriteLine("Not enough Stats to fill the array");
            }
        }
        //When called allows the player to select a class from the three options provided and sets the stats to that class - may add more if ihave the time.
        public static string chooseClass()
        {
            bool SelectClass = false;

            Console.WriteLine("Choose a starting class to play as...");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Assassin");
            Console.WriteLine("3. Wizard");

            //Puts the player in a loop until they select a valid class.
            while (SelectClass != true) 
            {
                string? characterClasses = Console.ReadLine();
                switch (characterClasses)
                {
                    case "warrior":
                        Console.WriteLine("You have chosen the Warrior class. Your Character Stats have been changed to fit class.");
                        int[] warriorStats = {15, 15, 10, 0, 10};
                        setStats(warriorStats);
                        SelectClass = true;
                        return "a Warrior";

                    case "assassin":
                        Console.WriteLine("You have chosen the Assassin class. Your Character Stats have been changed to fit class.");
                        int[] assassinsStats = {5, 10, 15, 5, 15};
                        setStats(assassinsStats);
                        SelectClass = true;
                        return "an Assassin";

                    case "wizard":
                        Console.WriteLine("You have chosen the Wizard class. Your Character Stats have been changed to fit class.");
                        int[] wizardsStats = {10, 10, 5, 15, 10};
                        setStats(wizardsStats);
                        SelectClass = true;
                        return "a Wizard";
                    default:
                        Console.WriteLine("Not a Valid Class, please choose a valid class");
                        SelectClass = false;
                        break;
                }
            }
            return "why does the code reach this point";
        }
        //Prints out the stats of the player.
        public void GetStats()
        {
            Console.WriteLine("Your Character Stats are: ");

            for(int i = 0; i < Stats.Length; i++)
            {
                Console.WriteLine($"{statNames[i]}: {Stats[i]}");
            }
        }
        //Allows the player to add the stat points gained after level up to their stats. Level up feature yet to be added.
        public void UpdateStats(int add)
        {
            int num;
            Console.WriteLine("To add stat points type in the amount for the selected stat then press enter. Amount can't exeed max what you have.");
            Console.WriteLine("You have "+ add + " free stat points to distribute.");
            for(int i = 0; i < Stats.Length; i++)
            {
                Console.WriteLine($"{statNames[i]}: {Stats[i]}");
                Console.WriteLine("Stats to add: ");
                num = Int32.Parse(Console.ReadLine());

                 if(add == 0)
                    {
                        Console.WriteLine("You have run out of free stats to distribute or you have not leveled up recently, level Up to gain more.");
                        i = 4;
                        break;
                    }
                    else if (num == 0)
                    {
                       continue;
                    }
                    else
                    {
                        while (num > 0)
                        {
                            if(num > add)
                            {
                                Console.WriteLine("Not enough stats points to add, please try againg and input a reasonabble number.");
                                num = Int32.Parse(Console.ReadLine());
                                continue;
                            }else
                            {
                                Stats[i] += num;
                                add -= num;
                                num = 0;
                                Console.WriteLine("You have " + add + " free stat points left.");
                            }
                        }
                    }            
            }
            Console.WriteLine("These are your new stats");
            for (int s = 0; s < Stats.Length; s++)
            {
                Console.WriteLine($"{statNames[s]}: {Stats[s]}");
            }
        }
        //When Items are discovered and picked up the player can store them in their inventory and this function adds them to the inventory list. -Work in Progress.
        public void UpdateInventory(string ItemType,string ItemName)
        {
            Inventory.Add(ItemName);
        }
        //Print out every item in the inventory and type but the second part is still in progress.
        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            Inventory.Add("sword");

            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }