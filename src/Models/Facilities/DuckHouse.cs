using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<Duck> Animals
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource(Duck duck)
        {
            // TODO: implement this...
            _animals.Add(duck);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<Duck> resources)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}