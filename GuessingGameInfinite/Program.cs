using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit,1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis kasutaja on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            
            bool loopActive = true;

            
            while (loopActive)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber == cpuNumber)
                {
                    Console.WriteLine($"Juhuslik number on {cpuNumber}. Palju õnne! Oled võitnud!");
                    loopActive = false;
                    Console.WriteLine("Kena päeva!");
                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti:");
                }
                
            }



        }
    }
}
