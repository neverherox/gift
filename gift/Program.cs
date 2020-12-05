using gift.Biscuits;
using gift.Candy;
using gift.Functionality;
using gift.Sweetnesses;
using gift.Sweetnesses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sweetness> sweetnesses = new List<Sweetness>();
            sweetnesses.Add(new ChocolateCandy("Аленка", 10, 9, 8));
            sweetnesses.Add(new LolipopCandy("Чупа-Чупс", 11, 12, 13));
            sweetnesses.Add(new RyeBiscuit("Слодыч", 8, 5, 15));
            sweetnesses.Add(new OatmealBiscuit("Сдобыч", 15, 16, 3));
            sweetnesses.Add(new SoyBiscuit("Чоко-пай", 12, 25, 23));
            Gift gift = new Gift(sweetnesses);

            Console.WriteLine("Searched: ");
            List<Sweetness> searched = gift.SearchBySugar(10, 20);
            Printer printer = new Printer();
            printer.Print(searched.ToList<IPrintable>());

            Console.WriteLine("Gift is sorted by sugar: ");
            gift.SortBySugar();
            gift.PrintGift();


            Console.ReadKey();


        }
    }
}
