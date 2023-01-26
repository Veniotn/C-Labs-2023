// See https://aka.ms/new-console-template for more information
using System;

//outreference challenge 

namespace outreference
{
    class Program
    {
        public static void Main(string[] args)
        {
            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble);
            test = "Ronan";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test,out  outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble);
        }
        
        //
        // static void Five(out int a)
        // {
        //     a = 5;
        //     Console.WriteLine(a);
        // }

        static bool parseDouble(string toParse, out double result)
        {
            result = 0.0;
            try
            {
                result = Convert.ToDouble(toParse);
                return true;                                        
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}