using gift.Functionality.Contracts;
using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;
namespace gift.Functionality
{
    public class Calculator : ICalculator
    {
        public double CalculateWeight(IReadOnlyCollection<IWeightable> weightables)
        {
            return weightables.Sum(x => x.Weight);
        }
    }
}
