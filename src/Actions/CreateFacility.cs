using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Chicken house");
            Console.WriteLine("4. Duck house");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("A new grazing field has been created!");
                    break;
                case 3:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("A new chicken house has been created!");
                    break;
                case 4:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("A new duck house has been created!");
                    break;
                default:
                    Console.WriteLine($"Invalid option: {input}");
                    break;
            }
        }
    }
}