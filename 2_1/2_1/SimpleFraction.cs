using System;

namespace Task1
{
    class SimpleFraction
    {
        public Number Numerator { get; set; }
        public Number Denominator { get; set; }
        public Sign Operand { get; set; }
        public SimpleFraction(Number value1, Number value2)
        {
            this.Numerator = value1;
            this.Denominator = value2;
        }
        public SimpleFraction Sum(SimpleFraction simpleFraction2)
        {
            Operand = new Sign('+');
            Console.Write($"{Numerator.Value}/{Denominator.Value} {Operand.Operation} {simpleFraction2.Numerator.Value}/{simpleFraction2.Denominator.Value} = ");
            if (Denominator.Value == simpleFraction2.Denominator.Value)
                return new SimpleFraction(new Number(Numerator.Value + simpleFraction2.Numerator.Value),
                    new Number(Denominator.Value));
            else
                return new SimpleFraction(new Number(Numerator.Value * simpleFraction2.Numerator.Value
                    + Denominator.Value * simpleFraction2.Denominator.Value), new Number(Denominator.Value * simpleFraction2.Denominator.Value));
        }
        public SimpleFraction Difference(SimpleFraction simpleFraction2)
        {
            Operand = new Sign('-');
            Console.Write($"\n{Numerator.Value}/{Denominator.Value} {Operand.Operation} {simpleFraction2.Numerator.Value}/{simpleFraction2.Denominator.Value} = ");
            if (Denominator.Value == simpleFraction2.Denominator.Value)
                return new SimpleFraction(new Number(Numerator.Value - simpleFraction2.Numerator.Value),
                    new Number(Denominator.Value));
            else
                return new SimpleFraction(new Number(Numerator.Value * simpleFraction2.Numerator.Value
                    - Denominator.Value * simpleFraction2.Denominator.Value), new Number(Denominator.Value * simpleFraction2.Denominator.Value));
        }
        public SimpleFraction Product(SimpleFraction simpleFraction2)
        {
            Operand = new Sign('*');
            Console.Write($"\n{Numerator.Value}/{Denominator.Value} {Operand.Operation} {simpleFraction2.Numerator.Value}/{simpleFraction2.Denominator.Value} = ");
            return new SimpleFraction(new Number(Numerator.Value * simpleFraction2.Numerator.Value),
                new Number(Denominator.Value * simpleFraction2.Denominator.Value));
        }
        public SimpleFraction Division(SimpleFraction simpleFraction2)
        {
            Operand = new Sign('/');
            Console.Write($"\n{Numerator.Value}/{Denominator.Value} {Operand.Operation} {simpleFraction2.Numerator.Value}/{simpleFraction2.Denominator.Value} = ");
            return new SimpleFraction(new Number(Numerator.Value * simpleFraction2.Denominator.Value),
                new Number(Denominator.Value * simpleFraction2.Numerator.Value));
        }
    }
}
