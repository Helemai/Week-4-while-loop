using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit,1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis kasutaja on mängu võitnud
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3) 
            {
                Console.WriteLine("Sisesta number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (cpuNumber == userNumber)
                {
                    Console.WriteLine($"Juhuslik number on {cpuNumber}. Palju õnne, võitsid mängu!");
                    break;
                }
                else 
                { 
                    i = i + 1;
                        Console.WriteLine($"Vale number {3 - i} katset jäänud.");

                    }              
        

                
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
