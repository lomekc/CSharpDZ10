// 1 задание
/*
int StartsWithVowels(string[] words)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    int count = 0;

    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i].ToLower()[0] == Char.ToLower(vowels[j])) count++;
        }
    return count;
}

string[] BonJovi = { "It's", "my", "life", "it's", "now", "or", "never", ":(" };

Console.Write("Number of words that start with a vowel: " + StartsWithVowels(BonJovi));
*/
// задание 2

string[] PairwiseUnion(string[] words)
{

    string[] combined = new string[words.Length / 2];

    for (int j = 0, i = 0; i < words.Length; i += 2, j++)
        combined[j] = words[i] + words[i + 1];

    return combined;
}

void ShowString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write($"{words[i]}  ");
    Console.WriteLine();
}

string[] BonJovi2 = { "But", "i", "ain't", "gonna", "live", "forever"};

ShowString((PairwiseUnion(BonJovi2)));
