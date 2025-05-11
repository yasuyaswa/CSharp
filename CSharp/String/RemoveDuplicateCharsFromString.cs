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
        int l = input.Length;
        char[] CharArr = input.ToCharArray();
        int index = 0;

        for (int i = 0; i < l; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (CharArr[i] == CharArr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                CharArr[index++] = CharArr[i];
            }
        }
        string result = new string(CharArr, 0, index);
        Console.WriteLine(result);
    }
}
