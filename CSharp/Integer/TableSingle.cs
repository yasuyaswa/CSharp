using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__Practice.Integer
{
    public class TableSingle
    {
        public static void SingleTable(int n){
            for(int i=1; i<=10; i++){
                Console.WriteLine(($"{n}x{i}="+n*i));
            }
        }
    }
}