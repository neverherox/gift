using gift.Sweetnesses;
using System.Collections.Generic;

namespace gift.Functionality.Contracts
{
    public interface ISearcher
    {
        ICollection<ISugarable> SearchBySugar(IReadOnlyCollection<ISugarable> sugarables, double min, double max);
    }
}
