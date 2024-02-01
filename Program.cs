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

                switch (petCare)
                {
                    case 1:
                        petHunger = Math.Max(0, petHunger - 2);
                        petHealth = Math.Min(10, petHealth + 1);
                        Console.WriteLine($"\nYou feed {petName}. His hunger decreases, and health improves slightly.");
                        break;

                    case 2:
                        petHappiness = Math.Min(10, petHappiness + 2);
                        petHunger = Math.Min(10, petHunger + 1);
                        Console.WriteLine($"\nYou played with {petName}. His happiness increases, and hunger increases slightly.");
                        break;

                    case 3:
                        petHealth = Math.Min(10, petHealth + 2);
                        petHappiness = Math.Max(0, petHappiness - 1);
                        Console.WriteLine($"\n{petName} is resting. His health improves, and happiness decreases slightly.");
                        break;

                    case 4:
                        Console.WriteLine($"\n{petName}'s Status: ");
                        Console.WriteLine($"- Hunger: " + Convert.ToString(petHunger));
                        Console.WriteLine($"- Health: " + Convert.ToString(petHealth));
                        Console.WriteLine($"- Happiness: " + Convert.ToString(petHappiness));
                        break;

                    case 5:
                        Console.WriteLine("\nThank you for using application.");
                        break;

                    default:
                        Console.WriteLine("\nInvalid options! Please select option from 1-5.");
                        break;
                }

                petHunger = Math.Min(10, petHunger + 1);
                petHappiness = Math.Max(0, petHappiness - 1);



            } while (petCare != 5);
        }
    }
}
