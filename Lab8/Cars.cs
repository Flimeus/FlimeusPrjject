using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public class Cars
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public short Speed { get; set; }
        public string YearProdaction { get;set; }
        public override string ToString()
        {
            return $"Name:{ Name}, Color:{Color}, Speed:{Speed}, YearOfProduction:{YearProdaction}";
        }
    }
}
