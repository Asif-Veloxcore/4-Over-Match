using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class MainClass
    {
        public static int overCount = 4;
        public static int runCount = 40;
        public static int viratRUNS = 0;
        public static int rohitRUNS = 0;
        public static int msDhoniRUNS = 0;
        public static int totalBalls = 24;
        //public string[] playerList;
        public static List<String> playerList = new List<string>()
        {
                "Virat Kohli","Rohit Sharma"
        };
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Match ! ");
            //playerList = new string[4]
            //{
            //    "V Kohli","B Kumar","J Bumrah","Shami Ahmed"
            //};
            
            
            string playerOnStrike = playerList[0];
            Random randomRun = new Random();
            Console.WriteLine(overCount + " Over Remaining ! " + runCount + " Runs Needed");
            Console.WriteLine();
            playerOnStrike = playerList[0];
            for (int balls = 24; balls >= 0; balls--)
            {                
                if (!(runCount <= 0))
                {
                    if (balls == 18)
                        Console.WriteLine("\n3 Over Remaining and " + runCount + " Runs Remaining\n");
                    else if (balls == 12)
                        Console.WriteLine("\n2 Over Remaining and " + runCount + " Runs Remaining\n");
                    else if (balls == 6)
                        Console.WriteLine("\n1 Over Remaining and " + runCount + " Runs Remaining\n");
                    int takenRun = randomRun.Next(0, 8);
                    switch (takenRun)
                    {
                        case 0:                            
                            Console.WriteLine("\tDOT ! " + playerOnStrike + " Scored " + takenRun + " Run\n");
                            if (playerOnStrike == playerList[1])
                            {
                                playerOnStrike = playerList[1];
                            }
                            else
                            {
                                playerOnStrike = playerList[0];
                            }
                            break;
                        case 1:
                            runCount--;
                            Console.WriteLine("\t" + playerOnStrike + " Scored " + takenRun + " Run\n");
                            if (playerOnStrike == playerList[0])
                            {
                                viratRUNS++;
                                playerOnStrike = playerList[1];
                            }
                            else
                            {
                                rohitRUNS++;
                                playerOnStrike = playerList[0];
                            }

                            break;
                        case 2:
                            if (runCount > 1)
                            {
                                runCount -= 2;
                                Console.WriteLine("\t" + playerOnStrike + " Scored " + takenRun + " Runs\n");
                                if (playerOnStrike == playerList[1])
                                {
                                    rohitRUNS += 2;
                                    playerOnStrike = playerList[1];
                                }
                                else
                                {
                                    viratRUNS += 2;
                                    playerOnStrike = playerList[0];
                                }
                            }

                            break;
                        case 3:
                            if (runCount > 2)
                            {
                                runCount -= 3;
                                Console.WriteLine("\t" + playerOnStrike + " Scored " + takenRun + " Runs\n");
                                if (playerOnStrike == playerList[0])
                                {
                                    viratRUNS += 3;
                                    playerOnStrike = playerList[1];
                                }
                                else
                                {
                                    rohitRUNS += 3;
                                    playerOnStrike = playerList[0];
                                }
                            }
                            break;
                        case 4:
                            if (runCount > 3)
                            {
                                runCount -= 4;
                                Console.WriteLine("\tFOUR !!! " + playerOnStrike + " Scored " + takenRun + " Runs\n");
                                if (playerOnStrike == playerList[1])
                                {
                                    rohitRUNS += 4;
                                    playerOnStrike = playerList[1];
                                }
                                else
                                {
                                    viratRUNS += 4;
                                    playerOnStrike = playerList[0];
                                }
                            }
                            break;
                        case 5:
                            if (runCount > 4)
                            {
                                runCount -= 5;
                                Console.WriteLine("\t" +playerOnStrike + " Scored " + takenRun + " Runs\n");
                                if (playerOnStrike == playerList[0])
                                {
                                    viratRUNS += 5;
                                    playerOnStrike = playerList[1];
                                }
                                else
                                {
                                    rohitRUNS += 5;
                                    playerOnStrike = playerList[0];
                                }
                            }
                            break;
                        case 6:                            
                            if (runCount > 5)
                            {
                                runCount -= 6;
                                Console.WriteLine("\tSIX !!! " +playerOnStrike + " Scored " + takenRun + " Runs\n");
                                if (playerOnStrike == playerList[1])
                                {
                                    rohitRUNS += 6;
                                    playerOnStrike = playerList[1];
                                }
                                else
                                {
                                    viratRUNS += 6;
                                    playerOnStrike = playerList[0];
                                }
                            }
                            break;
                        case 7:
                            if (playerOnStrike == playerList[0])
                            {
                                Console.WriteLine("\tOUTTTT !!! " + playerOnStrike + " Bowled ! \n");
                                playerList[0] = "MS Dhoni";
                                playerOnStrike = playerList[0];
                                Console.WriteLine("\tNew Batsman " + playerOnStrike + " On The Strike\n");                                
                            }
                            else
                            {
                                Console.WriteLine("\tOUTTTT !!! " + playerOnStrike + " Bowled ! \n");
                                playerList[1] = "MS Dhoni";
                                playerOnStrike = playerList[1];
                                Console.WriteLine("\tNew Batsman " + playerOnStrike + " On The Strike\n");
                            }
                            break;
                    }
                }                
            }
            if(runCount == 0)
            {
                Console.WriteLine("Congratulations ! Match Won\n");
            }
            else
            {
                Console.WriteLine("Match Lose\n");
            }
            Console.WriteLine("Virat Kohli Made "+viratRUNS+ " Runs \n");
            Console.WriteLine("Rohit Sharma Made "+rohitRUNS+ " Runs\n");
            if(playerList.Contains("MS Dhoni"))
            {
                Console.WriteLine("MS Dhoni Made " + msDhoniRUNS + " Runs\n");
            }
            if(viratRUNS > rohitRUNS &&viratRUNS > msDhoniRUNS)
                Console.WriteLine("Virat Kohli is The Man Of The Match \n");
            else if (rohitRUNS > viratRUNS && rohitRUNS > msDhoniRUNS)
                Console.WriteLine("Rohit Sharma is The Man Of The Match\n");
            else if (msDhoniRUNS > viratRUNS && msDhoniRUNS > rohitRUNS)
                Console.WriteLine("MS Dhoni is The Man Of The Match\n");

            Console.ReadLine();
        }
    }
}
