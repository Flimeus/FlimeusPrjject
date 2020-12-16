using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseMethod reverse = new ReverseMethod();
            reverse.NumRevers();
            reverse.NumRevers(1234);
            Console.WriteLine(ReverseString());
            reverse.ReverseString();
            Console.WriteLine(reverse.ReverseNumber(123.456)); 
            reverse.ReverseNumber();
             reverse.ReverseWord();
             reverse.ReverseWord("Hello my frined, how are you?");
            Console.WriteLine(reverse.DontReverse("Test text")); 
            reverse.DontReverse();
            string text = "Hello Danya!";
             reverse.DontReverse(ref text); 
            string test = "Test";
            reverse.DontReverse(test, out string texts);

        }
        static string ReverseString()
        {
            string word = "ABCD";
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

    }
}
