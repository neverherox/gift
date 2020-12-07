using gift.Sweetnesses;
using System.Collections.Generic;

namespace gift.Functionality.Contracts
{
    public interface ICalculator
    {
        double CalculateWeight(IReadOnlyCollection<IWeightable> weightables);
    }
}
