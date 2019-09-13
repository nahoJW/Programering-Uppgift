using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal mellan 1 och 100: "); //Skriver ut text
            Random rnd = new Random();//Lägger till 
            int RandomN = rnd.Next(0, 100);
            int AntalF = 1;
        while (true)
            {
                int WNumber = int.Parse(Console.ReadLine());

                AntalF++;

                if (RandomN == WNumber)
                { 
                     Console.WriteLine("Du vann");
                    Console.WriteLine("Antal försök: "+""+AntalF);
                     break;
                }

                if (RandomN < WNumber)
                {
                    Console.WriteLine("Du gissade för högt");
                    Console.WriteLine("Gissa igen");
                }

                if (RandomN > WNumber)
                {
                    Console.WriteLine("Du gissade för lågt");
                    Console.WriteLine("Gissa igen");
                }
            }

        }
    }
}
