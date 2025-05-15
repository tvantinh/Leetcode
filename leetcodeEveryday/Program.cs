//author : Tran Van Tinh
//Time : 15/5/2025

//question: Longest Unequal Adjacent Groups Subsequence I
/*
 * You are given a string array words and a binary array groups both of length n, where words[i] is associated with groups[i].

Your task is to select the longest alternating subsequence from words. A subsequence of words is alternating if for any two consecutive strings in the sequence, their corresponding elements in the binary array groups differ. Essentially, you are to choose strings such that adjacent elements have non-matching corresponding bits in the groups array.

Formally, you need to find the longest subsequence of an array of indices [0, 1, ..., n - 1] denoted as [i0, i1, ..., ik-1], such that groups[ij] != groups[ij+1] for each 0 <= j < k - 1 and then find the words corresponding to these indices.

Return the selected subsequence. If there are multiple answers, return any of them.
 */
public class Program
{
    public static IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        IList<string> list = new List<string>();
        int n = words.Length;
        if (n == 0)
            return list;
        list.Add(words[0]);
        int choosed = groups[0];
        for (int i = 1; i < n; i++)
        {
            if (groups[i] != choosed)
            {
                list.Add(words[i]);
                choosed = groups[i];
            }
        }
        return list;
    }
    static void Main()
    {
        string[] words = { "a", "b", "c", "d" };
        int[] groups = { 1, 0, 1, 1 };
        IList<string> result = GetLongestSubsequence(words, groups);
        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }
}
