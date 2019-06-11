using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken animal)
        {
            // Console.Clear();

            int j = 0;
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if (farm.ChickenHouses[i].Animals.Count < farm.ChickenHouses[i].Capacity)
                {
                    Console.WriteLine($"{j + 1}. Chicken House ({farm.ChickenHouses[i].Animals.Count} animals)");
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
                if (farm.ChickenHouses[choice - 1].Animals.Count < farm.ChickenHouses[choice - 1].Capacity)
                {
                    farm.ChickenHouses[choice - 1].AddResource(animal);
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