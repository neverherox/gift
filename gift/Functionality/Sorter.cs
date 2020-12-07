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
           List<Sweetness> list = sweetnesses.Where(x => !HasSugar(x)).ToList();
           List<Sweetness> sugarables = sweetnesses.Where(HasSugar).OrderBy(x => ((ISugarable)x).Sugar).ToList();
           list.AddRange(sugarables);
           return list;
        }
        public ICollection<Sweetness> SortBySugarDesc(IReadOnlyCollection<Sweetness> sweetnesses)
        {
            List<Sweetness> list = sweetnesses.Where(x => !HasSugar(x)).ToList();
            List<Sweetness> sugarables = sweetnesses.Where(HasSugar).OrderByDescending(x => ((ISugarable)x).Sugar).ToList();
            list.AddRange(sugarables);
            return list;
        }
        private bool HasSugar(Sweetness sweetness)
        {
            return sweetness is ISugarable ? true : false;
        }
    }
}
