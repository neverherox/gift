using gift.Biscuits;
using gift.Candy;
using gift.Functionality;
using gift.Sweetnesses;
using gift.Sweetnesses.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace gift
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Sweetness> sweetnesses = new Collection<Sweetness>();
            sweetnesses.Add(new OatmealBiscuit("name1", 13, 25));
            sweetnesses.Add(new RyeBiscuit("name2", 12, 10, 11));
            sweetnesses.Add(new SoyBiscuit("name3", 12, 111, 10));
            sweetnesses.Add(new ChocolateCandy("name4", 2, 10, 18));
            sweetnesses.Add(new LolipopCandy("name5", 11, 11, 11));
            Gift gift = new Gift(sweetnesses);

            Console.WriteLine("Initial gift: ");
            gift.PrintGift();


            int min = 10, max = 11;
            Console.WriteLine("\nSearched by sugar in: [" + min + "; " + max + "]");

            ICollection<Sweetness> searched = gift.SearchBySugar(min, max);
            Printer printer = new Printer();
            printer.Print(searched.ToList<IPrintable>());


            Console.WriteLine("\nGift is sorted by sugar: ");
            gift.SortBySugarAsc();
            gift.PrintGift();


            Console.WriteLine("\nTotal weight: " + gift.CalculateGiftWeight());

            Console.ReadKey();


        }
    }
}
