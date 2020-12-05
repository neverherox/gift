using gift.Sweetnesses.Interfaces;
using System.Collections.Generic;

namespace gift.Functionality
{
    public class Printer
    {
        public void Print(List<IPrintable> printables)
        {
            foreach(IPrintable printable in printables)
            {
                printable.Print();
            }
        }
    }
}
