using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    public class СolorScreenPhone: BlackWhitePhone
    {
        public int CountOfColors { get; set; }
        public bool SupportDualSim { get; set; }
        public string Text { get; set; }
        public string SecondNumber { get; set; }
        public string Number { get; set; }
        public void TypeMessage()
        {
            string text = Console.ReadLine();
            text = Text;
            Console.WriteLine(Text);
        }
        public void TypeNumber()
        {
            var temp = Console.ReadLine();
            temp = Number;
        }
        public void SenMes(string Number, string Text )
        {
            Console.WriteLine("Message a send!");
        } 
    }
}
