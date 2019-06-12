using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();
        public int Cows()
        {
            return _animals.FindAll(anml => anml.Type == "Cow").Count;
        }
        public int Pigs()
        {
            return _animals.FindAll(anml => anml.Type == "Pig").Count;
        }
        public int Goats()
        {
            return _animals.FindAll(anml => anml.Type == "Goat").Count;
        }
        public int Ostriches()
        {
            return _animals.FindAll(anml => anml.Type == "Ostrich").Count;
        }
        public int Sheep()
        {
            return _animals.FindAll(anml => anml.Type == "Sheep").Count;
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IGrazing> Animals
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource(IGrazing animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}