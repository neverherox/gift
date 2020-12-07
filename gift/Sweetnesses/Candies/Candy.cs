using gift.Sweetnesses;
using System;

namespace gift.Candy
{
    public abstract class Candy : Sweetness, ISugarable
    {
        private double sugar;
        private CandyType candyType;

        public double Sugar { get => sugar; set => sugar= value; }

        public CandyType CandyType { get => candyType;protected set => candyType = value; }
       
        public Candy(string name, double weight, double calories, double sugar) : base(name, weight, calories)
        {
            SweetnessType = SweetnessType.Candy;
            Sugar = sugar;
        }
        public override void Print()
        {
            base.Print();
            Console.Write("This " + SweetnessType.ToString().ToLower() + " is ");
        }
    }
}
