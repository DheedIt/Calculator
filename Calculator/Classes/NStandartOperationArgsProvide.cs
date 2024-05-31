namespace Calculator.Classes
{

    public sealed class NStandartOperationArgsProvider : IOperationArgsProvider<NStandartArgs>
    {
        public NStandartArgs Get()
        {
            double[] arr = new double[0];
            string nums = "";
            int i = 0;
            while (true)
            {
                Console.Write($"Введите {i+1}-е число: ");
                arr.Append(Convert.ToDouble(Console.ReadLine()));
                if (nums[i] == ' ')
                {
                    break;
                }
                ++i;
            }

            return new()
            {
                NumberArr = arr
            };
        }
    }
}