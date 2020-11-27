using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    public class ButtonPhone:BasePhone
    {
        public ButtonPhone()
        {
            GetNumbers.AddRange(new List<string>
            {
                "Enter",
                "Cancel",
                "*",
                "#"
            });
        }
        public  void Numberto()
        {
            Console.WriteLine("Enter");
        }
        public void Numberto2()
        {
            Console.WriteLine("Cancel");
        }
        public void Numberto3()
        {
            Console.WriteLine("*");
        }
        public void Numberto4()
        {
            Console.WriteLine("#");
        }
        public void ToCall()
        {
            var temp = Console.ReadLine();
            int value = default;
            Console.WriteLine("1)Тык на #\t2Тык на *" +
                    " \t3)Тык на Cance\t4)Тык на Enter");
            while (true)
            {
                switch (value)
                {
                    case 1: Numberto4();
                        break;
                    case 2: Numberto3();
                        break;
                    case 3: Numberto2();
                        break;
                    case 4: Numberto();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
