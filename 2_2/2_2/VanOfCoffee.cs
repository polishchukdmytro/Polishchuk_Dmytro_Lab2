using System;

namespace Task2
{
    class VanOfCoffee
    {
        Coffee[] coffee;
        public VanOfCoffee(params Coffee[] coffee)
        {
            this.coffee = coffee;
        }
        public void SortByGrade()
        {
            Coffee[] newCoffee = new Coffee[coffee.Length];
            int index = 0;
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is LibericaCoffee)
                {
                    newCoffee[index] = coffee[i];
                    index++;
                }
            }
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is ArabicaCoffee)
                {
                    newCoffee[index] = coffee[i];
                    index++;
                }
            }
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is RobustaCoffee)
                {
                    newCoffee[index] = coffee[i];
                    index++;
                }
            }
            coffee = newCoffee;
        }
        public void SordByWeight()
        {
            for (int i = 0; i < coffee.Length - 1; i++)
            {
                for (int j = 0; j < coffee.Length - 1; j++)
                {
                    if (coffee[j].Weight > coffee[j + 1].Weight)
                    {
                        Coffee temp = coffee[j];
                        coffee[j] = coffee[j + 1];
                        coffee[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByPrice()
        {

            for (int i = 0; i < coffee.Length - 1; i++)
            {
                for (int j = 0; j < coffee.Length - 1; j++)
                {
                    if ((coffee[j].PricePerKilo + coffee[j].PricePerPackage) > (coffee[j + 1].PricePerKilo + coffee[j].PricePerPackage))
                    {
                        Coffee temp = coffee[j];
                        coffee[j] = coffee[j + 1];
                        coffee[j + 1] = temp;
                    }
                }
            }
        }
        public void ShowContent()
        {
            for (int i = 0; i < coffee.Length; i++)
                coffee[i].ShowInfoAboutGood();
        }
        public void FindAppropriateCoffee(double StartPrice, double FinalPrice, double StartWeight, double FinalWeight)
        {
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i].PricePerKilo >= StartPrice && coffee[i].PricePerKilo <= FinalPrice &&
                    coffee[i].Weight >= StartWeight && coffee[i].Weight <= FinalPrice)
                {
                    coffee[i].ShowInfoAboutGood();
                }
            }
        }
        public void CountCapacityOfCoffeeByCategories(params Coffee[] coffee)
        {
            double capacityOfLiberica = 0, capacityOfArabica = 0, capacityOfRobusta = 0;
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is LibericaCoffee)
                    capacityOfLiberica += coffee[i].Weight;
            }
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is ArabicaCoffee)
                    capacityOfArabica += coffee[i].Weight;
            }
            for (int i = 0; i < coffee.Length; i++)
            {
                if (coffee[i] is RobustaCoffee)
                    capacityOfRobusta += coffee[i].Weight;
            }
            Console.WriteLine($"\nOбсяг кави лiберiка - {capacityOfLiberica}кг");
            Console.WriteLine($"Обсяг кави робуста - {capacityOfRobusta}кг");
            Console.WriteLine($"Обсяг кави арабiка - {capacityOfArabica}кг");
        }
    }
}
