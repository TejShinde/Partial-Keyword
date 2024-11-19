using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class Calc
    {
        public int Multiply(int a, int b)
        {
            Divide(a, b);
            return a * b;
//            Multiply calls Divide(5, 8).
//Divide(5, 8) performs integer division and prints 0 because 5 / 8 results in 0.
//Multiply then returns 5 * 8, which is 40, printed as Multiplication: 40.
        }
        public void Invoke(int a, int b)
        {
            Divide(a, b);
        }
        partial void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }

}
