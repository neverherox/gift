using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;
namespace gift.Functionality
{
    public class WeightCalculator
    {
        public double CalculateWeight(List<IWeightable> weightables)
        {
            return weightables.Sum(x => x.Weight);
        }
    }
}
