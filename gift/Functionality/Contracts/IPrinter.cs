using gift.Sweetnesses.Interfaces;
using System.Collections.Generic;

namespace gift.Functionality.Contracts
{
    public interface IPrinter
    {
        void Print(IReadOnlyCollection<IPrintable> printables);
    }
}
