using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndependedWork
{
    public class CarSelection
    {
        List<Cars> cars = new List<Cars>();
        public CarSelection()
        {
            cars = new List<Cars>
            {
                new Cars(){CollectionColors= "Black",YearProduction = "2000", Cost = 201205, Speed = 200},
                new Cars(){CollectionColors= "White",YearProduction = "2020", Cost = 1000000, Speed = 190},
                new Cars(){CollectionColors= "Red",YearProduction = "2019", Cost = 1500000, Speed = 215}
            };    
        }
        public void ChooseCar()
        {
            while (true)
            {
                Console.WriteLine("Enter year of ptoduction car, which you want to choose:");
                var temp = Console.ReadLine();
                var car = cars.FirstOrDefault(d => d.YearProduction == temp);
                if (car == null) Console.WriteLine("Error");
                else
                    Console.WriteLine($"Color: {car.CollectionColors} Cost: {car.Cost}");
            }
        }
    }
}
