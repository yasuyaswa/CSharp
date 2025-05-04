using System;

namespace C__Practice.String;

public class CountingCharInStringUsingDictionary
{
    public static void CountCharInStringUsingDictionary(string input){
        Dictionary<char, int> CharCount = new Dictionary<char, int>();
        foreach(char c in input){
            if(CharCount.ContainsKey(c)){
                CharCount[c]++;
            }else{
                CharCount[c]=1;
            }
        }
        foreach(var kvp in CharCount){
            Console.Write($"{kvp.Value}{kvp.Key}");
        }
    }
}
