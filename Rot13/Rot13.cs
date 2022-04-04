public class Kata
{
    public static int[] formatInputToIntArr(string message)
    {
        char[] ascii = message.ToCharArray();
        int[] asciiInt = new int[ascii.Length];
        int i = 0;
        foreach (char c in ascii)
        {
            asciiInt[i++] = (int)c;
        }

        return asciiInt;
    }

    public static string formatToString(int[] message)
    {
        char[] characters = new char[message.Length];
        int i = 0;
        foreach (int c in message)
        {
            characters[i++] = (char)c;
        }

        return new string(characters);
    }

    public static string Rot13(string message)
    {
        int[] asciiInt = formatInputToIntArr(message);

        int[] encrypted = new int[asciiInt.Length];

        for (int i = 0; i < encrypted.Length; i++)
        {
            int x = asciiInt[i];
            if ((x >= 65 && x <= 77) || (x >= 97 && x <= 109))
            {
                encrypted[i] = x + 13;
            }
            else if ((x >= 78 && x <= 90) || (x >= 110 && x <= 122))
            {
                encrypted[i] = x - 13;
            }
            else
            {
                encrypted[i] = x;
            }
        }
        return formatToString(encrypted);
    }
}