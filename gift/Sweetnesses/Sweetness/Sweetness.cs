using gift.Sweetnesses.Interfaces;
using System;

namespace gift.Sweetnesses
{
    public abstract class Sweetness : IWeightable, IPrintable, ICaloriable
    {
        private string name;
        private double weight;
        private double calories;
        private SweetnessType sweetnessType;
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Calories { get => calories; set => calories = value; }

        public SweetnessType SweetnessType { get => sweetnessType; set => sweetnessType = value; }

        public Sweetness(string name, double weight, double calories)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
        }

        public virtual void Print()
        {
            Console.Write("This is sweetness. ");
        }
    }
}
