using gift.Sweetnesses;
using System;

namespace gift.Biscuits
{
    public abstract class Biscuit : Sweetness
    {
        private FlourType flourType;
        public FlourType FlourType { get => flourType; protected set => flourType = value; }

        public Biscuit(string name, double weight, double calories) : base(name, weight, calories)
        {
            SweetnessType = SweetnessType.Biscuit;
        }
        public override void Print()
        {
            base.Print();
            Console.Write("This " + SweetnessType.ToString().ToLower() + " is ");
        }
    }
}
