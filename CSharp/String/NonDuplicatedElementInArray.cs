using System;
using System.Runtime.CompilerServices;

namespace CSharp.String;

public class NonDuplicatedElementInArray
{
    public static void NonDuplicateElement()
    {
        int[] a = { 2, 4, 5, 7, 2, 4, 5 };
        Dictionary<int, int> Count = new Dictionary<int, int>();

        foreach (int item in a)
        {
            if (Count.ContainsKey(item))
            {
                Count.Remove(item);
            }
            else
            {
                Count[item] = 1;
            }
        }
        foreach (var item in Count)
        {
            Console.Write(item.Key + " ");
        }
    }
}
