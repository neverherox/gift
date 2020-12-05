using gift.Sweetnesses;
using System;

namespace gift.Biscuits
{
    public abstract class Biscuit : Sweetness
    {
        private FlourType flourType;
        public FlourType FlourType { get => flourType; protected set => flourType = value; }

        public Biscuit(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {

        }
        public override void Print()
        {
            base.Print();
            Console.Write("This biscuit is ");
        }
    }
}
