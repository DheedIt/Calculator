using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator.Classes
{
    public interface IReturnOperationConvertor
    {
        public int Setter();
    }
    public class ReturnOperationConvertor
    {
        public int Setter()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
