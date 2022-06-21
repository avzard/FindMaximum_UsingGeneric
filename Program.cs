using System;

namespace FindMaximumValue_UsingGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Find_MaxValue_UsingGenerics");
            Console.WriteLine("Find_MaxValue Intiger");
            int value = MaximumNumberCheck.findMaximum(10, 12, 13);
            Console.WriteLine(value);
            Console.WriteLine("Find_MaxValue_Float");
            double floatValue = MaximumNumberCheck.findMaximum(55.5, 22.2, 33.3);
            Console.WriteLine(floatValue);
            Console.WriteLine("Find_Maximum String");
            string stringValue = MaximumNumberCheck.findMaximum("Apple", "Banana", "Peach");
            Console.WriteLine(stringValue);
            Console.WriteLine("\nFind_Maximum ");
            int[] arr = { 12, 45, 41, 22, 66, 77 };
            GenricMaximum<int> generic = new GenricMaximum<int>(arr);
            generic.PrintMAxValue();

        }
    }
}