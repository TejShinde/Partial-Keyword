using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnumNamespace.EmpEnum;

namespace EnumNamespace
{
    public class EnumMain
    {
        static void Main(string[] args)
        {
            EmpEnum e1 = new EmpEnum(101, "Suraj", Department.Sales, Roles.Manager);
            Console.WriteLine(e1);

        }

    }
}
