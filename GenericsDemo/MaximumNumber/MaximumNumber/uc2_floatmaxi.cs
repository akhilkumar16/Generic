using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    class uc2_floatmaxi
    {
        public static double MaximumFloatNumber( double firstValue,double SecoundValue, double ThirdValue)
        {
            if (firstValue.CompareTo(SecoundValue) > 0 && firstValue.CompareTo(ThirdValue) > 0 ||
               firstValue.CompareTo(SecoundValue) >= 0 && firstValue.CompareTo(ThirdValue) > 0 ||
               firstValue.CompareTo(SecoundValue) > 0 && firstValue.CompareTo(ThirdValue) > 0)
            {
                return firstValue;
            }
            if (SecoundValue.CompareTo(firstValue) > 0 && SecoundValue.CompareTo(ThirdValue) > 0 ||
               SecoundValue.CompareTo(firstValue) >= 0 && SecoundValue.CompareTo(ThirdValue) > 0 ||
               SecoundValue.CompareTo(firstValue) > 0 && SecoundValue.CompareTo(ThirdValue) > 0)
            {
                return SecoundValue;
            }
            if (ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecoundValue) > 0 ||
               ThirdValue.CompareTo(firstValue) >= 0 && ThirdValue.CompareTo(SecoundValue) > 0 ||
               ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecoundValue) > 0)
            {
                return ThirdValue;
            }
            return firstValue;
        }
    }
}
