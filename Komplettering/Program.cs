using System;
using System.Numerics;
using System.Collections.Generic;

namespace Komplettering
{

    class Program
    {

        static void ReturnAge(int age)
        {
            if (age > 0 && age < 120)
            {
                Console.WriteLine("Wow du är hela " + age + " år gammal? Vad stor du har blivit!");
                ageGotten = true; //en korrekt ålder har skrivits in, programmet slutar loopas. 
            }
            else if (age > 120)
            {
                Console.WriteLine("Wow hela " + age + " år? Du är för gammal.");
            }
            else if (age < 0)
            {
                Console.WriteLine(age + " år? Du är int ens född än!");
            }
            else
            {
                Console.WriteLine("Det där är ingen giltig ålder");
            }
        }

        public static bool ageGotten = false;
        static void Main(string[] args)
        {
            //Spelets loop baseras på att den kommer att fortsätta fråga efter en ålder så länge den inte har blivit mellan 1 och 120
            while (ageGotten == false)
            {
                Console.WriteLine("Hur gammal är du?");
                string inputAge = Console.ReadLine();
                int result;
                bool isNumber = int.TryParse(inputAge, out result); //result blir 0 om inputAge innhåller bokstäver
                ReturnAge(result);
            }
            Console.ReadLine();
        }
    }
}
