using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal mellan 1 och 100: "); //Writes text 
            Random rnd = new Random(); 
            int RandomN = rnd.Next(0, 100);//Choose a number between 1 and 100
            int AntalF = 1; //Antal försök
        while (true)
            {
                int WNumber = int.Parse(Console.ReadLine());//Creates variable for the writen number

                AntalF++;//+1 on number of tries

                if (RandomN == WNumber)
                { 
                     Console.WriteLine("Du vann");
                    Console.WriteLine("Antal försök: "+""+AntalF);
                     break;
                }//If you're right write "you won", number of tries and ends the game

                if (RandomN < WNumber)
                {
                    Console.WriteLine("Du gissade för högt");
                    Console.WriteLine("Gissa igen");
                }//If to hight type "to high" and "try again"

                if (RandomN > WNumber)
                {
                    Console.WriteLine("Du gissade för lågt");
                    Console.WriteLine("Gissa igen");
                }//If to low type "to low" and "try again"
            }

        }
    }
}

