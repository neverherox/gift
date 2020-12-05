using System;

namespace gift.Candy
{
    public class ChocolateCandy : Candy
    {
        public ChocolateCandy(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {
            CandyType = CandyType.Chocolate;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(CandyType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories + " Sugar: " + Sugar);
        }
    }
}
