using gift.Sweetnesses;
using System;
namespace gift.Biscuits
{
    public class OatmealBiscuit : Biscuit, ICaloriable
    {
        private double calories;
        public double Calories { get => calories; set => calories = value; }

        public OatmealBiscuit(string name, double weight, double calories) : base(name, weight)
        {
            FlourType = FlourType.Oatmeal;
            Calories = calories;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories);
        }
    }
}
