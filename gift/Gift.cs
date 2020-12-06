using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;
using gift.Functionality;
using gift.NewFolder1;
using gift.Sweetnesses.Interfaces;

namespace gift
{
    public class Gift
    {
        private WeightCalculator calculator;
        private Searcher searcher;
        private Sorter sorter;
        private Printer printer;

        private List<Sweetness> sweetnesses;
        public List<Sweetness> Sweetnesses { get => sweetnesses; set => sweetnesses = value; }

        public Gift(List<Sweetness> source)
        {
            Sweetnesses = source;
            printer = new Printer();
            calculator = new WeightCalculator();
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
            List<ISugarable> sugarables = sweetnesses.OfType<ISugarable>().ToList();
            return searcher.SearchBySugar(sugarables, min, max).Cast<Sweetness>().ToList();
        }

        public void SortBySugar()
        {
            List<ISugarable> sugarables = sweetnesses.OfType<ISugarable>().ToList();
            sugarables = sorter.SortBySugar(sugarables);
            sweetnesses.RemoveAll(x => x is ISugarable);
            Sweetnesses.AddRange(sugarables.Cast<Sweetness>().ToList());
        }
    }
}
