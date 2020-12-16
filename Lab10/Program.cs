using System;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new[] { 2, 3, 4, 5, 6, 10, 3, 2, 4, 5, 6, 222222, -1 };
            var newArray = mas.ChangeValue();
        }
    }
}
