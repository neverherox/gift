using System;

namespace gift.Candy
{
    public class LolipopCandy : Candy
    {
        public LolipopCandy(string name, double calories, double weight, double sugar) : base(name, calories, weight, sugar)
        {
            CandyType = CandyType.Lolipop;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(CandyType.ToString().ToLower() + " " + Name + " Weight: " + Weight + " Calories: " + Calories +  " Sugar: " + Sugar);
        }
    }
}
