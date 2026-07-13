namespace ReverseWordsSentence;

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "Hello dear";
        
        string[] word = sentence.Split(' ');

        for (int i = 0; i < word.Length; i++)
        {
            string revSentence = "";
            for (int j = word[i].Length - 1; j >= 0; j--)
            {
                revSentence+=word[i][j];
            }
            word[i]=revSentence;
        }
        // Console.WriteLine("reverse a word in a sentence: "+revSentence);
        Console.WriteLine(string.Join(' ',word));
    }
}