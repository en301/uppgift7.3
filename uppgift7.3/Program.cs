using System;
using System.Collections.Generic;

namespace uppgift_7_3
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> storlek = new Dictionary<string, int>();
            storlek["Sverige"] = 450;
            storlek["Norge"] = 385;
            storlek["Danmark"] = 43;
            storlek["Finland"] = 338;

            Console.WriteLine("Skriv ett land av Sverige, Norge, Danmark och Finland som du vill veta storleken på.");
            string svar = Console.ReadLine();
            Console.WriteLine($"{svar} är ungefär {storlek[svar]} 000 km^2 stort till ytan");
            Console.ReadKey();
        }
    }
}