using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    public static class ArrExtension
    {
        public static int[] ChangeValue(this int[] mas)
        {
            var maxValue = mas.Max();
            var minValue = mas.Min();
            int maxIndex = Array.IndexOf(mas, maxValue);
            int minIndex = Array.IndexOf(mas, minValue);
            mas[maxIndex] = minValue;
            mas[minIndex] = maxValue;
            return mas;
        }
    }
}
