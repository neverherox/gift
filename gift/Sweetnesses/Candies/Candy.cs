using gift.Sweetnesses;
using System;

namespace gift.Candy
{
    public abstract class Candy : Sweetness
    {
        private CandyType candyType;

        public CandyType CandyType { get => candyType;protected set => candyType = value; }

        public Candy(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {

        }
        public override void Print()
        {
            base.Print();
            Console.Write("This sweeet is ");
        }
    }
}
