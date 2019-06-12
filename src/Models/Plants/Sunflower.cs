using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, IFlower
    {
        private int _seedsProduced = 650;
        private double _compostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public int Harvest()
        {
            return _seedsProduced;
        }
        public double Compost()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Sesame. Yum!";
        }
    }
}