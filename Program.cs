using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    
    class Program
    {
        class Maingame
        {
            private string[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int counter;
            public string player;

            public void game()
            {
                table();
                verify();
                Player();
                play();

            }
            void table()
            {
                Console.WriteLine();
                Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", values[0], values[1], values[2]);
                Console.WriteLine("\t-----------------");       
                Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", values[3], values[4], values[5]);
                Console.WriteLine("\t-----------------");
                Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", values[6], values[7], values[8]);
            }
            int choice, flag;
            public string player1,player2;
            public void register()
            {              
                Console.WriteLine("-----REGISTRATION----");
                Console.Write("\nName of first player  : ");
                player1 = Console.ReadLine();
                
                Console.Write("Name of second player : ");
                player2 = Console.ReadLine();
                player = player1;
                Console.Clear();
            }
            void Player()
            {
                if(counter==0)
                {
                    counter++;
                    input();
                }
                
                else if(player==player1)
                    {
                        player = player2;
                        flag = 1;
                        input();
                    }
                else
                    {
                        player = player1;
                        flag = 2;
                        input();
                    }
            }
            void input()
            {
                Console.Write("\n{0} : ", player);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            string update;
            void play()
            {
                if(player==player1)
                    {
                        update = "X";
                    }
                else
                    {
                        update = "O";
                    }
                switch(choice)
                    {
                        case 1:
                            {
                                if(values[0]=="1")
                                {
                                    values[0] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                   if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 2:
                            {
                                if (values[1] == "2")
                                {
                                    values[1] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 3:
                            {
                                if (values[2] == "3")
                                {
                                    values[2] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 4:
                            {
                                if (values[3] == "4")
                                {
                                    values[3] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 5:
                            {
                                if (values[4] == "5")
                                {
                                    values[4] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 6:
                            {
                                if (values[5] == "6")
                                {
                                    values[5] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 7:
                            {
                                if (values[6] == "7")
                                {
                                    values[6] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 8:
                            {
                                if (values[7] == "8")
                                {
                                    values[7] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        case 9:
                            {
                                if (values[8] == "9")
                                {
                                    values[8] = update;
                                }
                                else
                                {
                                    Console.WriteLine("\nCan't place in this position!\n");
                                    if (flag == 1)
                                        player = player1;
                                    else if (flag == 2)
                                        player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nWrong input...Try again!\n");

                            if (flag == 1)
                                player = player1;
                            else if (flag == 2)
                                player = player2;
                                Console.WriteLine("Press any key to continue!");
                                Console.ReadKey();
                            break;
                            }
                }
                Console.Clear();
                game();
            }
            void verify()
            {
                if(values[0]==values[1] && values[1]==values[2])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[0] == values[3] && values[3] == values[6])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[3] == values[4] && values[4] == values[5])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[6] == values[7] && values[7] == values[8])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[1] == values[4] && values[4] == values[7])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[2] == values[5] && values[5] == values[8])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[0] == values[4] && values[4] == values[8])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if (values[2] == values[4] && values[4] == values[6])
                {
                    Console.WriteLine("\n\nCongratulations {0}, You have won the game!", player);
                    Replay();
                }
                else if(values[0]!="1" && values[1] != "2" && values[2] != "3" && values[3] != "4" && values[4] != "5" && values[5] != "6" && values[6] != "7" && values[7] != "8" && values[8] != "9")
                {
                    Console.WriteLine("\n\n!Game Draw, Both of you have played well!\n\n");
                    Replay();
                }
            }
            string replay;
            void Replay()
            {
            label:
                Console.WriteLine("\nDo you want to play again? (y/n)");
                replay = Console.ReadLine();
                if (replay == "y" || replay == "Y")
                {
                    Console.Clear();
                    Program.Main(null);
                }
                else if (replay == "n" || replay == "N")
                {
                    Console.WriteLine("\nThank you for playing the game!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                    goto label;
                }

            }
            public void intro()
            {
                Console.WriteLine();
                Console.WriteLine("  Tic  |   X   |  Tic  ");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   O   |  Tac  |   O   ");
                Console.WriteLine("-----------------------");
                Console.WriteLine("  Toe  |   X   |  Toe  ");
                Console.WriteLine("\n\nGame Name: Tic Tac Toe");
                Console.WriteLine("Made By  : Shiam Prodhan");
                Console.WriteLine("ID\t : 181014123");
                Console.Write("\nPress any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.Title="TicTacToe by Shiam Prodhan";
            Maingame access = new Maingame();
            access.intro();
            access.register();
            access.game();
            
        }
    }
}
