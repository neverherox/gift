using System;

namespace gift.Candy
{
    public class ChocolateCandy : Candy
    {
        public ChocolateCandy(string name, double weight, double calories, double sugar) : base(name, weight, calories, sugar)
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
