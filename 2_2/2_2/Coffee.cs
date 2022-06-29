using System;

namespace Task2
{
    abstract class Coffee
    {
        public abstract void ShowInfoAboutGood();
        public double PricePerKilo { get; set; }
        public double PricePerPackage { get; set; }
        public double FullPrice
        {
            get { return PricePerKilo * Weight + PricePerPackage; }
        }
        public double Weight { get; set; }
        static public string[] PhysicalConditions = { "мелена", "в зернах", "в пакетиках", "в банках" };
        public string PhysicalCondition { get; set; }
    }
}
