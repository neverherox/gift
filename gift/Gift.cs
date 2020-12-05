using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;
using gift.Functionality;
using gift.NewFolder1;
using gift.Sweetnesses.Interfaces;
using System;

namespace gift
{
    public class Gift
    {
        private Calculator calculator;
        private Searcher searcher;
        private Sorter sorter;
        private Printer printer;

        private List<Sweetness> sweetnesses;
        public List<Sweetness> Sweetnesses { get => sweetnesses; set => sweetnesses = value; }

        public Gift(List<Sweetness> source)
        {
            Sweetnesses = source;
            printer = new Printer();
            calculator = new Calculator();
            searcher = new Searcher();
            sorter = new Sorter();
        }
        public void PrintGift()
        {
            printer.Print(Sweetnesses.ToList<IPrintable>());
        }
        public double CalculateGiftWeight()
        {
            return calculator.CalculateWeight(Sweetnesses.ToList<IWeightable>());
        }
        public List<Sweetness> SearchBySugar(double min, double max)
        {
            List<ISugarable> searched = searcher.SearchBySugar(Sweetnesses.ToList<ISugarable>(), min, max);
            return searched.Cast<Sweetness>().ToList();
        }

        public void SortBySugar()
        {
            List<ISugarable> sorted = sorter.SortBySugar(Sweetnesses.ToList<ISugarable>());
            sweetnesses = sorted.Cast<Sweetness>().ToList();
        }
    }
}
