using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    class maxstring
    {
     public static string Maximumstring(string firststring, string Secoundstring, string Thirdstring)
    {
        if (firststring.CompareTo(Secoundstring) > 0 && firststring.CompareTo(Thirdstring) > 0 ||
           firststring.CompareTo(Secoundstring) >= 0 && firststring.CompareTo(Thirdstring) > 0 ||
           firststring.CompareTo(Secoundstring) > 0 && firststring.CompareTo(Thirdstring) > 0)
        {
            return firststring;
        }
        if (Secoundstring.CompareTo(firststring) > 0 && Secoundstring.CompareTo(Thirdstring) > 0 ||
           Secoundstring.CompareTo(firststring) >= 0 && Secoundstring.CompareTo(Thirdstring) > 0 ||
           Secoundstring.CompareTo(firststring) > 0 && Secoundstring.CompareTo(Thirdstring) > 0)
        {
            return Secoundstring;
        }
        if (Thirdstring.CompareTo(firststring) > 0 && Thirdstring.CompareTo(Secoundstring) > 0 ||
           Thirdstring.CompareTo(firststring) >= 0 && Thirdstring.CompareTo(Secoundstring) > 0 ||
           Thirdstring.CompareTo(firststring) > 0 && Thirdstring.CompareTo(Secoundstring) > 0)
        {
            return Thirdstring;
        }
        return firststring;
    }
}
}
