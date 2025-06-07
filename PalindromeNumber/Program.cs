public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        else
        {
            int reverse = 0;
            int change = x;
            while (change != 0)
            {
                int temp = change % 10;
                reverse = reverse * 10 + temp;
                change = change / 10;
            }
            if (x != reverse)
                return false;
            else
                return true;
        }
    }
    public static void Main()
    {
        PalindromeNumber solution = new PalindromeNumber();
        int x = 121;
        bool result = solution.IsPalindrome(x);
        Console.WriteLine(result);
    }
}