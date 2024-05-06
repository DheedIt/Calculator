using System;
namespace Calculator.Classes
{
    public abstract class Operation<T>
    {
        public abstract string Name { get; }
        abstract public T Calculate(T[] args);
        public T result;
    }
    class AdditionOperation : Operation<double>
    {
        public override string Name => "Сложение (+)";
        public override double Calculate(double[] args)
        {
            result = 0;
            for (int i = 0; i < args.Length; ++i)
                result += args[i];
            return result;
        }
    }
    class SubstractionOperation : Operation<double>
    {
        public override string Name => "Вычитание (-)";
        public override double Calculate(double[] args)
        {
            result = args[0];
            for (int i = 1; i < args.Length; ++i)
                result = result - args[i];
            return result;
        }
    }
    class MultiplicationOperation : Operation<double>
    {
        public override string Name => "Умножение (*)";
        public override double Calculate(double[] args)
        {
            result = 1;
            for (int i = 0; i < args.Length; ++i)
                result *= args[i];
            return result;
        }
    }
    class DivisionOperation : Operation<double>
    {
        public override string Name => "Деление (/)";
        public override double Calculate(double[] args)
        {
            result = args[0];
            for (int i = 1; i < args.Length; ++i)
                if (args[i] == 0)
                {
                    Console.WriteLine("Division by zero\n");
                    break;
                }
                else
                    result /= args[i];
            return result;
        }
    }
    class FactorialOperation : Operation<double>
    {
        public override string Name => "Факториал (!)";
        public override double Calculate(double[] args)
        {
            result = 1;
            for (int i = 1; i <= args[0]; ++i)
                result *= i;
            return result;
        }
    }
    class ModulOperation : Operation<double>
    {
        public override string Name => "Модуль (|x|)";
        public override double Calculate(double[] args)
        {
            result = args[0];
            if (result < 0)
                return result * -1;
            else return result;
        }
    }
    class LogarithmOperation : Operation<double>
    {
        public override string Name => "Логарифм с основанием a (loga x)";
        public override double Calculate(double[] args)
        {
            result = Math.Log(args[0], args[1]);
            return result;
        }
    }
    class TenToNOperation : Operation<double>
    {
        public override string Name => "10 в n степени (10^n)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(10, args[0]);
            return result;
        }
    }
    class NToNOperation : Operation<double>
    {
        public override string Name => "f в n степени (f^n)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(args[0], args[1]);
            return result;
        }
    }
    class SqrtOperation : Operation<double>
    {
        public override string Name => "Корень числа (√n)";
        public override double Calculate(double[] args)
        {
            result = Math.Sqrt(args[0]);
            return result;
        }
    }
    class TwoToNOperation : Operation<double>
    {
        public override string Name => "Квадрат числа (n ^ 2)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(2, args[0]);
            return result;
        }
    }
    class OneDivsionOperation : Operation<double>
    {
        public override string Name => "n в -1 степени (1/n)";
        public override double Calculate(double[] args)
        {
            result = 1 / args[0];
            return result;
        }
    }
    class DivisionWithRemainderOperation : Operation<double>
    {
        public override string Name => "Деление с остатком (%)";
        public override double Calculate(double[] args)
        {
            result = args[0];
            for (int i = 1; i < args.Length; ++i)
                if (args[i] == 0)
                    throw new Exception("Division by zero\n");
                else
                    result %= args[i];
            return result;
        }
    }
    class ExpoOperation : Operation<double>
    {
        public override string Name => "e в n степени (e^n)";
        public override double Calculate(double[] args)
        {
            result = Math.Exp(args[0]);
            return result;
        }
    }
    class NToTwoOperation : Operation<double>
    {
        public override string Name => "2 в n степени (2 ^ n)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(2, args[0]);
            return result;
        }
    }
    class ThirdSqrtOperation : Operation<double>
    {
        public override string Name => "Квадратный корень из n (∛n)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(args[0], 1 / 3);
            return result;
        }
    }
    class NToThreeOperation : Operation<double>
    {
        public override string Name => "Куб числа (n ^ 3)";
        public override double Calculate(double[] args)
        {
            result = Math.Pow(args[0], 3);
            return result;
        }
    }
}