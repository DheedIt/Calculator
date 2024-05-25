using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Calculator.Classes
{
    public interface IUserRequest { }

    public class UserRequest 
    {
        public double EnterNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter: ");
            return Convert.ToDouble(Console.ReadLine());
        }


    }
}
