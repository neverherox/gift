using gift.Sweetnesses;
using System;
namespace gift.Biscuits
{
    public class OatmealBiscuit : Biscuit
    {
        public OatmealBiscuit(string name, double weight, double calories) : base(name, weight, calories)
        {
            FlourType = FlourType.Oatmeal;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(FlourType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories);
        }
    }
}
