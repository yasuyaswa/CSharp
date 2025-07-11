using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace C__Practice.Integer
{
    public class RemoveDuplicatesInArray
    {
        public static void RemoveDuplicates(){
            int[] a= {6,3,7,2,9,6,2,7,4,8};
            int[] SortArr = a.Distinct().OrderBy(o=>o).ToArray();
            int[] UniqueArr = a.Distinct().OrderBy(o=>o).ToArray();
            foreach(int item in UniqueArr){
                Console.Write(item+" ");
            }
            // string result = string.Join(",", SortArr);
            // Console.WriteLine(result);
        }
    }
}
