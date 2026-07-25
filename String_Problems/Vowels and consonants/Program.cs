namespace VowelsandConsonants;

public class Program
{
    public static void Main(string[] args)
    {
        string name = "Nirjala";
        int vowels = 0;
        int consonants = 0;
        foreach (char ch in name)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("consonants: " + consonants);
    }
}