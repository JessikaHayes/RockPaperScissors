using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSza
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Random rand = new Random();
            //variables
            int cpuNum = 0;
            int userNum = 0;
            int Usercount = 0;
            int CpuCount = 0;

            Console.Write("ROCK - PAPER - SZA\n");

            while (true)
            {

            cpuNum = rand.Next(1, 3);
            

            Console.WriteLine("Your guess:" );
            userNum = int.Parse(Console.ReadLine());

            DrawHand(userNum);

            Console.Write("Computer's guess: ");
            DrawHand(cpuNum);
           
           if (userNum == 1 && cpuNum == 3 || userNum == 3 && cpuNum == 2 || userNum == 2 && cpuNum == 1) 
           {
                    Usercount++;
                    //keeps track
                    Console.WriteLine("User: " + Usercount);

                if (Usercount == 3)
                {
                    Console.WriteLine("User WINS!");
                }
           }
           else if (cpuNum == 1 && userNum == 3 || cpuNum == 3 && userNum == 2 || cpuNum == 2 && userNum == 1)
           {
                //cpu wins
                CpuCount++;
                Console.WriteLine("Computer: " + CpuCount);
                
                if (CpuCount == 3)
                {
                    Console.WriteLine("Computer WINS!");
                }
                }
                else
                {//if both numbers match
                    Console.WriteLine("Try Again!" );
                }


            }

            Console.ReadKey();
            
        }//end main

        static int DrawHand(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("  ROCK! IT'S LIT!");
                Console.WriteLine("    0o0o0o0o00o  ");
                Console.WriteLine("  o0o0o0o0o00o0o ");
                Console.WriteLine("  o0o0o0o0o00o0o ");
                Console.WriteLine("   0o0o0o0o00o0o ");
                Console.WriteLine("    o0o0o0o00o   ");
            }
            else if(num == 2)
            {
                Console.WriteLine("PAPER! AYY!");
                Console.WriteLine("___________");
                Console.WriteLine("_         _");
                Console.WriteLine("_         _");
                Console.WriteLine("_         _");
                Console.WriteLine("___________");
            }
            else if (num == 3)
            {
                Console.WriteLine("SZA! YAS!");
                Console.WriteLine(" Q     0 ");
                Console.WriteLine("  Q   0 ");
                Console.WriteLine("   Q 0 ");
                Console.WriteLine("    X  ");
                Console.WriteLine("  O   O  ");
                Console.WriteLine("(  ) (  )   ");



            }

            return num;


        }

        

    }


}
