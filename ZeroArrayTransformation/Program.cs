public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;//tính để đủ
            for (int j = 0; j < queries.Length; j++)
            {
                if (i >= queries[j][0] && i <= queries[j][1])
                    count++;
            }
            if (nums[i] > count)
                return false;
        }
        return true;
    }
    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = {2};
        int[][] queries = { new int[] { 0, 0 }, new int[] { 0, 0 } };
        bool result = solution.IsZeroArray(nums, queries);
        Console.WriteLine(result); // Output: false
    }
}