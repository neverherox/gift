using gift.Sweetnesses;
using System;
namespace gift.Biscuits
{
    public class SoyBiscuit : Biscuit, ISugarable
    {
        private double sugar;
        public double Sugar { get => sugar; set => sugar = value; }

        public SoyBiscuit(string name,  double weight,double calories, double sugar) : base(name, weight, calories)
        {
            FlourType = FlourType.Soy;
            Sugar = sugar;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight  + " Sugar: " + Sugar);
        }
    }
}
