// Ignore Spelling: PROG

using System;

namespace PROG8051_virtual_pet_simulator_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string petType;
            string petName;
            int petCare;
            int petHealth = 8;
            int petHunger = 5;
            int petHappiness = 5;

            Console.WriteLine("Please choose a type of pet: Cat, Dog or Rabbit etc..");

            Console.Write("User Input: ");
            petType = Console.ReadLine();


            Console.WriteLine($"\nYou've chosen a {petType}. What would you like to name your pet?");

            Console.Write("\nUser input: ");
            petName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {petName}! Let's take good care of him. \n");

            do
            {

                Console.WriteLine("\nMain Menu:");
                Console.WriteLine($"1. Feed {petName}");
                Console.WriteLine($"2. Play with {petName}");
                Console.WriteLine($"3. Let {petName} Rest");
                Console.WriteLine($"4. Check {petName}'s Status");
                Console.WriteLine($"5. Exit");

                Console.Write("\nUser Input: ");
                petCare = Convert.ToInt32(Console.ReadLine());




            } while (petCare != 5);
        }
    }
}
