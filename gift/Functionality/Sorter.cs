using gift.Functionality.Contracts;
using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;


namespace gift.Functionality
{
    public class Sorter : ISorter
    {
        public ICollection<Sweetness> SortBySugarAsc(IReadOnlyCollection<Sweetness> sweetnesses)
        {
            List<Sweetness> list = sweetnesses.Where(x => !(x is ISugarable)).ToList();
            List<Sweetness> sugarables = sweetnesses.Where(x => x is ISugarable).OrderBy(x => ((ISugarable)x).Sugar).ToList();
            list.AddRange(sugarables);
            return list;
        }
        public ICollection<Sweetness> SortBySugarDesc(IReadOnlyCollection<Sweetness> sweetnesses)
        {
            List<Sweetness> list = sweetnesses.Where(x => !(x is ISugarable)).ToList();
            List<Sweetness> sugarables = sweetnesses.Where(x => !(x is ISugarable)).OrderByDescending(x => ((ISugarable)x).Sugar).ToList();
            list.AddRange(sugarables);
            return list;
        }
        public ICollection<Sweetness> SortByWeightAsc(IReadOnlyCollection<Sweetness> sweetnesses)
        {
            return sweetnesses.OrderBy(x => x.Weight).ToList();
        }

        public ICollection<Sweetness> SortByWeightDesc(IReadOnlyCollection<Sweetness> sweetnesses)
        {
            return sweetnesses.OrderByDescending(x => x.Weight).ToList();
        }

    }
}
