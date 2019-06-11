using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Console.Clear();

            int j = 0;
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].Animals.Count < farm.GrazingFields[i].Capacity)
                {
                    Console.WriteLine($"{j + 1}. Grazing Field ({farm.GrazingFields[i].Animals.Count} animals)");
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
                if (farm.GrazingFields[choice - 1].Animals.Count < farm.GrazingFields[choice - 1].Capacity)
                {
                    farm.GrazingFields[choice - 1].AddResource(animal);
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