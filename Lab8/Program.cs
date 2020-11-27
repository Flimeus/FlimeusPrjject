using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Garage garage = new Garage();
            int value = default;
            while (true)
            {
                Console.WriteLine("1)Выбрать машину за именем\t2)Выбрать машину за скоростью" +
                    " \t3)Выбрать машину за годом выпуска\t" +
                    "4)Удалить машину%");
                int.TryParse(Console.ReadLine(), out value);
                switch (value)
                {
                    case 1: garage.ChoiceCarToName();
                        break;
                    case 2: garage.ChoiceCarToSpeed();
                        break;
                    case 3: garage.ChoiceCarToYearProduction();
                        break;
                    case 4: garage.RemoveCar();
                        break;
                    default:Console.WriteLine("Выбран не верный пункт!"); 
                        break;
                }
            }  
        }
    }
}
