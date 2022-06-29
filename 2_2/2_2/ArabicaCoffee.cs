using System;

namespace Task2
{
    class ArabicaCoffee : Coffee
    {
        public ArabicaCoffee(double pricePerKilo, string physicalCondition, double weight)
        {
            this.PhysicalCondition = physicalCondition;
            this.PricePerKilo = pricePerKilo;
            this.Weight = weight;
            if (physicalCondition == PhysicalConditions[0])
                PricePerPackage = 1;
            else if (physicalCondition == PhysicalConditions[1])
                PricePerPackage = 1.5;
            else if (physicalCondition == PhysicalConditions[2])
                PricePerPackage = 2.5;
            else if (physicalCondition == PhysicalConditions[3])
                PricePerPackage = 4;
        }
        public override void ShowInfoAboutGood()
        {
            Console.WriteLine($"Кава арабiка {PhysicalCondition}, цiна за кiло - {PricePerKilo}$, цiна з упаковкою - {FullPrice}$, вага - {Weight}кг");
        }
    }
}
