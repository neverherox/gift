using System;
namespace gift.Biscuits
{
    public class RyeBiscuit : Biscuit
    {
        public RyeBiscuit(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {
            FlourType = FlourType.Rye;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories + " Sugar: " + Sugar);
        }
    }
}
