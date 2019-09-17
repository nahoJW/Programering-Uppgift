using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal mellan 1 och 100: "); //Skriver in text 
            Random rnd = new Random(); //Generarear ett slumpmässig tal
            int RandomN = rnd.Next(0, 100);//Sägger att talet ska vara mellan 0 och 100
            int AntalF = 1; //Skapar en variabel för antal försök
        while (true) //Skapar en loop för att man ska kunna gissa flera gånger
            {
                int WNumber = int.Parse(Console.ReadLine());//Spakar en variabel för numret som skrivits in

                AntalF++;//Lägger till 1 på antal försök så att det ökar med en vaje gång loopen upprepas


                if (RandomN < WNumber)//Ifall det slupmässiga<inskrivna så händer det inom: {}
                {
                    Console.WriteLine("Du gissade för högt");//Skirver att personen gissa för högt
                    Console.WriteLine("Gissa igen");//Skriver gissa igen
                }

                else if (RandomN > WNumber) //Ifall det slupmässiga talet > det inskrivna talet så händer det inom: {}
                {
                    Console.WriteLine("Du gissade för lågt");//Skriver att personen gissade för högt
                    Console.WriteLine("Gissa igen");//Skriver att personen ska försöka igen
                }

                else //Ifall det slupmässiga talet är samma som det inskrivna så händer det inom: {}
                { 
                     Console.WriteLine("Du vann");//Skriver att personen vann 
                    Console.WriteLine("Antal försök: "+""+AntalF);//Skriver ut hur många gånger personen försökt
                     break;//stoppar loopen
                }
            }

        }
    }
}

