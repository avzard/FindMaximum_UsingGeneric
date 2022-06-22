using System;

namespace FindMaximumValue_UsingGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Find_MaxValue_UsingGenerics");
            Console.WriteLine("Find_MaxValue Intiger");
            int value = MaximumNumberCheck.MaximumIntegerNumber(10, 12, 13);
            Console.WriteLine(value);
            Console.WriteLine("Find_MaxValue_Float");
            double floatValue = MaximumNumberCheck.MaximumFloatNumber(55.5, 22.2, 33.3);
            Console.WriteLine(floatValue);
            Console.WriteLine("Find_Maximum String");
            string stringValue = MaximumNumberCheck.MaximumString("Apple", "Banana", "Peach");
            Console.WriteLine(stringValue);

        }
    }
}