using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists lists = new Lists();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter string value: ");
                lists.AddValue(Console.ReadLine());
            }
            lists.GetsignificanceInList(2);
        }
    }
    public class Lists
    {
        private List<string> significance;
        public Lists()
        {
            significance = new List<string>();
        }
        public void GetsignificanceInList(int len)
        {
            foreach (var item in significance)
            {
                if (item.Length == len)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public List<string> Values => significance; // паблик свойство 
        public void AddValue(string value)
        {
            significance.Add(value);
        }
    }
}
