using gift.Sweetnesses.Interfaces;
using System;

namespace gift.Sweetnesses
{
    public abstract class Sweetness : ISugarable, IWeightable, ICaloriable, IPrintable
    {
        private string name;
        private double calories;
        private double weight;
        private double sugar;
        public string Name { get => name; set => name = value; }
        public double Calories { get => calories; set => calories = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Sugar { get => sugar; set => sugar = value; }

        public Sweetness(string name, double calories, double weight, double sugar)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
            Sugar = sugar;
        }

        public virtual void Print()
        {
            Console.Write("This is sweetness. ");
        }
    }
}
