using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Calculator.Classes
{
    class URequest
    {
        public double[] EnterN()
        {
            Console.Clear();
            Console.WriteLine("Enter: ");
            string[] strArr = Console.ReadLine().Split(' ');
            double[] numArr = new double[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                if (Regex.IsMatch(strArr[i], @"[+-]?([0-9]*[,])?[0-9]+"))
                {
                    numArr[i] = double.Parse(strArr[i]);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            return numArr;
        }
        public bool contueCheck()
        {
            Console.WriteLine("Continue? Y/N");
            string answer = Console.ReadLine();
            Console.Clear();
            if (answer != "")
            {
                if (answer[0] == 'y' ||
                    answer[0] == 'Y')
                {
                    return true;
                }
            }
            return false;

        }
    }
}
