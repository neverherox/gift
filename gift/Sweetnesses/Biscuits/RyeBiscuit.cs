using gift.Sweetnesses;
using System;
namespace gift.Biscuits
{
    public class RyeBiscuit : Biscuit, ICaloriable, ISugarable
    {
        private double calories;
        private double sugar;
        public double Calories { get => calories; set => calories = value; }
        public double Sugar { get => sugar; set => sugar = value; }

        public RyeBiscuit(string name, double weight, double calories, double sugar) : base(name, weight)
        {
            FlourType = FlourType.Rye;
            Calories = calories;
            Sugar = sugar;
        }
  
        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories + " Sugar: " + Sugar);
        }
    }
}
