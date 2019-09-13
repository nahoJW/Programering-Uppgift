using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal: ");
            Random rnd = new Random();
            int RandomN = rnd.Next(0, 100);
        while (true)
            {
                int WNumber = int.Parse(Console.ReadLine());

                if (RandomN == WNumber)
                { 
                     Console.WriteLine("Du vann");
                     break;
                }

                if (RandomN < WNumber)
                {
                    Console.WriteLine("Du gissade för högt");
                }

                if (RandomN > WNumber)
                {
                    Console.WriteLine("Du gissade för lågt");
                }
            }

        }
    }
}
