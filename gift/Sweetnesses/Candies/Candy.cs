using gift.Sweetnesses;
using System;

namespace gift.Candy
{
    public abstract class Candy : Sweetness, ISugarable, ICaloriable
    {
        private double sugar;
        private double calories;
        private CandyType candyType;

        public double Sugar { get => sugar; set => sugar= value; }
        public double Calories { get => calories; set => calories = value; }

        public CandyType CandyType { get => candyType;protected set => candyType = value; }
       
        public Candy(string name, double weight, double calories, double sugar) : base(name, weight)
        {
            SweetnessType = SweetnessType.Candy;
            Calories = calories;
            Sugar = sugar;
        }
        public override void Print()
        {
            base.Print();
            Console.Write("This " + SweetnessType.ToString().ToLower() + " is ");
        }
    }
}
