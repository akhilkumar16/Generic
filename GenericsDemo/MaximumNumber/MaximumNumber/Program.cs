using System;

namespace MaximumNumber
{

    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("find max number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);

            Console.WriteLine("find float max number");
            double output1 = uc2_floatmaxi.MaximumFloatNumber(12.5, 2.5, 5.5);
            Console.WriteLine(output1);

            Console.WriteLine(" find max string");
            string output2 = maxstring.Maximumstring( "22", "55","54");
            Console.WriteLine(output2);
        }
    }
}