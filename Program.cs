using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
       
        Auto[] cars = new Auto[5];
        cars[0] = new Auto("Mersedes", 2004, 7000000, false); 
        cars[1] = new Auto("Porshe", 2022, 30000000, true); 
        cars[2] = new Auto("Toyota", 2021, 35000000); 
        cars[3] = new Auto(); 
        cars[4] = new Auto("Supra", 2023, 95000000);
        //разные значения
        
        foreach (Auto car in cars)
        {
            car.DisplayCarInfo();
            Console.WriteLine();
        }

        
        Console.WriteLine($"Общее количество автомобилей: {Auto.GetNumberOfCars()}");
        Console.WriteLine($"Тип автомобиля: {Auto.GetCarType()}");
    }
}

