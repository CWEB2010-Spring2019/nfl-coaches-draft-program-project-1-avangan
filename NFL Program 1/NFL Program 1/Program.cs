﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL_Program_1
{
    class Program
    {
        static void Main(string[] args) { } // check those brackets they might be wrong


            }

    // Player Class 
    public class player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public string school { get; set; }
        public double cost { get; set; }
        public string rank { get; set; }

        public player(int thisId, string thisName, int thisPosition, string thisSchool, double thisCost, string thisRank)
        // postion , school , price, 1st best , 2nd best , 3rd best , fourth best. 
        {
            id = thisId;
            name = thisName;
            position = thisPosition;
            school = thisSchool;
            cost = thisCost;
            rank = thisRank;
        }
    }

        // Multi Dimensional Array of Players
        string[,] nameArray = new string[8, 5]
            {
                {
                    "Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"
                },
                {
                    "Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"
                },
                {
                    "D.K. Metcalf","A.J. Brown","N'Keal Harry","Marquise Brown","Kelvin Harmon"
                },
                {
                    "Nick Bosa","Quinnen Williams","Ed Oliver","Jeffrey Simmons","Clelin Farrell"
                },
                {
                    "Greedy Williams","Deandre Baker","Byron Murphy","Deionte Thompson","Amani Oruwariye"
                },
                {
                    "Noah Fant","Irv Smith","T.J. Hockenson","Kaden Smith","Josh Oliver"
                },
                {
                    "Josh Allen","Devin White","Montez Sweat","Mack Wilson","Devin Bush"
                },
                {
                    "Jonah Williams","Greg Little","Cody Ford","Jawaan Taylor","Yodny Cajuste"
                }
            };
            // Multi Dimensional Array of Schools 

            string[,] schoolArray = new string[8, 5]
            {
                {
                    "Ohio St.","Oklahoma","Missouri","Duke","West Virginia"
                },
                {
                    "Alabama","Alabama","Iowa St.","Oklahoma St.","FAU"
                },
                {
                    "Ole Miss","Ole Miss","Arizona St.","Oklahoma","NC State"
                },
                {
                    "Ohio St.","Alabama","Houston","Miss. State","Clemson"
                },
                {
                    "LSU","Georgia","Washington","Alabama","Penn State"
                },
                {
                    "Iowa","Alabama","Iowa","Stanford","San Jose St."
                },
                {
                    "Kentucky","LSU","Miss. State","Alabama","Michigan"
                },
                {
                    "Alabama","Ole Miss","Oklahoma","Florida","West Virginia"
                },

            };

            // Multi Dimensional Array for the Price of a Player 
            double[,] costArray = new double[8, 5]
            {
                {
                    26400100.00,20300100.00,17420300.00,13100145.00,10300000.00
                },
                {
                    24500100.00,19890200.00,18700800.00,15000000.00,11600400.00
                },
                {
                    23400000.00,27900300.00,19300230.00,13400230.00,10000000.00
                },
                {
                    26200300.00,22000000.00,16000000.00,18000000.00,13000000.00
                },
                {
                    24000000.00,22500249.00,20000100.00,16000200.00,11899999.00
                },
                {
                    27800900.00,21000800.00,17499233.00,27900200.00,14900333.00
                },
                {
                    22900300.00,19000590.00,18000222.00,12999999.00,10000100.00
                },
                {
                    23000000.00,20000000.00,19400000.00,16200700.00,15900000.00
                },

            };
            // Multi Dimensional Array of Players Position 

            string[,] positionArray = new string[8, 5]
               {
                {
                    "Quarterback","Quarterback","Quarterback","Quarterback","Quarterback"
                },
                {
                    "Running Back","Running Back","Running Back","Running Back","Running Back"
                },
                {
                    "Wide Reciever","Wide Reciever","Wide Reciever","Wide Reciever","Wide Reciever"
                },
                {
                    "Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman"
                },
                {
                    "Defensive Back","Defensive Back","Defensive Back","Defensive Back","Defensive Back"
                },
                {
                    "Tight End","Tight End","Tight End","Tight End","Tight End"
                },
                {
                    "Linebacker","Linebacker","Linebacker","Linebacker","Linebacker"
                },
                {
                    "Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle"
                },

               };

        string[,] rank = new string[8, 5]

                  {
                {
                    "The Best","Second Best"," Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best"," Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },
                {
                    "The Best","Second Best","Third Best"," Fourth Best"," Fifth Best"
                },

               };


        // Creating a List of Players 
        // <player is my object , PlayerList is the name of the list
        // This is just creating the list not entering the values yet. 
        List<player> PlayerList = new List<player>();

    // seperate list . that sorted. notice the data types player object and int this list is keep your selections. 

            SortedList<int, player> mySelections = new SortedList<int, player>();

            //Iterate through the multi-Array and populate the list

            // the var col gets the colum and the var x gets the row
          

            for (var col = 0; col < 3; col++)
            {
                for (var x = 0; x < 3; x++)
                {
                    Candy aCandy = new Candy(idNumber[i, x], selection[i, x], price[i, x]);

                    candyList.Add(aCandy);


                }
            }

            //Output the List
            candyList.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("Please enter the name of the candy you would like to select");
            var candySelection = Console.ReadLine();



        }
    }

// 

    using System;
using System.Collections.Generic;

namespace project1
{


    class Program
    {
        static void Main(string[] args)
        {
            int[,] idNumber = new int[8, 5]
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

            string[,] names = new string[8, 5]
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

            string[,] positions = new string[8, 5]
            {
                {"Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
                {"Running Back", "Running Back", "Running Back", "Running Back", "Running Back"},
                {"Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
                {"Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
                {"Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back"},
                {"Tight End", "Tight End", "Tight End", "Tight End", "Tight End"},
                {"Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer"},
                {"Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle"}
            };

            string[,] schools = new string[8, 5]
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

            int[,] salarys = new int[8, 5]
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

            string[,] rankings = new string[8, 5]
            {
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
            };


            //lists of players
            List<Player> playerList = new List<Player>();
            List<Player> coachPicks = new List<Player>();
            int moneyLeft = 95000000;
            int moneySpent = 0;

            //going thru the arrays to fill int the list
            for (var i = 0; i < 8; i++)
            {
                for (var x = 0; x < 5; x++)
                {
                    Player aPlayer = new Player(names[i, x], positions[i, x], schools[i, x], salarys[i, x], rankings[i, x], idNumber[i, x]);
                    playerList.Add(aPlayer);
                }
            }

            //greeting message - start the program
            Greeting();

            /**    while loop     */

            string start = Console.ReadLine();
            string EXIT = "x"; //sentinel value

            while (start != EXIT)
            {
                Console.Clear();

                //output the list
                playerList.ForEach(x => Console.WriteLine(x.ToString()));

                Console.WriteLine("\nEnter number of player to draft:");

                int pick = Convert.ToInt32(Console.ReadLine());

                for (int i = playerList.Count - 1; i >= 0; i--)
                {
                    if (playerList[i].idNumber == pick)
                    {
                        coachPicks.Add(playerList[i]);
                        moneyLeft = moneyLeft - playerList[i].salary;
                        moneySpent = moneySpent + playerList[i].salary;
                        playerList.RemoveAt(i);
                    }


                }

                Console.WriteLine("To make another pick press 'Enter', to end draft press 'x'");
                start = Console.ReadLine();


            } //end WHILE

            Console.WriteLine("--------------------------------------------------------------------------\nYou've drafted:");
            foreach (Player i in coachPicks)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("\nYou've spent $" + moneySpent);
            Console.WriteLine("\nYou have $" + moneyLeft + " left to spend");
            Console.ReadLine();


        }// end of MAIN
