using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumberProject
{
    class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstvalue, int secoundvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secoundvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (firstvalue.CompareTo(secoundvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return secoundvalue;
            }
            if (firstvalue.CompareTo(secoundvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception(" firstnumber, secoundnumber, thirdnumber are same");
        }
        public static double MaximumFloatNumber(double firstvalue, double secoundvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secoundvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (firstvalue.CompareTo(secoundvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return secoundvalue;
            }
            if (firstvalue.CompareTo(secoundvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception(" firstnumber,secoundnumber,thirdnumber are same");
        }
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