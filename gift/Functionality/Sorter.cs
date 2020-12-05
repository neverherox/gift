using gift.Sweetnesses;
using System.Collections.Generic;
using System.Linq;


namespace gift.Functionality
{
    public class Sorter
    {
        public List<ISugarable> SortBySugar(List<ISugarable> sugarables)
        {
            return sugarables.OrderBy(x => x.Sugar).ToList();
        }
        public List<IWeightable> SortByWeight(List<IWeightable> weightables)
        {
            return weightables.OrderBy(x => x.Weight).ToList();
        }
        public List<ICaloriable> SortByCalories(List<ICaloriable> caloriables)
        {
            return caloriables.OrderBy(x => x.Calories).ToList();
        }
    }
}
