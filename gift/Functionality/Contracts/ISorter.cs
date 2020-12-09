using gift.Sweetnesses;
using System.Collections.Generic;

namespace gift.Functionality.Contracts
{
    public interface ISorter
    {
        ICollection<Sweetness> SortBySugarAsc(IReadOnlyCollection<Sweetness> sweetnesses);
        ICollection<Sweetness> SortBySugarDesc(IReadOnlyCollection<Sweetness> sweetnesses);

        ICollection<Sweetness> SortByWeightAsc(IReadOnlyCollection<Sweetness> sweetnesses);
        ICollection<Sweetness> SortByWeightDesc(IReadOnlyCollection<Sweetness> sweetnesses);


    }
}
