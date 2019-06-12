using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<IFlower>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<IFlower> _plants = new List<IFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IFlower> Plants
        {
            get
            {
                return _plants;
            }
        }

        public void AddResource(IFlower plant)
        {
            // TODO: implement this...
            _plants.Add(plant);
        }

        public void AddResource(List<IFlower> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._plants.Count} rows of plants\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}