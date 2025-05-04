using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace C__Practice.Integer
{
    public class AgeCal
    {
        public static void Age(DateOnly BirthDate){
            DateTime dt= DateTime.Today;
            int age= dt.Year-BirthDate.Year;
            Console.WriteLine(age);
        }
    }
}