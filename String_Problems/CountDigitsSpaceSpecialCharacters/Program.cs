using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic.FileIO;

namespace CountDigitsSpaceSpecialCharaters;

public class Program
{
    public static void Main(string[] args)
    {
        string name="Nirjala Dattatray N@ik 1706";
        int digits=0;
        int spaces=0;
        int specialChar=0;

        for(int i = 0; i < name.Length; i++)
        {
            char ch=name[i];

            if (char.IsDigit(ch))
            {
                digits++;
            }
            else if (Char.IsWhiteSpace(ch))
            {
                spaces++;
            }
            else if (!char.IsLetter(ch))
            {
                specialChar++;
            }
        }
        Console.WriteLine("Digits: "+digits);
        Console.WriteLine("spaces: "+spaces);
        Console.WriteLine("Special characters:" +specialChar);
    }
}