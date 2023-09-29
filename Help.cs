using System;

public partial class Auto
{
    
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Марка: {make}");
        Console.WriteLine($"Год выпуска: {year}");
        Console.WriteLine($"Стоимость: {price:C} Тенге");
        Console.WriteLine($"Доступность: {(isAvailable ? "Доступен" : "Недоступен")}");
    }
}
