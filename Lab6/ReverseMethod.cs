using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    public class ReverseMethod
    {
        public void NumRevers()
        {
            int num = 1234;
            Console.WriteLine(num.ToString().Reverse().ToArray());
        }
        public void NumRevers(int num)
        {
            Console.WriteLine(num.ToString().Reverse().ToArray());
        }

        public string ReverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public void ReverseString()
        {
            string word = "ASDF";
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray)); 
        }
        public double ReverseNumber(double number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }
        public void ReverseNumber()
        {
            double number = 123.456;
            Console.WriteLine(double.Parse(ReverseString(number.ToString()))); 
        }
        public void ReverseWord()
        {
            string startWord = "Hello my frined, how are you?";
            Console.WriteLine(startWord);
            string secondWord = "Hello my frined, how are you?";
            //s = Console.ReadLine();
            char[] sReverse = secondWord.ToCharArray();
            Array.Reverse(sReverse);
            secondWord = new string(sReverse);
            Console.WriteLine(secondWord);
        }
        public void ReverseWord(string secondWord)
        {
            string startWord = "Hello my frined, how are you?";
            Console.WriteLine(startWord);
            //s = Console.ReadLine();
            char[] sReverse = secondWord.ToCharArray();
            Array.Reverse(sReverse);
            secondWord = new string(sReverse);
            Console.WriteLine(secondWord);
        }
        public void DontReverse()
        {
            string text = "Hello Danya!";
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
        }
        public string DontReverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        public void DontReverse(ref string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
        }
        public void DontReverse(string test, out string texts)
        {
            texts = null;
            char[] cArray = texts.ToCharArray(); // ecxeption to array...
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse); 
        }
    }
}
