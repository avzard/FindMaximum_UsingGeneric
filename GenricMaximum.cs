using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumValue_UsingGeneric
{
    public class GenricMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenricMaximum(T[] value)
        {
            this.value = value;
        }
        public static T testMaximum(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue are same");
        }

        // Sorts the specified values.
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        // Maximums the value.
        public T MaxValue(T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[^1];
        }
        // Maximum method.
        public T MaxMethod()
        {
            var Max = MaxValue(this.value);
            return Max;
        }

        // Printing the max value.
        public void PrintMAxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("MAximum value is : " + max);
        }
    }
}