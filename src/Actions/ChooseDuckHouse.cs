using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, Duck animal)
        {
            // Console.Clear();

            int j = 0;
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].Animals.Count < farm.DuckHouses[i].Capacity)
                {
                    Console.WriteLine($"{j + 1}. Duck House ({farm.DuckHouses[i].Animals.Count} ducks)");
                    j++;
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            try
            {
                if (farm.DuckHouses[choice - 1].Animals.Count < farm.DuckHouses[choice - 1].Capacity)
                {
                    farm.DuckHouses[choice - 1].AddResource(animal);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"{choice} is not a valid option");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}