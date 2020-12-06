using gift.Sweetnesses.Interfaces;
using System;

namespace gift.Sweetnesses
{
    public abstract class Sweetness : IWeightable, IPrintable
    {
        private string name;
        private double weight;
        private SweetnessType sweetnessType;
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public SweetnessType SweetnessType { get => sweetnessType; set => sweetnessType = value; }

        public Sweetness(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public virtual void Print()
        {
            Console.Write("This is sweetness. ");
        }
    }
}
