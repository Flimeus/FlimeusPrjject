using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab8
{
    public class Garage
    {
        List<Cars> cars = new List<Cars>()
        {
            new Cars(){Name = "tax", Color="white", Speed= 220, YearProdaction="2015 " },
            new Cars(){Name = "lamba", Color="yellow", Speed= 180, YearProdaction="2004 " },
            new Cars(){Name = "porshe", Color="white", Speed= 220, YearProdaction="2015 " },
        };

        public void RemoveCar()
        {
            foreach (var item in cars)
            {
                Console.WriteLine("Введите название машины? котороую хотите удалить:");
                var temp = Console.ReadLine();
                if (temp == item.Name)
                {
                    cars.Remove(item);
                }
                else Console.WriteLine("Не удалсь найти машину с таким названием!");
            }

        }
        public void Req(string Name, string Color, short Speed, string YearProdction)
        {
            var car = cars.Where(d => d.Name == Name && d.Color==Color && d.Speed==Speed && d.YearProdaction==YearProdction ).ToList();
            
        }
        public void ChoiceCarToName()
        {
            while (true)
            {
                Console.WriteLine("Название машины:");
                var temp = Console.ReadLine();
                var car = cars.FirstOrDefault(d => d.Name == temp);
                if (car == null) Console.WriteLine("Error");
                else
                    Console.WriteLine($"Name:{car.Name}\tColor:{car.Color}\tCost: {car.Speed}");
            }
        }
        public void ChoiceCarToSpeed()
        {
            while (true)
            {
                Console.WriteLine("Скорость машины:");
                var temp = Console.ReadLine();
                var car = cars.FirstOrDefault(d => d.Speed == Convert.ToInt32(temp));
                if (car == null) Console.WriteLine("Error");
                else
                    Console.WriteLine($"Name:{car.Name}\tColor:{car.Color}\tCost:{car.Speed}");
            }
        }
        public void ChoiceCarToYearProduction()
        {
            foreach (var item in cars)
            {
                Console.WriteLine("Год выпуска машины:");
                var temp = Console.ReadLine();
                if (temp == item.YearProdaction)
                {
                    Console.WriteLine($"Name:{item.Name}\tColor:{ item.Color}\tSpeed:{ item.Speed}\tYearProduction:{ item.YearProdaction}");
                }
                else Console.WriteLine("У вас нету такой машины!");
            }
        }
    }
}
