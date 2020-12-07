using gift.Functionality.Contracts;
using gift.Sweetnesses.Interfaces;
using System.Collections.Generic;

namespace gift.Functionality
{
    public class Printer : IPrinter
    {
        public void Print(IReadOnlyCollection<IPrintable> printables)
        {
            foreach(IPrintable printable in printables)
            {
                printable.Print();
            }
        }
    }
}
