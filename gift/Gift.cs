using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;
using gift.Functionality;
using gift.NewFolder1;
using gift.Sweetnesses.Interfaces;
using gift.Functionality.Contracts;

namespace gift
{
    public class Gift
    {
        private ICalculator calculator;
        private ISearcher searcher;
        private ISorter sorter;
        private IPrinter printer;

        private ICollection<Sweetness> sweetnesses;
        public ICollection<Sweetness> Sweetnesses { get => sweetnesses; set => sweetnesses = value; }

        public Gift(ICollection<Sweetness> source)
        {
            Sweetnesses = source;
            printer = new Printer();
            calculator = new Calculator();
            searcher = new Searcher();
            sorter = new Sorter();
        }
        public void PrintGift()
        {
            printer.Print((IReadOnlyCollection<IPrintable>)Sweetnesses);
        }
        public double CalculateGiftWeight()
        {
            return calculator.CalculateWeight((IReadOnlyCollection<IWeightable>)Sweetnesses);
        }
        public ICollection<Sweetness> SearchBySugar(double min, double max)
        {
            ICollection<ISugarable> sugarables = Sweetnesses.OfType<ISugarable>().ToList();
            return searcher.SearchBySugar((IReadOnlyCollection<ISugarable>) sugarables, min, max).Cast<Sweetness>().ToList();
        }
        public void SortBySugarAsc()
        {
            Sweetnesses = sorter.SortBySugarAsc((IReadOnlyCollection<Sweetness>)Sweetnesses);           
        }
        public void SortBySugarDesc()
        {
            Sweetnesses = sorter.SortBySugarDesc((IReadOnlyCollection<Sweetness>)Sweetnesses);
        }
        public void SortByWeightAsc()
        {
            Sweetnesses = sorter.SortByWeightAsc((IReadOnlyCollection<Sweetness>)Sweetnesses);
        }
        public void SortByWeightDesc()
        {
            Sweetnesses = sorter.SortByWeightDesc((IReadOnlyCollection<Sweetness>)Sweetnesses);
        }
    }
}
