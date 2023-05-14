namespace NeetCode.Blind75.ArraysAndHashing;

// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
public class ValidAnagram
{
    public static void HardWay(string s, string t)
    {
        if (t.Length != s.Length)
            Console.WriteLine($"{t} não é um anagrama");

        else
        {
            var sList = s.ToList();
            List<Detail> data = new List<Detail>();

            for (int i = 0; i < s.Length; i++)
            {
                if (data.Find(x => x.Letter == s[i]) is null)
                {
                    var letter = s[i];
                    int count = sList.FindAll(x => x.Equals(s[i])).Count;
                    Detail detail = new Detail(letter, count);
                    data.Add(detail);

                    if (t.ToList().FindAll(x => x.Equals(letter)).Count != count)
                    {
                        Console.WriteLine($"{t} não é um anagrama");
                        break;
                    }
                }
            }
        }
    }

    public static bool EasyWay(string s, string t)
    {
        if (t.Length != s.Length)
            return false;

        else
        {
            Dictionary<char, int> values = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                char letter = s[i];

                if (t.Contains(letter) == false)
                    return false;

                if (values.ContainsKey(letter) == false)
                    values.Add(letter, 1);

                else
                {
                    values.TryGetValue(letter, out int count);
                    count++;
                    values[letter] = count;
                }
            }
            return true;
        }
    }
}

public class Detail
{
    public char Letter { get; set; }
    public int Count { get; set; }

    public Detail(char letter, int count)
    {
        Letter = letter;
        Count = count;
    }
}
