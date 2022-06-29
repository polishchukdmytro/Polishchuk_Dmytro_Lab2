using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Coffee arabicaCoffee1 = new ArabicaCoffee(30, Coffee.PhysicalConditions[2], 0.8);
            Coffee arabicaCoffee2 = new ArabicaCoffee(38, Coffee.PhysicalConditions[0], 0.5);
            Coffee robustaCoffee1 = new RobustaCoffee(45, Coffee.PhysicalConditions[1], 1.5);
            Coffee robustaCoffee2 = new RobustaCoffee(50, Coffee.PhysicalConditions[0], 1.75);
            Coffee libericaCoffee1 = new LibericaCoffee(35, Coffee.PhysicalConditions[3], 1);
            Coffee libericaCoffee2 = new LibericaCoffee(42, Coffee.PhysicalConditions[2], 0.6);
            VanOfCoffee van1 = new VanOfCoffee(arabicaCoffee1, arabicaCoffee2, libericaCoffee1, libericaCoffee2, robustaCoffee1, robustaCoffee2);

            Console.WriteLine("__________________________Вагон кави__________________________");
            Console.WriteLine("\nСортування кави за цiною..");
            van1.SortByPrice();
            van1.ShowContent();

            Console.WriteLine("\nСортування кави за вагою..");
            van1.SordByWeight();
            van1.ShowContent();

            Console.WriteLine("\nСортування кави за сортом..");
            van1.SortByGrade();
            van1.ShowContent();

            Console.WriteLine("\nЗнайдено каву за заданими параметрами(вага - 0.75-1кг, цiна - 26-30$):");
            van1.FindAppropriateCoffee(26, 30, 0.75, 1);

            van1.CountCapacityOfCoffeeByCategories(arabicaCoffee1, arabicaCoffee2, libericaCoffee1, libericaCoffee2, robustaCoffee1, robustaCoffee2);

            Console.WriteLine("\nНатиснiть будь-яку клавiшу для закриття консолi...");
            Console.ReadKey();
        }
    }
}
