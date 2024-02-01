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

            Console.WriteLine("Please choose a type of pet: Cat, Dog or Rabbit etc..");

            Console.Write("User Input: ");
            petType = Console.ReadLine();


            Console.WriteLine($"\nYou've chosen a {petType}. What would you like to name your pet?");

            Console.Write("\nUser input: ");
            petName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {petName}! Let's take good care of him. \n");

        }
    }
}
