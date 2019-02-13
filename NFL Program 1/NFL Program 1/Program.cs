using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL_Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] playerId = new int[8, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25},
                {26, 27, 28, 29, 30},
                {31, 32, 33, 34, 35},
                {36, 37, 38, 39, 40}
            };

            string[,] playername = new string[8, 5]
            {
                {"Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"},
                {"Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"},
                {"D.K. Metclaf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon"},
                {"Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell"},
                {"Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye"},
                {"Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver"},
                { "Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush" },
                {"Jonah Williams", "Greg Litte", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste"}
            };

            string[,] playerposition = new string[8, 5]
            {
                {"Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
                {"Running Back", "Running Back", "Running Back", "Running Back", "Running Back"},
                {"Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
                {"Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
                {"Defensive Back", "Defensive Back", "Defensive Back", "Defensive Back", "Defensive Back"},
                {"Tight End", "Tight End", "Tight End", "Tight End", "Tight End"},
                {"Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer"},
                {"Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle"}
            };

            string[,] playerRank = new string[8, 5]
            {
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"}
            };

            string[,] school = new string[8, 5]
            {
                {"Ohio St.", "Oklahoma", "Missouri", "Duke", "West Virginia"},
                {"Alabama", "Alabama", "Iowa St.", "Oklahoma St.", "FAU"},
                {"Ole Miss", "Ole Miss", "Arizona St.", "Oklahoma", "NC State"},
                {"Ohio St.", "Alabama", "Houston", "Miss. St.", "Clemson"},
                {"LSU", "Georgia", "Washingtion", "Alabama", "Penn State"},
                {"Iowa", "Alabama", "Iowa", "Stanford", "San Jose St."},
                {"Kentuky", "LSU", "Miss. State", "Alabama", "Michigan"},
                {"Alabama", "Ole Miss", "Oklahoma", "Florida", "West Virgina"}
            };

            int[,] playerSal = new int[8, 5]
            {
                {26400100, 20300100, 17420300, 13100145, 10300000},
                {24500100, 19890200, 18700800, 15000000, 11600400},
                {23400000, 21900300, 19300230, 13400230, 10000000},
                {26200300, 22000000, 16000000, 18000000, 13000000},
                {24000000, 22500249, 20000100, 16000200, 11899999},
                {27800900, 21000800, 17499233, 27900200, 14900333},
                {22900300, 19000590, 18000222, 12999999, 10000100},
                {23000000, 20000000, 19400000, 16200700, 15900000}
            };


            //List of Players
            List<Player> PlayersList = new List<Player>();
            List<Player> CoachChoice = new List<Player>();

            // playerSal
            int Bank = 95000000;
            int PlayersCost = 0;

            // Create List   
            for (var col = 0; col < 8; col++)
            {
                for (var row = 0; row < 5; row++)
                {
                    Player aPlayer = new Player(playername[col, row], playerposition[col, row], school[col, row], playerSal[col, row], playerRank[col, row], playerId[col, row]);
                    PlayersList.Add(aPlayer);
                }
            }

            // start of program
            Console.WriteLine("Welcome to the NFL Drafting Program!");
            Console.WriteLine("To begin the program, please press 'Enter'");


            string start = Console.ReadLine();
            string EXIT = "q";

            while (start != EXIT)
            {
                Console.Clear();

                //Write list 
                PlayersList.ForEach(x => Console.WriteLine(x.ToString()));

                Console.WriteLine("\nPlease enter the player you want to pick");

                //Convert to INT
                int pick = Convert.ToInt32(Console.ReadLine());

                {

                }

                for (int i = PlayersList.Count - 1; i >= 0; i--)
                {
                    if (PlayersList[i].playerId == pick)
                    {
                        CoachChoice.Add(PlayersList[i]);
                        Bank = Bank - PlayersList[i].playerSal;
                        PlayersCost = PlayersCost + PlayersList[i].playerSal;
                        PlayersList.RemoveAt(i);
                    }

                }
                if (Bank <= 0)
                {
                    Console.Clear();

                    Console.WriteLine("Sorry your out of draft money");

                    start = "q";
                    Console.ReadLine();
                }
                else
                {
                    if (CoachChoice.Count >= 5)
                    {
                        start = "q";
                    }
                    else
                    {
                        Console.Clear();

                        
                        foreach (Player i in CoachChoice)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("\nThe amount of money you have spent is : $" + PlayersCost);
                        Console.WriteLine("Current budget $" + Bank);
                    
                        Console.WriteLine("To continue drafting players, Press 'Enter'");
                        Console.WriteLine("To  the quit the program, Please enter 'q'");
                        start = Console.ReadLine();
                    }
                }

            } 

            Console.Clear();
            Console.WriteLine("\n- Nice Choice you have got:" + playername);
            foreach (Player i in CoachChoice)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\nTotal playerSal: $" + PlayersCost);
            Console.WriteLine("\nAmount of budget leftover: $" + Bank);
            close();
            Console.ReadLine();


        }

        static void close()
        {

            Console.WriteLine("Thank you for participating in this Draft.");
        }
    }

    public class Player
    {
        public int playerId { get; set; }
        public string player { get; set; }
        public string playerposition { get; set; }
        public string school { get; set; }
        public int playerSal { get; set; }
        public string playerRank { get; set; }

        public Player(string player, string playerposition, string school, int playerSal, string playerRank, int playerId)
        {
            this.playerId = playerId;
            this.player = player;
            this.playerposition = playerposition;
            this.playerSal = playerSal;
            this.school = school;
            this.playerRank = playerRank;
        }

        public override string ToString()
        {
            return String.Format("{0,-10} | {1,-21} | {2,-13} | {3,-22} | {4,-18} | {5:-23} |", playerId + ". ", player, playerposition, "$" + playerSal,  school, playerRank );
        }
    }
}
