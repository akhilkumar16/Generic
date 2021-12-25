using System;

namespace FindMaximumNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Find maximum number");
            //    int input = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //    Console.WriteLine(input);
            //    Console.WriteLine("find maximum float number");
            //    double input1 = MaximumNumberCheck.MaximumFloatNumber(22.5, 11.5, 85.5);
            //    Console.WriteLine(input1);
            //    Console.WriteLine(input);
            //    Console.WriteLine("find maximum string number");
            //    string input2 = MaximumNumberCheck.Maximumstring("22", "11", "85");
            //    Console.WriteLine(input2);
            int[] intarray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intarray);
            generic.PrintMaxValue();
            double[] doublearray = { 11.2, 24.5, 55.4, 88.5, 56.4 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doublearray);
            genericDouble.PrintMaxValue();
        }
    }
}
