Console.WriteLine("Enter a word to convert to Pig Latin: ");

string word = Console.ReadLine();

string vowels = "aeiou";

string pigLatin = "";

if (vowels.Contains(word[0]))
{
    pigLatin = word + "way";
}
else
{
    int vowelIndex = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (vowels.Contains(word[i]))
        {
            vowelIndex = i;
            break;
        }
    }
    pigLatin = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
}
Console.WriteLine(pigLatin);