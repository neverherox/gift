using gift.Functionality.Contracts;
using gift.Sweetnesses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gift.NewFolder1
{
    public class Searcher : ISearcher
    {
        public ICollection<ISugarable> SearchBySugar(IReadOnlyCollection<ISugarable> sugarables, double min, double max)
        {
            return sugarables.Where(x => x.Sugar >= min && x.Sugar <= max).ToList();
        }
    }
}
