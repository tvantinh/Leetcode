public class Solution
{
    public int Reverse(int x)
    {
        int Max = (int)Math.Pow(2, 31) - 1;
        int Min = (int)Math.Pow(-2, 31);

        int a = 0;
        int reverse = 0;
        while (x != 0)
        {
            if (reverse > Max / 10 || reverse < Min / 10)
                return 0;
            a = (x % 10);
            reverse = reverse * 10 + a;
            x = x / 10;
        }
        return reverse;
    }
    public static void Main()
    {
        Solution solution = new Solution();
        int x = 1534236469;
        int result = solution.Reverse(x);
        Console.WriteLine(result);
    }
}