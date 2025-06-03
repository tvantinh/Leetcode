public class TowSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int find = target - nums[i];
            if (map.ContainsKey(find))
            {
                return new int[] { map[find], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No solution found");
    }
    public static void Main()
    {
        TowSum solution = new TowSum();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}