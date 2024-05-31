namespace Calculator.Classes
{
    public struct NStandartArgs(double[] num)
    {
        public required double[] NumberArr { get; set; } = num;
    }
}