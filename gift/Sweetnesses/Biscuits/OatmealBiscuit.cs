using System;
namespace gift.Biscuits
{
    public class OatmealBiscuit : Biscuit
    {
        public OatmealBiscuit(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {
            FlourType = FlourType.Oatmeal;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories + " Sugar: " + Sugar);
        }
    }
}
