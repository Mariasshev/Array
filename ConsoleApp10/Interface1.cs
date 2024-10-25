using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal interface iCalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);

    }

    interface iOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    interface iCalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
