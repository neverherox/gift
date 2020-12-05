using gift.Sweetnesses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gift.NewFolder1
{
    public class Searcher
    {
        public List<ISugarable> SearchBySugar(List<ISugarable> sugarables, double min, double max)
        {
            return sugarables.Where(x => x.Sugar >= min && x.Sugar <= max).ToList();
        }
    }
}
