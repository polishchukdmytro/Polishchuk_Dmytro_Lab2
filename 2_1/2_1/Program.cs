using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            SimpleFraction simpleFraction1 = new SimpleFraction(new Number(3), new Number(4));
            simpleFraction1 = simpleFraction1.Sum(new SimpleFraction(new Number(4), new Number(5)));
            Console.Write(simpleFraction1.Numerator.Value + "/" + simpleFraction1.Denominator.Value + "\n");

            SimpleFraction simpleFraction2 = new SimpleFraction(new Number(6), new Number(7));
            simpleFraction2 = simpleFraction2.Difference(new SimpleFraction(new Number(3), new Number(7)));
            Console.Write(simpleFraction2.Numerator.Value + "/" + simpleFraction2.Denominator.Value + "\n");


            SimpleFraction simpleFraction3 = new SimpleFraction(new Number(3), new Number(9));
            simpleFraction3 = simpleFraction3.Product(new SimpleFraction(new Number(4), new Number(8)));
            Console.Write(simpleFraction3.Numerator.Value + "/" + simpleFraction3.Denominator.Value + "\n");

            SimpleFraction simpleFraction4 = new SimpleFraction(new Number(2), new Number(3));
            simpleFraction4 = simpleFraction4.Division(new SimpleFraction(new Number(5), new Number(4)));
            Console.Write(simpleFraction4.Numerator.Value + "/" + simpleFraction4.Denominator.Value + "\n");

            Console.WriteLine("\nPress \"enter\" to close the window...");
            Console.ReadKey();
        }
    }
}
