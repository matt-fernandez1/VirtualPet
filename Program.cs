using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Barry the Blowfish, please press yes to continue!");
            string barry = Console.ReadLine();
            if (barry.ToLower() == "yes")
            {
                Console.WriteLine("Barry the Blowfish is an Interactive Pet, you will feed him, give him water, and play with him");
                Console.WriteLine("Barry has needs that you will assist him with, please press yes if you are up to the challenge");
                string Barry = Console.ReadLine();
                if (barry.ToLower() == "yes")
                {
                    BarrytheBlowfish();
                }
            }

        }

        static void BarrytheBlowfish()
        {
            while (true)
            {
                Console.WriteLine("1. Barry needs food, press 1 to feed him");
                Console.WriteLine("2. Barry needs water, press 2 to give him something to drink");
                Console.WriteLine("3. Barry is bored and wants to play. Press 3 to play with him");
                Console.WriteLine("4. Barry is satisfied and needs no care!");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Barry is full.He has full hunger of 10");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Barry is fully hydrated.He has full thirst of 10");
                }
                else if (answer == 3)
                {
                    Console.WriteLine("Barry is happy and energized. His boredom is full at 10");
                    break;
                }
                else
                {
                    Console.WriteLine("Barry has been well taken care of. Thank you for caring for him and go back to your day");
                }
            }
        }
    }
}
