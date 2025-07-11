using System.Globalization;

public class RemoveDuplicateCharsFromString
{
    public static void RemoveDuplicate(string input)
    {
        //the method should not be used as it will create a new instance for a string
        // string result = string.Empty;
        // for(int i=0; i<input.Length; i++){
        //     if(!result.Contains(input[i])){
        //         result+=input[i];// result=result+input[i]
        //     }
        // }
        // Console.WriteLine(result);
        //Second method
        // int l = input.Length;
        // char[] CharArr = input.ToCharArray();
        // int index = 0;

        // for (int i = 0; i < l; i++)
        // {
        //     bool isDuplicate = false;
        //     for (int j = 0; j < i; j++)
        //     {
        //         if (CharArr[i] == CharArr[j])
        //         {
        //             isDuplicate = true;
        //             break;
        //         }
        //     }
        //     if (!isDuplicate)
        //     {
        //         CharArr[index++] = CharArr[i];
        //     }
        // }
        // string result = new string(CharArr, 0, index);
        // Console.WriteLine(result);

        Dictionary<char, int> CharCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (CharCount.ContainsKey(c))
            {
                CharCount[c]++;
            }
            else
            {
                CharCount[c] = 1;
            }
        }
        foreach (var item in CharCount)
        {
            Console.Write(item.Key + " ");
        }

        //Second method using Linq
        // string UniqueStr = new String(input.Distinct().OrderBy(o=>o).ToArray());
        // Console.WriteLine(UniqueStr);
    }
}
