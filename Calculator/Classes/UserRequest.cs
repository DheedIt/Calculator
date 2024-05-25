using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Calculator.Classes
{
    public interface IUserRequestWithOneElement { }
    public interface IUserRequestWithTwoElements { }
    public class UserRequest : IUserRequestWithOneElement
    {
        public double EnterNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter: ");
            return Convert.ToDouble(Console.ReadLine());
        }


    }
    
}
