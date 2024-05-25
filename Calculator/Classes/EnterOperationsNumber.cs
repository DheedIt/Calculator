using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class EnterOperationsNumber : IEnterOperationsNumber
    {
        public int Get()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
